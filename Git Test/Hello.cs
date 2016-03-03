using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Git_Test
{
    public class Hello
    {
        public static void Main()
        {
            System.Console.WriteLine("Hi");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (j<=i)
                    {
                        System.Console.Write("*");
                    }
                }
                System.Console.WriteLine();
            }
            System.Console.ReadLine();
        }
    }
}