using System;

namespace Special
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(args[0]);
            Console.WriteLine(GetSpecial(n));
        }

        private static int GetSpecial(int n)
        {
            int ret = 0;
            int[] result = new int[n];

            if (n == 0){ret = 0;}
            else if(n == 1){ret = 1;}
            else
            {
                ret = GetSpecial(n -1) + (GetSpecial(n - 2)* 2);
            }

            return ret;
        }
    }
}
