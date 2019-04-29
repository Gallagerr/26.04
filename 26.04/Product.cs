namespace _26._04
{
  public class Product : Entity
  {
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
    public Manufacturer Manufacturer { get; set; }
    public Guid ManufacturerId { get; set; }
  }
}