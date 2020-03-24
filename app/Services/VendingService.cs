using System;
using System.Collections.Generic;
using vending_machine.Interfaces;
using vending_machine.Models;
namespace vending_machine.Services
{
  class VendingService
  {
    private Store _store = new Store();
    public string DrawMerch()
    {
      string template = "";
      List<ISellable> snacks = _store.Merchandise;
      for (int i = 0; i < _store.Merchandise.Count; i++)
      {
        ISellable snack = _store.Merchandise[i];
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
    public void AddQuarter(int num)
    {
      double change = num * 0.25;
      if (_store.User.Credit >= change)
      {
        _store.User.Credit -= change;
        _store.Balance += change;
        Console.WriteLine($"Balance: ${_store.Balance}, Credit: ${_store.User.Credit}");
      }
      else
      {
        Console.WriteLine("You don't have that much!");
      }
    }
    public void GiveChange()
    {
      _store.User.Credit += _store.Balance;
      Console.WriteLine($"Quarters returned: {_store.Balance / 0.25}. Current Credit: ${_store.User.Credit}.");
      _store.Balance = 0;
    }
    public void BuySnack(int i)
    {
      Console.Clear();
      i--;
      ISellable snack = _store.Merchandise[i];
      if (snack.Price > _store.Balance)
      {
        Console.WriteLine($"You don't have enough quarters for that! Machine balance: ${_store.Balance}");
      }
      else
      {
        snack.Stock--;
        _store.Balance -= snack.Price;
        Console.WriteLine($"You purchased {snack.Name} for ${snack.Price}. You now have ${_store.Balance}");
      }
    }
  }
}