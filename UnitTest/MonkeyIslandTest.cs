using LookingForBananas;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class MonkeyIslandTest
    {
        [TestMethod]
        public void GetMaxBanana_Success()
        {
            MonkeyIsland monkeyIsland = new MonkeyIsland();

            int[,] matrix = new int[,] 
            {
               {1, 3, 3} ,
               {2, 1, 4} ,
               {0, 6, 4}
            };

            int total = monkeyIsland.GetMaxBananas(matrix);
            Assert.AreEqual(12, total);

            matrix = new int[,] 
            {
               {1, 3, 1, 5} ,
               {2, 2, 4, 1} ,
               {5, 0, 2, 3},
               {0, 6, 1, 2},
            };

            total = monkeyIsland.GetMaxBananas(matrix);
            Assert.AreEqual(16, total);

            matrix = new int[,] 
            {
               {10, 33, 13, 15} ,
               {22, 21, 4, 1 } ,
               {5, 0, 2, 3},
               {0, 6, 14, 2},
            };

            total = monkeyIsland.GetMaxBananas(matrix);
            Assert.AreEqual(83, total);
        }

        [TestMethod]
        public void GetMaxBanana_Error()
        {
            MonkeyIsland monkeyIsland = new MonkeyIsland();

            int[,] matrix = new int[,] 
            {
               {1, 3, 3} ,
               {2, 1, 4} ,
               {0, 6, 4}
            };

            int total = monkeyIsland.GetMaxBananas(matrix);
            Assert.AreNotEqual(10, total);
        }

        [TestMethod]
        public void GetMaxBanana_Matrix_Empty()
        {
            MonkeyIsland monkeyIsland = new MonkeyIsland();

            int[,] matrix = new int[,] {};

            int total = monkeyIsland.GetMaxBananas(matrix);
            Assert.IsTrue(total == 0);
        }

        [TestMethod]
        public void GetMaxBanana_Matrix_Null()
        {
            MonkeyIsland monkeyIsland = new MonkeyIsland();

            int[,] matrix = new int[,] { };

            int total = monkeyIsland.GetMaxBananas(null);
            Assert.IsTrue(total == 0);
        }

        [TestMethod]
        public void PrintArray_Matrix_Null()
        {
            MonkeyIsland monkeyIsland = new MonkeyIsland();

            int[,] matrix = new int[,] { };

            monkeyIsland.PrintArray(null);
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void PrintArray_Success()
        {
            MonkeyIsland monkeyIsland = new MonkeyIsland();

            int[,] matrix = new int[,] 
            {
               {1, 3, 3} ,
               {2, 1, 4} ,
               {0, 6, 4}
            };

            monkeyIsland.PrintArray(matrix);
            Assert.IsTrue(true);
        }
    }
}
