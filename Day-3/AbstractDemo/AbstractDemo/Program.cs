using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractDemo
{
    class Program
    {
        //static void GetandPrintData(FileDataAccess fileDataAccess)
        //{

        //}
        //static void GetandPrintData(DbDataAccess dbDataAccess)
        //{

        //}
        static void GetandPrintData(DataAccess dataAccess)
        {
            dataAccess.GetData();
            Console.WriteLine(dataAccess.Data);
        }
        static void Main()
        {
            FileDataAccess fileDataAccess = new FileDataAccess("");
            DbDataAccess dbDataAccess = new DbDataAccess("");
            GetandPrintData(fileDataAccess);
            GetandPrintData(dbDataAccess);
        }
    }
}
