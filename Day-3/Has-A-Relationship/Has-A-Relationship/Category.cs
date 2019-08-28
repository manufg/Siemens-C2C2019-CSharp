using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Has_A_Relationship
{
    class Category
    {
        private Product[] products;

        public int CategoryId { set; get; }
        public string CategoryName { set; get; }

        public Product[] Products
        {
            set { products = value; }
            get { return products; }
        }

        public Category()
        {

        }
        public Category(string categoryName, int categoryId, Product[] products = null)
        {
            this.CategoryName = categoryName;
            this.CategoryId = categoryId;
            this.products = products;
        }
        public override string ToString()
        {
            return $"Name: {CategoryName} and Id:{CategoryId}";
        }
    }
}
