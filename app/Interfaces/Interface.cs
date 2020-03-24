namespace vending_machine.Interfaces
{
  interface ISellable
  {
    int Stock { get; set; }
    double Price { get; set; }
    string Name { get; set; }
    string Brand { get; set; }
  }
}