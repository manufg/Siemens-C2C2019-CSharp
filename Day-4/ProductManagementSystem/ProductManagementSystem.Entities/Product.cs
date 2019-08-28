namespace ProductManagementSystem.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public override string ToString()
        {
            return $"Name:{Name}, Id:{Id}, Price:{Price} and Description:{Description}";
        }
        public override bool Equals(object obj)
        {
            Product other = obj as Product;
            if (this == other)
                return true;

            if (!this.Id.Equals(other.Id))
                return false;

            if (!this.Name.Equals(other.Name))
                return false;

            if (!this.Price.Equals(other.Price))
                return false;

            if (!this.Description.Equals(other.Description))
                return false;

            return true;
        }
        public override int GetHashCode()
        {
            const int prime = 31;
            return this.Id.GetHashCode() * prime;
        }
    }
}
