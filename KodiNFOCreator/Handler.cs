using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegeDoos.KodiNFOCreator
{
    class Handler
    {
        Movie movie;
        string sourceFull { get; set; }
        public string sourcePath
        {
            get 
            {
                return Path.GetDirectoryName(sourceFull);
            }
        }
        public string sourceFile
        {
            get
            {
                return Path.GetFileName(sourceFull);
            }
        }
        public string sourceExtension
        {
            get
            {
                return Path.GetExtension(sourceFull);
            }
        }

        public Handler(string _fileName)
        {
            movie = new Movie(_fileName);
            sourceFull = _fileName;
        }
    }
}
