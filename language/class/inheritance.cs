using System;

public class myclass
{
  public int i;
  public void printi()
  {
    Console.WriteLine(i);
  }
}

public class otherclass : myclass
{
  public int x;
}

class Program
{
  static void Main(string[] args)
  {
    myclass myobj = new myclass();
    myobj.i = 10;
    myobj.printi();

    otherclass myobj3 = new otherclass();
    myobj3.i = 11;
    myobj3.x = 12;
    myobj3.printi();
  }
}
