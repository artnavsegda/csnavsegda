using System;

public class myclass
{
  public int i;
  public static int x;
  public void printi()
  {
    Console.WriteLine(i);
  }
  public static void printx()
  {
    Console.WriteLine(x);
  }
}

class Program
{
  static void Main(string[] args)
  {
    myclass.x = 20;
    myclass.printx();
    myclass myobj = new myclass();
    myobj.i = 10;
    myobj.printi();
  }
}
