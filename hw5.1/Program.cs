using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw5._1
{
    internal class Program
    {
        private static int Nod(int x, int y)
        {
            if (x >  y)
            {
                if (y == 0) return x;
                else
                {
                    return Nod(y, x % y);
                }
            }
            else if (x < y)
            {
                if (x == 0) return y;
                else
                {
                    return Nod(x, y % x);
                }
                
            }
            else { return Nod(x, y); }
        }
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Nod(x, y));
        }
    }
}
