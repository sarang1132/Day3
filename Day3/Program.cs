using System;

namespace day3task1
{

    class SwapNum
    {
        public void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;

        }



    }
    class Program
    {
        static void Main(string[] args)
        {


            SwapNum obj = new SwapNum();
            int a = 100;
            int b = 200;
            Console.WriteLine("before swapping");
            Console.WriteLine("Num1 is {0}", a);
            Console.WriteLine("Num2 is {0}", b);
            Console.WriteLine("after swapping");
            obj.Swap(ref a, ref b);
            Console.WriteLine("Num1 is {0}", a);
            Console.WriteLine("Num2 is {0}", b);




        }
    }
}
