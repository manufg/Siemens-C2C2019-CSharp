using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    abstract class DataAccess
    {
        string path;
        public DataAccess()
        {

        }
        public DataAccess(string path)
        {
            this.path = path;
        }
        public string Path
        {
            set { path = value; }
            get { return path; }
        }
        public abstract string Data { get; }
        public abstract void GetData();
    }
}
