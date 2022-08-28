using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathClass;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = BasicMath.Add(1, 1);

            BasicMath.ExecuteRefactor(1, result);

            Console.WriteLine(result);

            Console.ReadLine();

        }
    }
}
