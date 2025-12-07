using System;

class MethodOverload
{
   // test overloaded square methods
   static void Main()
   {
      Console.WriteLine($"Square of integer 7 is {Square(7)}");
      Console.WriteLine($"Square of double 7.5 is {Square(7.5)}");
   }

   // square method with int argument                           
   static int Square(int intValue)
   {
      Console.WriteLine($"Called square with int argument: {intValue}");
      return intValue * intValue;
   }

   // square method with double argument                           
   static double Square(double doubleValue)
   {
      Console.WriteLine(
         $"Called square with double argument: {doubleValue}");
      return doubleValue * doubleValue;
   }
}
