using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classwork
{
    class Point
    {
        int x;
        int y;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            unsafe
            {
                int a = 10;
                int* ptr = &a;
                Console.WriteLine((long)a);
            }
        }

    }
}
