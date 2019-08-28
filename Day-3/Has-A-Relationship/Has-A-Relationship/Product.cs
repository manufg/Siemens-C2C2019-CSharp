using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Has_A_Relationship
{
    class Product
    {
        private Category categoryInfo;
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }        
        //foreign key property
        public int CategoryId { private set; get; }        
        //association/navigation property
        public Category CategoryInfo
        {
            set
            {
                if (value != null)
                {
                    categoryInfo = value;
                    CategoryId = value.CategoryId;
                }
            }
            get { return categoryInfo; }
        }
        public Product()
        {

        }
        public Product(string productName, int productId, string description, decimal price, Category category = null)
        {
            this.Description = description;
            this.Price = price;
            this.ProductId = productId;
            this.ProductName = productName;
            //this.CategoryId = categoryId;
            if(category != null)
            {
                categoryInfo = category;
                CategoryId = category.CategoryId;
            }
        }
        public override string ToString()
        {
            return $"Name: {ProductName}, Id:{ProductId}, Price: {Price}, Category Id:{CategoryId} and Description:{Description}";
        }
    }
}
