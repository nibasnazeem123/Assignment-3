using System;

namespace Program
{
    
    public class BClass  //baseclass
    {
       public virtual void Display()
       {
          Console.WriteLine("Hi,I am Nibas");
       }
    }
    
    public class DClass : BClass //derived class
    {
       public override void Display()
       {
          Console.WriteLine("Welcome to Nest Digital");
       }
    }
    class Program
    {
       static void Main(string[] args)
       {
          DClass d = new DClass();
          d.Display();
          BClass b = new BClass();
          b.Display();
          
       }
    }
}