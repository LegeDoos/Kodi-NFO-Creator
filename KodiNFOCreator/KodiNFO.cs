using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LegeDoos.KodiNFOCreator
{
    /// <summary>
    /// Class representing the NFO file
    /// </summary>
    public class KodiNFO
    {
        private string FileName { get; set; }

        #region.members

        //for def see http://wiki.xbmc.org/index.php?title=NFO_files/movies
        public string title { get; set; }
        public string originaltitle
        {
            get
            {
                return title;
            }
        }  
        public string sorttitle
        {
            get
            {
                return title;
            }
        }  
        public int year { get; set; }
        public string outline { get; set; }
        public string plot { get; set; }
        public int runtime { get; set; }

        public static XmlSerializer xs;

        #endregion

        #region.constructors

        public KodiNFO()
        {
        }

        public KodiNFO(string file)
        {
            if (!Init(file))
            {
                throw new Exception(string.Format("File {0} not found", file));
            }
            xs = new XmlSerializer(typeof(KodiNFO));
        }

        #endregion

        #region.methods

        private Boolean Init(string file)
        {
            if (File.Exists(file))
            {
                FileName = file;
                return true;
            }
            return false;
        }

        public void SaveNFO(string TargetFileName)
        {
            if (Directory.Exists(Path.GetDirectoryName(TargetFileName)))
            {
                using (StreamWriter sw = new StreamWriter(TargetFileName))
                {
                    xs.Serialize(sw, this);
                }
            }
        }

        #endregion
    }
}
