using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Step1();
            Step2();
            Step3();
            Step4();
        }

        public static void Step1()
        {
            Console.WriteLine("Step 1\n");

            int i = 0;
            int[] n1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            IEnumerable<int> evennumbers = n1.Where(nums => nums % 2 == 0);

            foreach (var j in evennumbers)
            {
                Console.WriteLine(j);
            }

        }

        public static void Step2()
        {
            Console.WriteLine("Step 2\n");

            int[] n2 = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            IEnumerable<int> positiveNumsInList = n2.Where(nums => nums > 0 && nums < 12);

            foreach (var j in positiveNumsInList)
            {
                Console.WriteLine(j);
            }
        }

        public static void Step3()
        {
            Console.WriteLine("Step 3\n");

            var arr1 = new[] { 3, 9, 2, 8, 6, 5 }; //array to iterate through

            IEnumerable<int> printSquaresGreaterThan20 = arr1.Where(num => num > 4).Select(num => num * num);

            foreach (var j in printSquaresGreaterThan20)
            {
                Console.WriteLine($"num = {j} sqrnum = {j * j}");
            }
        }
        public static void Step4()
        {
            Console.WriteLine("Step 4\n");

            int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 }; //array to iterate through

            //IEnumerable<int> NumberofTimes = arr1.GroupBy(num => num).Select(num => num);
     
            //foreach (var j in NumberofTimes)
            //{
            //    Console.WriteLine($"Number = {}, appears = {} times ");
            //}
            var n = from x in arr1
                   group x by x into y
                   select y;
            Console.WriteLine("\nThe number and the Frequency are : \n");
            foreach (var arrNo in n)
            {
                Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
            }
            Console.WriteLine("\n");

        }
    }
}

