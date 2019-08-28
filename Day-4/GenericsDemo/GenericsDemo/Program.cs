using System;

namespace GenericsDemo
{
    interface IDataAccess<T> //where T : class
    {
        T[] GetAllData();
        T GetData(int id);
        bool AddData(T data);
        bool RemoveData(int id);
        bool UpdateData(T newData);
    }
    class DataAccess<T> : IDataAccess<T> where T : class
    {
        public virtual bool AddData(T data)
        {
            return false;
        }

        public T[] GetAllData()
        {
            return new T[] { };
        }

        public T GetData(int id)
        {
            return default(T);
        }

        public bool RemoveData(int id)
        {
            return false;
        }

        public bool UpdateData(T newData)
        {
            return false;
        }
    }
    class FileDataAccess : DataAccess<string>
    {
        public override bool AddData(string data)
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Add<T>(T x, T y) where T : struct
        {

        }
        static void Add<T1, T2>(T1 x, T2 y) where T1 : struct where T2 : struct
        {

        }
        static void Main()
        {
            Add<int>(12, 13);
            FileDataAccess fileDataAccess = new FileDataAccess();
            string[] data = fileDataAccess.GetAllData();
        }
    }
}
