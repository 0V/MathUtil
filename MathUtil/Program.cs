using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mersenne Twister");

            var mt = new Random.MT19937(10);
            for (int i = 0; i < 100; i++) 
                Console.WriteLine(mt.GetInt32());

            Console.Write("Wallis's Formula :");
            Console.WriteLine(Formula.WallisFormula.Conpute(10000));
            Console.WriteLine("Enter   >> Exit");
            Console.ReadLine();
        }
    }
}
