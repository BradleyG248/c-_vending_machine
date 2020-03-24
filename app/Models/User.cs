namespace vending_machine.Models
{
  class User
  {
    public string Name { get; set; }
    public double Credit { get; set; }
    public User(string name, float wallet)
    {
      Name = name;
      Credit = wallet;
    }
  }
}