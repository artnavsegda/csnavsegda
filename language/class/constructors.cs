using System;

public class myclass
{
  public myclass()
  {
    Console.WriteLine("Class created");
  }

  public myclass(myclass prevclass)
  {
    Console.WriteLine("Class copied");
  }

  public myclass(int i)
  {
    Console.WriteLine("Class created with parameter " + i);
  }

  ~myclass()
  {
    Console.WriteLine("Class destroyed");
  }
}

class Program
{
  static void Main(string[] args)
  {
    myclass myobj = new myclass();
    myclass myobj2 = new myclass(myobj);
    myclass myobj3 = new myclass(10);
  }
}
