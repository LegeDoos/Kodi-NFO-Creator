using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.Net;
using System.Xml.Linq;
using System.IO;



namespace LegeDoos.KodiNFOCreator
{
    class MovieScraperOMdb : MovieScraper
    {
        public MovieScraperOMdb()
        {
            InitSearchResults();
        }

        public override void SearchForTitlePart(string titlePart)
        {
            InitSearchResults();
            string request = CreateSearchRequest(titlePart);
            XDocument result = MakeRequest(request);
            if (result != null)
            {
                ProcessResponse(result);
            }
        }

        #region.ServiceMethods

        private string CreateSearchRequest(string queryString)
        {
            string request = "http://www.omdbapi.com/?s={0}&r=xml";
            return (string.Format(request, queryString));
        }

        private XDocument MakeRequest(string requestUrl)
        {
            try
            {
                HttpWebRequest request = WebRequest.Create(requestUrl) as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                XDocument xDoc = XDocument.Load(new StreamReader(response.GetResponseStream()));
                return (xDoc);

            }
            catch (Exception e)
            {
                //throw new InvalidDataException();
                return null;
            }
        }

        private void ProcessResponse(XDocument response)
        {
            IEnumerable<XElement> rows = response.Descendants().Where(d => d.Name == "Movie");
            foreach (XElement element in rows)
            {
                string id = element.Attribute("imdbID").Value;
                if (id != string.Empty)
                {
                    IMDbItem i = new IMDbItem(id);
                    i.Title = GetValue(element, "Title");
                    i.Year = GetValue(element, "Year");
                    i.Type = GetValue(element, "Type");
                    AddSearchResult(i.DisplayTitle, i);
                }
            }
        }

        private string GetValue(XElement element, string p)
        {
            string retVal = "";
            try
            {
                retVal = element.Attribute(p).Value;
            }
            catch (Exception)
            {
                retVal = "";
            }
            return retVal;
        }

        

        #endregion
    }

}
