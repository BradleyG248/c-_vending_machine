using System;
using System.Linq;
using vending_machine.Services;

namespace vending_machine.Controllers
{
  public class VendingController
  {
    private bool _running = true;
    private VendingService _vs = new VendingService();
    public void Run()
    {
      Console.Clear();
      _vs.NewUser();
      while (_running)
      {
        Console.Write(_vs.DrawMerch());
        Input();
      }
    }
    private void Input()
    {
      Console.Write("What would you like to do? Options: (quit, add, add(num), buy(num), change):");
      string input = Console.ReadLine();
      if (input == "quit")
      {
        _running = false;
      }
      else if (input.Any(char.IsDigit) && input.StartsWith("add"))
      {
        input.Trim();
        string char123 = input[input.Length - 1].ToString();
        int num;
        Int32.TryParse(char123, out num);
        _vs.AddQuarter(num);
      }
      else if (input == "add")
      {
        Console.Clear();
        _vs.AddQuarter(1);
      }
      else if (input.Any(char.IsDigit) && input.StartsWith("buy"))
      {
        input.Trim();
        string char123 = input[input.Length - 1].ToString();
        int num;
        Int32.TryParse(char123, out num);
        _vs.BuySnack(num);
      }
      else if (input == "change")
      {
        Console.Clear();
        _vs.GiveChange();
      }
      else
      {
        Console.WriteLine("Pardon?");
        Input();
      }
    }
  }
}