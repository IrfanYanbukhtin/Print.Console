using System;

namespace _06._01._23
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 20; i++)
            //{
            //    for (int j = 0; j < 20; j++)
            //    {
            //        if (i == j || i + j == 19)
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}



            //for (int i = 0; i < 15; i++)
            //{
            //    for (int j = 0; j < 20; j++)
            //    {
            //        if (j == 0 || j == 19 || (i == j && i < 10) || (i + j == 19 && i < 10))
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();




            //for (int i = 0; i < 20; i++)
            //{
            //    for (int j = 0; j < 20; j++)
            //    {
            //        if (j == 0 || i==j || i ==19)
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            // }




            //for (int i = 0; i < 21; i++)
            //{
            //    for (int j = 0; j < 21; j++)
            //    {
            //        if (i + j == 10 || j - i == 10 || i == 5 )
            //            Console.Write("*");
            //        else
            //            Console.Write(" ");
            //    }
            //    Console.WriteLine();
            //}



            for (int i = 0; i < 21; i++)
            {
                for (int j = 0; j < 21; j++)
                {
                    if (i + j == 10 || j - i == 10 || i == 5 && j>=i && j<=i+10)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }
    }
}
