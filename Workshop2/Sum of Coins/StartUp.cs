using System;
using System.Collections.Generic;
using System.Linq;

namespace Sum_of_Coins
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 5, 10, 20, 50 };
            var sum = 923;

            var selectedCoins = ChooseCoins(numbers, sum);

            
            Console.WriteLine($"Numbers of coins to take: {selectedCoins.Values.Sum()}");

            foreach (var item in selectedCoins)
            {
                Console.WriteLine($"{item.Value} coin(s) with value {item.Key}");
            }
        }

        private static Dictionary<int,int> ChooseCoins(IList<int> coins, int sum)
        {
            var sortedCoins = coins.OrderByDescending(c => c).ToList();
            var chosenCoins = new Dictionary<int, int>();
            var currentSum = 0;
            var cointIndex = 0;

            while (currentSum != sum
                && cointIndex < sortedCoins.Count)
            {
                var currentCointValue = sortedCoins[cointIndex];
                int remainingtSum = sum - currentSum;
                int numberOfCoint = remainingtSum / currentCointValue;
                if (numberOfCoint>0)
                {
                    chosenCoins[currentCointValue] = numberOfCoint;
                    currentSum += currentCointValue * numberOfCoint;
                }
                cointIndex++;
            }
            if (currentSum==sum)
            {
                return chosenCoins;
            }
            else
            {
                throw new InvalidOperationException();
            }
        }
    }
}
