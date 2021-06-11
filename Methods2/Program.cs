using System;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 4, 3, 2));
            Console.WriteLine(Subtract(9, 6, 5));
            Console.WriteLine(Multiply(6, 8, 12, 4));
            Console.WriteLine(Divide(20, 5, 2));
            Console.WriteLine(Remainder(9, 6));

        }

        public static int Add(params int[] numList)
        {
            int temp = numList[0];

            for (int i = 1; i < numList.Length; i++)
            {
                temp = temp + numList[i];
            }

            return temp;
        }

        public static int Subtract(params int[] numList)
        {
            int temp = numList[0];

            for (int i = 1; i < numList.Length; i++)
            {
                temp = temp - numList[i];
            }

            return temp;
        }
        public static int Multiply(params int[] numList)
        {
            int temp = numList[0];

            for (int i = 1; i < numList.Length; i++)
            {
                temp = temp * numList[i];
            }

            return temp;
        }
        public static int Divide(params int[] numList)
        {
            int temp = numList[0];

            for (int i = 1; i < numList.Length; i++)
            {
                temp = temp / numList[i];
            }

            return temp;
        }
        public static int Remainder(params int[] numList)
        {
            int temp = numList[0];

            for (int i = 1; i < numList.Length; i++)
            {
                temp = temp % numList[i];
            }

            return temp;
        }
    }
}
