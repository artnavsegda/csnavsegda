using System;

public class myclass
{
  public int i;
  public void printi()
  {
    Console.WriteLine(this.i);
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
