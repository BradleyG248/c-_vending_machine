using System.Collections.Generic;

namespace vending_machine.Models
{
  class Store
  {
    public List<Snack> Snacks { get; set; }
    public User User;
    public Store()
    {
      Snacks = new List<Snack>(){
        new Snack("Cheetos", "FritO'Lay", 1, 5),
        new Snack("Doritos", "FritO'Lay", 1.25, 10),
        new Snack("Coke", "Coca Cola", 1.50, 7),
        new Snack("Pepsi", "Pepsi Cola", 1, 10),
        new Snack("Mountain Dew", "Pepsi Cola", 2, 20),
        new Snack("Fritos", "FritO'Lay", 1.25, 4)
      };
      User = new User("", 1);
    }
  }
}