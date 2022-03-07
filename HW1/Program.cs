using System;

namespace HW1
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            int[] test = new int[] { 1, 28, 31, 3, 11, 2, 19, 34 };
            Generic<int> generic = new Generic<int>();
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }

            test = generic.AddRange(test);
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }

            Console.WriteLine("===========");
            generic.Sort();
            for (int i = 0; i < generic.Count; i++)
            {
                Console.WriteLine(generic[i]);
            }
        }
    }
}