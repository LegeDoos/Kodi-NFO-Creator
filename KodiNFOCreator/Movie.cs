using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace LegeDoos.KodiNFOCreator
{
    public class Movie
    {
        private string FileName { get; set; }

        //properties
        //for def see http://wiki.xbmc.org/index.php?title=NFO_files/movies
        public string title { get; set; }
        public string originaltitle { get; set; }
        public string sorttitle { get; set; }
        public int year { get; set; }
        public string outline { get; set; }
        public string plot { get; set; }
        public int runtime { get; set; }


        public static XmlSerializer xs;


        public Movie()
        {
        }


        public Movie(string file)
        {
            if (!Init(file))
            {
                throw new Exception(string.Format("File {0} not found", file));
            }
            xs = new XmlSerializer(typeof(Movie));

            //tmp
            title = "dit is de title";
            originaltitle = "dit is originaltitle";
            sorttitle = "dit is sorttitle";
            year = 2009;
            runtime = 134;
            outline = "this is the outline";
            plot = "this is the plot";

        }

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
    }
}
