using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            ReceiptNumbers RN = new ReceiptNumbers();
            RN.getLine();
            Console.ReadKey();
        }
    }

    class ReceiptNumbers
    {
        string numLine;
        int[] nums;
        int resultSum = 0; int resultMul = 1;
        public void getLine()
        {
            Console.WriteLine("Enter the numbers, separate by space button");
            numLine = Console.ReadLine();
            arrayMaker();
        }
        void arrayMaker()
        {
            nums = numLine.Split(' ').Select(str => int.Parse(str)).ToArray();
            getResult();
        }
        void getResult()
        {
            Processing processing = new Processing();
            resultSum = processing.Sum(ref nums);
            Console.WriteLine("Total Sum: " + resultSum);
            resultMul = processing.Mul(ref nums);
            Console.WriteLine("Total Multiplication: " + resultMul);
        }
    }
    class Processing
    {
        public int Sum(ref int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                result += nums[i];
            }
            return result;
        }
        public int Mul(ref int[] nums)
        {
            int result = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                result *= nums[i];
            }
            return result;
        }
    }
}
