using System;

namespace FibonaciNo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter integer number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Is number Fibonaci ? "+FibonaciCheck(number));
        }

        static bool FibonaciCheck(int no)
        {
            int i = 0;
            int k = 1;
            int fb;
            for(fb =0; fb<=no;)
            {
                fb = i + k;
                i = k;
                k = fb;
                if (fb == no)
                {
                    return true;
                }
            }            
            return false;

        }
    }
}
