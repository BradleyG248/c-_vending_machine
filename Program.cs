using System;
using vending_machine.Controllers;

namespace vending_machine
{
  class Program
  {
    static void Main(string[] args)
    {
      VendingController vc = new VendingController();
      vc.Run();
    }
  }
}
