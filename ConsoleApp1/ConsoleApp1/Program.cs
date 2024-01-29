using System;
using ConsoleApp1;
using static ConsoleApp1.CodeCesar;
class MyClass
{

   private int A = 10;

   public MyClass(int i)
   {
      this.A = i;
   }
   private static void Main (String[] args)
   {
      List<int> l = new List<int>();
      List<int> d = new List<int>();
   d.Add(1);   d.Add(2); 
   d.Add(3); 
   d.Add(5); 
 
      l.Add(1); l.Add(1); l.Add(1); l.Add(1); l.Add(1); l.Add(1); l.Add(1);l.Add(8);
      Vigenere V = new Vigenere(l, 4);
      V.Decaler(d);

   }
}