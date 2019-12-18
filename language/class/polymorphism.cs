using System;

public class myclass
{
  public int i;
  public virtual void printsome()
  {
    Console.WriteLine(i);
  }
}

public class otherclass : myclass
{
  public int x;
  public override  void printsome()
  {
    Console.WriteLine(i*x);
  }
}

class Program
{
  static void Main(string[] args)
  {
    myclass myobj = new myclass();
    myobj.i = 10;
    myobj.printsome();

    otherclass myobj3 = new otherclass();
    myobj3.i = 11;
    myobj3.x = 2;
    myobj3.printsome();
  }
}
