using System;
using vending_machine.Services;

namespace vending_machine.Controllers
{
  public class VendingController
  {
    private bool _running = true;
    private VendingService _vs = new VendingService();
    public void Run()
    {
      _vs.NewUser();
      while (_running)
      {
        Console.Write(_vs.DrawSnacks());
        BuySnack();
        Exit();
      }
    }
    private void Exit()
    {
      Console.Write("Back to the mine? (quit):");
      string input = Console.ReadLine();
      if (input == "quit")
      {
        _running = false;
      }
    }
    private void BuySnack()
    {
      Console.Write($"Buy a snack? (y/n):");
      string buy = Console.ReadLine();
      if (buy == "yes" || buy == "y")
      {
        Console.Write("Snack Number: ");
        string purchase = Console.ReadLine();
        int choice;
        Int32.TryParse(purchase, out choice);
        _vs.BuySnack(choice);
      }

    }
  }
}