using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDimArray
{

   class Program
   {
       static void Main(string[] args)
       {

           int[,] dice = new int[4, 2];                   
                                                             
           Random myRandom = new Random();

           for (int i = 0; i < 4; i++)          
           {
               for (int j = 0; j < 2; j++)             
               {
                   dice[i, j] = myRandom.Next(6) + 1;

               }
           }
           for (int i = 0; i < 4; i++)         
           {
               for (int j = 0; j < 2; j++)            
               {
                   Console.Write(dice[i, j] + "  ");

               }
               Console.WriteLine();
           }
           Console.ReadLine();

       }
   }
}

