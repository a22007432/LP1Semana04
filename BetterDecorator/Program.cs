using System;

namespace BetterDecorator
{
    /// <summary>
    /// This program prints a decorated string using a string a char and an int
    /// </summary>
    class Program
    {
        /// <summary>
        /// Parses "args" and uses the Decor method
        /// </summary>
        /// <param name="args">Args should contain a string followed by 
        /// a decorative char followed by an int that represents the 
        /// n times that said char will repeat itself</param>
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

        /// <summary>
        /// Implements the directions described on main
        /// </summary>
        /// <param name="s">The string that gets decorated</param>
        /// <param name="dec">The decoration char</param>
        /// <param name="n">The n times "dec" will repeat 
        /// before and after "s"</param>
        /// <returns></returns>
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
