using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class DbDataAccess : DataAccess
    {
        private string dbData;
        public DbDataAccess()
        {

        }
        public DbDataAccess(string path)
            : base(path)
        {

        }
        public override string Data
        {
            get { return dbData; }
        }
        public override void GetData()
        {
            dbData = "got data from db";
        }
    }
}
