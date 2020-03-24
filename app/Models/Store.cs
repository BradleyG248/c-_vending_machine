using System.Collections.Generic;
using vending_machine.Interfaces;

namespace vending_machine.Models
{
  class Store
  {
    public List<Snack> Snacks { get; set; }
    public List<Electronic> Electronics { get; set; }
    public List<ISellable> Merchandise { get; set; }
    public User User;
    public double Balance;
    public Store()
    {

      Merchandise = new List<ISellable>(){
        new Snack("Cheetos", "FritO'Lay", 1, 5),
        new Snack("Doritos", "FritO'Lay", 1.25, 10),
        new Snack("Coke", "Coca Cola", 1.50, 7),
        new Snack("Pepsi", "Pepsi Cola", 1, 10),
        new Snack("Mountain Dew", "Pepsi Cola", 2, 20),
        new Snack("Fritos", "FritO'Lay", 1.25, 4),
        new Electronic("HS515", "Corsair", 10, 2),
        new Electronic("PowerBank1000", "Comrades Co.", 5, 5),
        new Electronic("iPhone 11", "Apple", 1500, 1)
      };
      User = new User("", 1);
      Balance = 0;
    }
  }
}