using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ProductManagementSystem.DataAccessLayer.Implementation;
using ProductManagementSystem.Entities;

namespace ProductManagementSystem.DataAccessLayer.Tests
{
    [TestClass]
    public class ProductDataAccessComponentTest
    {
        private ProductDataAccessComponent dataAccessComponent;

        [TestInitialize]
        public void Initialize()
        {
            dataAccessComponent
                = new ProductDataAccessComponent();
        }

        [TestCleanup]
        public void Clear()
        {
            dataAccessComponent = null;
        }

        [TestMethod]
        public void GetAllDataTest()
        {
            List<Product> actual =
                dataAccessComponent.GetAllData() as List<Product>;

            List<Product> expected = new List<Product>
            {
                new Product{ Name="dell xps", Id=1,Price=67000,Description="new laptop from dell"},
                new Product{ Name="motog", Id=2,Price=13000,Description="new mobile from motorola"},
                new Product{ Name="the alchemist", Id=3,Price=699,Description="new book by the author paul coelho"}
            };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddDataTest()
        {
            bool actual = dataAccessComponent.Add(
                  new Product
                  {
                      Id = 5,
                      Name = "one plus 7",
                      Price = 30000,
                      Description = "new mobile from One Plus"
                  });
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }
    }
}
