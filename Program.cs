using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Star Pattern Example 1
            Console.WriteLine("Star Pattern Example 1");
            for (int irow = 1; irow <= 8; irow++)
            {
                for (int icol = 1; icol <= irow; icol++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            //Star Pattern Example 2
            Console.WriteLine("Star Pattern Example 2");
            int ivalue = 8;
            int ival, jval;
            for (ival = 1; ival <= ivalue; ival++)
            {
                //Blank          
                for (jval = 1; jval <= ivalue; jval++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            //Star Pattern Example 3
            Console.WriteLine("Star Pattern Example 3");
            int irowval = 8;
            int i, j, k;
            for (i = 1; i <= irowval; i++)
            {
                //Blank          
                for (j = 1; j <= irowval - i; j++)
                {
                    Console.Write(" ");
                }

                //Star
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }

                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
