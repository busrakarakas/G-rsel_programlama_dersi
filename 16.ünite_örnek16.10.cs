using System;
using System.Text;

class StringBuilderFeatures
{
   static void Main()
   {
      var buffer = new StringBuilder("Hello, how are you?");

      // use Length and Capacity properties
      Console.WriteLine($"buffer = {buffer}" +
         $"\nLength = {buffer.Length}" +
         $"\nCapacity = {buffer.Capacity}");

      buffer.EnsureCapacity(75); // ensure a capacity of at least 75
      Console.WriteLine($"\nNew capacity = {buffer.Capacity}");

      // truncate StringBuilder by setting Length property
      buffer.Length = 10;
      Console.Write($"New length = {buffer.Length}\n\nbuffer = ");

      // use StringBuilder indexer
      for (int i = 0; i < buffer.Length; ++i)
      {
         Console.Write(buffer[i]);
      }

      Console.WriteLine();
   }
} 
