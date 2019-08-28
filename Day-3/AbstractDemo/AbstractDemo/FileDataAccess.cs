using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class FileDataAccess : DataAccess
    {
        string fileData;
        public FileDataAccess()
        {

        }
        public FileDataAccess(string path) : base(path)
        {

        }
        public override string Data
        {
            get { return fileData; }
        }

        public override void GetData()
        {
            fileData = "got data from file";
        }
    }
}
