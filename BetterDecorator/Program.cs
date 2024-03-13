using System;

namespace BetterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string phrase = args[0];
            char mdec = '0';
            int mn = 1;

            for(int i = 0; i < 3; i++)
            {
                if(i == 1)
                {
                    mdec = char.Parse(args[i]);
                }
                if(i == 2)
                {
                    mn = int.Parse(args[i]);
                }
            }

         
            Console.WriteLine(Decor(phrase, mdec ,mn));
        }

        private static string Decor(string s , char dec, int n)
        {
            string ret = "";
            char[] decarray = new char[n]; 

            for(int j = 0; j<n; j++)
            {
                decarray[j] = dec;
                ret += decarray[j];
            }

            ret += $" {s} ";

            for(int l = 0; l<n; l++)
            {
                ret += decarray[l];
            }

            return ret;
        }
    }
}
