using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_c__nashtech
{

    class Program
    {
        static void Main(string[] args)
        {
            callMethod();
            Console.ReadKey();
        }

        public static async void callMethod()
        {
            Task<bool> task = Method1();
            bool IsPrime = await task;
            Method2(IsPrime);
        }
        public static async Task<bool> Method1()
        {
            bool IsPrime = true;
            await Task.Run(() =>
        {
            Console.WriteLine("Prime Number :");
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j < 100; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        IsPrime = false;
                        break;
                    }
                }
                if (IsPrime)
                {
                    Console.Write("\t" + i);
                }
                IsPrime = true;
            }
            Console.ReadKey();

        });
            return IsPrime;


        }

        public static void Method2(bool IsPrime)
        {
            Console.WriteLine("The prime number are" + IsPrime);
        }
    }




}









