using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_HW
{

    internal class Program
    {
        public static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.Unicode;

            Console.WriteLine("=================================\n");
            Console.WriteLine("Bài 7.1 step by step: \n");
            Bai7_1stepMain c = new Bai7_1stepMain();
            c.Bai7_1stepbystepMain();

            Console.WriteLine("=================================\n");
            Console.WriteLine("Bài 7.2 step by step: \n");
            Bai7_2stepMain d = new Bai7_2stepMain();
            d.Bai7_2stepbystepMain();

            Console.WriteLine("=================================\n");
            Console.WriteLine("Bài 7.3 step by step: \n");
            Bai7_3stepMain e = new Bai7_3stepMain();
            e.Bai7_3stepbystepMain();

            Console.WriteLine("=================================\n");
            Console.WriteLine("Bài 7.1: \n");
            Bai7_1Main f = new Bai7_1Main();
            f.Bai7_1();

            Console.WriteLine("=================================\n");
            Console.WriteLine("Bài 7.2: \n");
            Bai7_2Main g = new Bai7_2Main();
            g.Bai7_2();

            Console.WriteLine("=================================\n");
            Console.WriteLine("Bài 7.3: \n");
            Bai7_3Main h = new Bai7_3Main();
            h.Bai7_3();





        }
    }

}