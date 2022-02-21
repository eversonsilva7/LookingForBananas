using System;

namespace LookingForBananas
{
    class Program
    {
        static void Main(string[] args)
        {
            MonkeyIsland monkeyIsland = new MonkeyIsland();

            int[,] matrix = new int[,] 
            {
               {1, 3, 3} ,
               {2, 1, 4} ,
               {0, 6, 4}
            };

            Console.WriteLine("---------Original Matrix---------");
            Console.WriteLine();
            monkeyIsland.PrintArray(matrix);
            Console.WriteLine();
            Console.WriteLine("Maximum amount of bananas: " + monkeyIsland.GetMaxBananas(matrix));
            Console.WriteLine();
            Console.WriteLine("*********************************");
            Console.WriteLine();

            matrix = new int[,] 
            {
               {1, 3, 1, 5} ,
               {2, 2, 4, 1} ,
               {5, 0, 2, 3},
               {0, 6, 1, 2},
            };

            Console.WriteLine("---------Original Matrix---------");
            Console.WriteLine();
            monkeyIsland.PrintArray(matrix);
            Console.WriteLine();     
            Console.WriteLine("Maximum amount of bananas: " + monkeyIsland.GetMaxBananas(matrix));
            Console.WriteLine();
            Console.WriteLine("*********************************");
            Console.WriteLine();

            matrix = new int[,] 
            {
               {10, 33, 13, 15} ,
               {22, 21, 4, 1 } ,
               {5, 0, 2, 3},
               {0, 6, 14, 2},
            };

            Console.WriteLine("---------Original Matrix---------");
            Console.WriteLine();
            monkeyIsland.PrintArray(matrix);
            Console.WriteLine();            
            Console.WriteLine("Maximum amount of bananas: " + monkeyIsland.GetMaxBananas(matrix));
            Console.WriteLine();      

            Console.ReadLine();
        }
    }
}
