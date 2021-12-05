using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_11;

namespace Задание_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Yravnenie yravnenie = new Yravnenie(1, 2);
            yravnenie.Root();
            Console.ReadKey();
        }
    }
}
