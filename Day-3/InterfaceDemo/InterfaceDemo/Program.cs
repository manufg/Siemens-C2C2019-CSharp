using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    //interface: 
    //pure abstract class
    //members are by default abstract and public (don't use any access specifier and abstract keyword)
    //ONLY abstract methods/properties are allowed
    interface IData
    {
        string Data { get; }
    }
    interface IDataAccess : IData
    {
        void GetData();
    }
    abstract class DataAccess : IDataAccess//, IData
    {
        string path;
        public DataAccess()
        {

        }
        public DataAccess(string path)
        {
            this.path = path;
        }
        public string Path { set { path = value; } get { return path; } }

        public abstract string Data { get; }
        public abstract void GetData();
    }
    class FileDataAccess : DataAccess //:IDataAccess
    {
        string fileData;
        public FileDataAccess()
        {

        }
        public FileDataAccess(string path) : base(path)
        {

        }
        /*
         * implementing interface 
         * while implementing interface members, override keyword is not used
         * */

        /*
       public string Data { get { return fileData; } }

       public void GetData()
       {
           fileData = "data from file";
       }
       */

        /*
         * inheriting from abstract class
         * while implementing abstract members, override keyword is used
         */
        public override string Data { get { return fileData; } }

        public override void GetData()
        {
            fileData = "data from file";
        }
        public string Test()
        {
            return "test data";
        }
    }
    class Program
    {
        static void GetandPrintData(IDataAccess dataAccess)
        {
            //explicit interface member invocation: calling members of interface through the variable of interface
            dataAccess.GetData();
            Console.WriteLine(dataAccess.Data);
        }
        static void Main()
        {
            FileDataAccess fileDataAccess = new FileDataAccess("");

            //implicit interface member invocation: calling members of interface through the variable of class
            //fileDataAccess.GetData();
            //Console.WriteLine(fileDataAccess.Data);
            //fileDataAccess.Test();

            GetandPrintData(fileDataAccess);
        }
    }
}
