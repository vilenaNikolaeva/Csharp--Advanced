using System;
using System.Collections.Generic;
using System.Linq;

namespace Set_Cover
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 3, 5, 7, 9, 11, 20, 30, 40 };
            var sets = new[]
            {
                    new[]{20 },
                    new[] {1, 5, 20, 30},
                    new[] {3, 7, 20,30, 40},
                    new[] {9, 30},
                    new[] {11, 20, 30, 40},
                    new[] {3,7,40}
            };
            var result = ChooseSets(sets.ToList(), arr.ToList());

            Console.WriteLine($"Sets to take {result.Count}");

            foreach (var item in result)
            {
                Console.WriteLine($"{{ {string.Join(", ", item)} }}");
            }
        }
        public static IList<int[]> ChooseSets(IList<int[]> sets, IList<int> arr)
        {
            var selectedSets = new List<int[]>();

            while (arr.Count>0)
            {
                var current = sets.OrderByDescending(set => set.Count(arr.Contains))
                    .First();
                selectedSets.Add(current);
                sets.Remove(current);

                foreach (var item in current)
                {
                    arr.Remove(item);
                }
            }
            return selectedSets;
        }
    }
}
