using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LegeDoos.KodiNFOCreator
{
    //taken from: http://stackoverflow.com/questions/1437002/winforms-c-sharp-autocomplete-in-the-middle-of-a-textbox
    //taken from: http://stackoverflow.com/questions/8001450/c-sharp-wait-for-user-to-finish-typing-in-a-text-box
    //changed and optmized by LegeDoos

    public class AutoCompleteTextBox : TextBox
    {
        //middle search
        private ListBox _listBox;
        private bool _isAdded;
        private String[] values;
        public String[] Values 
        { 
            get
            {
                return values;
            }
            set
            {
                values = value;
                if (values == null)
                    return;
                UpdateListBox();
                if (this.Focused)
                    ShowListBox();
                
            }
        }
        private String _formerValue = String.Empty;
        /// <summary>
        /// Is the textbox in searchmode?
        /// </summary>
        public Boolean IsSearching { get; set; }
        
        //delay
        private Timer DelayedTextChangedTimer;
        public event EventHandler StoppedTypingTextChanged;
        private const int StoppedTypingTimeout = 1000; //1 sec

        public AutoCompleteTextBox() : base()
        {
            InitializeComponent();
            ResetListBox();
        }

        #region.middlesearch

        private void InitializeComponent()
        {
            _listBox = new ListBox();
            
            KeyDown += this_KeyDown;
            KeyUp += this_KeyUp;
        }

        private void ShowListBox()
        {
            if (!_isAdded)
            {
                Parent.Controls.Add(_listBox);
                _listBox.Left = Left;
                _listBox.Top = Top + Height;
                _isAdded = true;
            }
            _listBox.Visible = true;
            _listBox.BringToFront();
        }

        private void ResetListBox()
        {
            _listBox.Visible = false;
        }

        private void this_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateListBox();
        }

        private void this_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                //case Keys.Tab:
                case Keys.Enter:
                    {
                        if (_listBox.Visible)
                        {
                            InsertWord((String)_listBox.SelectedItem);
                            ResetListBox();
                            _formerValue = Text;
                        }
                        break;
                    }
                case Keys.Down:
                    {
                        if ((_listBox.Visible) && (_listBox.SelectedIndex < _listBox.Items.Count - 1))
                            _listBox.SelectedIndex++;

                        break;
                    }
                case Keys.Up:
                    {
                        if ((_listBox.Visible) && (_listBox.SelectedIndex > 0))
                            _listBox.SelectedIndex--;

                        break;
                    }
            }
        }

        protected override bool IsInputKey(Keys keyData)
        {
            switch (keyData)
            {
                //case Keys.Tab:
                case Keys.Enter:
                    return true;
                default:
                    return base.IsInputKey(keyData);
            }
        }

        private void UpdateListBox()
        {
            if (Text == _formerValue) return;
            _formerValue = Text;
            String word = Text;

            if (Values != null && word.Length > 0)
            {
                String[] matches = Array.FindAll(Values,
                                                 x => (x.ToLower().Contains(word.ToLower()) && !SelectedValues.Contains(x)));
                if (matches.Length > 0)
                {
                    ShowListBox();
                    _listBox.Items.Clear();
                    Array.ForEach(matches, x => _listBox.Items.Add(x));
                    _listBox.SelectedIndex = 0;
                    _listBox.Height = 0;
                    _listBox.Width = 0;
                    Focus();
                    using (Graphics graphics = _listBox.CreateGraphics())
                    {
                        for (int i = 0; i < _listBox.Items.Count; i++)
                        {
                            _listBox.Height += _listBox.GetItemHeight(i);
                            // it item width is larger than the current one
                            // set it to the new max item width
                            // GetItemRectangle does not work for me
                            // we add a little extra space by using '_'
                            int itemWidth = (int)graphics.MeasureString(((String)_listBox.Items[i]) + "_", _listBox.Font).Width;
                            _listBox.Width = (_listBox.Width < itemWidth) ? itemWidth : _listBox.Width;
                        }
                    }
                }
                else
                {
                    ResetListBox();
                }
            }
            else
            {
                ResetListBox();
            }
        }

        private String GetWord()
        {
            String text = Text;
            int pos = SelectionStart;

            int posStart = text.LastIndexOf(' ', (pos < 1) ? 0 : pos - 1);
            posStart = (posStart == -1) ? 0 : posStart + 1;
            int posEnd = text.IndexOf(' ', pos);
            posEnd = (posEnd == -1) ? text.Length : posEnd;

            int length = ((posEnd - posStart) < 0) ? 0 : posEnd - posStart;

            return text.Substring(posStart, length);
        }

        private void InsertWord(String newTag)
        {
            /*String text = Text;
            int pos = SelectionStart;

            int posStart = text.LastIndexOf(' ', (pos < 1) ? 0 : pos - 1);
            posStart = (posStart == -1) ? 0 : posStart + 1;
            int posEnd = text.IndexOf(' ', pos);

            String firstPart = text.Substring(0, posStart) + newTag;
            String updatedText = firstPart + ((posEnd == -1) ? "" : text.Substring(posEnd, text.Length - posEnd));

            
            Text = updatedText;
            SelectionStart = firstPart.Length;
             */
            Text = newTag;
            IsSearching = false;
        }

        public List<String> SelectedValues
        {
            get
            {
                String[] result = Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
               return new List<String>(result);
            }
        }

        #endregion

        #region.delay

        protected override void Dispose(bool disposing)
        {
            if (DelayedTextChangedTimer != null)
            {
                DelayedTextChangedTimer.Stop();
                if (disposing)
                    DelayedTextChangedTimer.Dispose();
            }

            base.Dispose(disposing);
        }

        protected virtual void OnDelayedTextChanged(EventArgs e)
        {
            if (this.StoppedTypingTextChanged != null)
                this.StoppedTypingTextChanged(this, e);
        }

        protected override void OnTextChanged(EventArgs e)
        {
            this.InitializeDelayedTextChangedEvent();
            base.OnTextChanged(e);
        }

        private void InitializeDelayedTextChangedEvent()
        {
            if (DelayedTextChangedTimer != null)
                DelayedTextChangedTimer.Stop();

            if (DelayedTextChangedTimer == null || DelayedTextChangedTimer.Interval != StoppedTypingTimeout)
            {
                DelayedTextChangedTimer = new Timer();
                DelayedTextChangedTimer.Tick += new EventHandler(HandleDelayedTextChangedTimerTick);
                DelayedTextChangedTimer.Interval = StoppedTypingTimeout;
            }
            DelayedTextChangedTimer.Start();
        }

        private void HandleDelayedTextChangedTimerTick(object sender, EventArgs e)
        {
            Timer timer = sender as Timer;
            timer.Stop();

            this.OnDelayedTextChanged(EventArgs.Empty);
        }
        #endregion
        
    }

}