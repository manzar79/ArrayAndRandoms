using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Rextester

{
   class Program
   {
       static void Main(string[] args)
       {

           int[] dice = new int[6];    // the allowable index numbers are therefore 1 to 5
           Random myRandom = new Random();

           for (int i = 1; i < 6; i++) // the allowable index numbers are 1 to 5
           {
               dice[i] = myRandom.Next(6) + 1;
           }

           for (int i = 1; i < 6; i++) // the allowable index numbers are 1 to 5
           {
               Console.WriteLine(dice[i]);
           }
           Console.ReadLine();

       }
   }
}
        
