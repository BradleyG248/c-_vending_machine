using System;
using System.Collections.Generic;
using vending_machine.Models;
namespace vending_machine.Services
{
  class VendingService
  {
    private Store _store = new Store();
    public string DrawSnacks()
    {
      string template = "";
      List<Snack> snacks = _store.Snacks;
      for (int i = 0; i < _store.Snacks.Count; i++)
      {
        Snack snack = _store.Snacks[i];
        if (snack.Stock < 1)
        {
          template += $"{i + 1}. Out of Stock\n";
        }
        else
        {
          template += $"{i + 1}: {snack.Name}({snack.Brand}): ${snack.Price}\n";
        }
      }
      return template;
    }
    public void NewUser()
    {
      Console.WriteLine("Hello there, comrade! What is your name?");
      Console.Write("Name: ");
      string name = Console.ReadLine();
      _store.User.Name = name;
      Console.WriteLine($"It's your lucky day, {name}! Glorious Leader has granted you ${_store.User.Credit} credit for this vending machine!");
    }
    public void BuySnack(int i)
    {
      Console.Clear();
      i--;
      Snack snack = _store.Snacks[i];
      if (snack.Price > _store.User.Credit)
      {
        Console.WriteLine($"You don't have enough credit for that! You have ${_store.User.Credit}");
      }
      else
      {
        snack.Stock--;
        _store.User.Credit -= snack.Price;
        Console.WriteLine($"You purchased {snack.Name} for ${snack.Price}. You now have ${_store.User.Credit}");
      }
    }
  }
}