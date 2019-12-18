using System;

public class myclass
{
  public myclass()
  {
    Console.WriteLine("Class created");
  }
  public int i;
  public void printi()
  {
    Console.WriteLine(i);
  }
}

class Program
{
  static void Main(string[] args)
  {
    myclass myobj = new myclass();
    myobj.i = 10;
    myobj.printi();
  }
}
