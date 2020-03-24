using vending_machine.Interfaces;

namespace vending_machine.Models
{
  class Electronic : ISellable
  {

    public string Name { get; set; }
    public string Brand { get; set; }
    public double Price { get; set; }
    public int Stock { get; set; }
    public Electronic(string name, string brand, double price, int stock)
    {
      Name = name;
      Brand = brand;
      Price = price;
      Stock = stock;
    }
  }
}