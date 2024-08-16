namespace OData_Code_Example.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Size { get; set; }
        public List<Product>? Products { get; set; }
    }
}
