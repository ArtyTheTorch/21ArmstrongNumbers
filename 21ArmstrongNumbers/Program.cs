using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21ArmstrongNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(computeArmstrong(num));
            Console.WriteLine(isArmstrong(num));
            Console.ReadLine();
        }

        private static int computeArmstrong(int num)
        {
            //An armstrong number is a number that equals the sum of all the digits raised to the power of the count of the digits
            Stack<int> digits = new Stack<int>();
            int temp = num;
            int count = 0;
            int results = 0;
            do{
                count++;
                digits.Push(temp%10);
                temp = temp/10;
            }
            while(temp>0);

            foreach(int i in digits)
            {
                results += Convert.ToInt32(Math.Pow(i,count));
            }

            return results;
        }

        public static bool isArmstrong(int num) {
            return num==computeArmstrong(num);
        }
    }
}
