using System;

public class myclass
{
  int i;
  public void printi()
  {
    Console.WriteLine(i);
  }
  public void seti(int itoset)
  {
    i = itoset;
  }
}

class Program
{
  static void Main(string[] args)
  {
    myclass myobj = new myclass();
    myobj.seti(20);
    myobj.printi();
  }
}
