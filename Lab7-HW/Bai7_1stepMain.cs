using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_HW
{
    internal class Bai7_1stepMain
    {
        public void Bai7_1stepbystepMain()
        {
            //Bài 7.1 - stepbystep
            //Viết chương trình minh hoạ việc sử dụng ArrayList


            //tạo ArrayList 
            ArrayList product = new ArrayList();
            //thêm các phần tử vào danh sách
            product.Add(new Product("A", 5.9, 3));
            product.Add(new Product("B", 8.2, 2));
            product.Add(new Product("C", 3.5, 4));
            product.Add(new Product("D", 1.8, 8));

            //In ra danh sách các phần tử
            Console.WriteLine("Product List");
            foreach (Product i in product)
            {
                Console.WriteLine("\t" + i);
            }
        }
    }
}
