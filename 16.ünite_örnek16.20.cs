using System;
using System.Text.RegularExpressions;

class RegexMatches
{
   static void Main( string[] args )
   {
      // create a regular expression
      Regex expression = new Regex( @"J.*\d[\d-[4]]-\d\d-\d\d" );

      string testString =
         "Jane's Birthday is 05-12-75\n" +
         "Dave's Birthday is 11-04-68\n" +
         "John's Birthday is 04-28-73\n" +
         "Joe's Birthday is 12-17-77";

      // display all matches to the regular expression
      foreach ( var regexMatch in expression.Matches( testString ) )
         Console.WriteLine( regexMatch );
   } // end Main
} // end class RegexMatches
