namespace LearnBlazor.Models
{
  public class Product
  {
        public int Id { get; set; }
        public string? Name { get; set;}
        public bool IsActive { get; set; }
        public double Price { get; set;}
        public required List<Product_Prop> ProductProperties { get; set; }
  }
}