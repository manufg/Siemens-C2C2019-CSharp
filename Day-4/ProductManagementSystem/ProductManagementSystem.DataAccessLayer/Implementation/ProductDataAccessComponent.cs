using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProductManagementSystem.Entities;
using ProductManagementSystem.DataAccessLayer.Contract;
using System.Configuration;
using System.IO;

namespace ProductManagementSystem.DataAccessLayer.Implementation
{
    public class ProductDataAccessComponent
        : IDataAccess<Product>
    {
        public bool Add(Product data)
        {
            bool addStatus = false;

            string path = GetFilePath();
            if (File.Exists(path))
            {
                StreamWriter writer = new StreamWriter(path, true);
                string stringData = ConvertProductToFileRecord(data);
                writer.WriteLine(Environment.NewLine + stringData);
                writer.Flush();
                writer.Close();
                addStatus = true;
            }
            return addStatus;
        }

        public IEnumerable<Product> GetAllData()
        {
            string path = GetFilePath();
            List<Product> products = new List<Product>();

            if (File.Exists(path))
            {
                StreamReader reader = new StreamReader(path);

                while (!reader.EndOfStream)
                {
                    string sentence = reader.ReadLine();
                    if (sentence != null & sentence != string.Empty)
                    {
                        string[] data = sentence.Split(
                            new char[] { ',' },
                            StringSplitOptions.RemoveEmptyEntries);

                        ConvertFileRecordToProduct(data, out Product product);

                        products.Add(product);
                    }
                }
                reader.Close();
            }
            return products;
        }

        public Product GetData<TKey>(TKey value)
        {
            throw new NotImplementedException();
        }

        private static string GetFilePath()
        {
            return ConfigurationManager.AppSettings["filePath"];
        }
        private void ConvertFileRecordToProduct(string[] data, out Product product)
        {
            product = new Product
            {
                Id = int.Parse(data[0]),
                Name = data[1],
                Price = decimal.Parse(data[2]),
                Description = data[3]
            };
        }
        private string ConvertProductToFileRecord(Product product)
        {
            string data = $"{product.Id},{product.Name},{product.Price},{product.Description}";
            return data;
        }
    }
}
