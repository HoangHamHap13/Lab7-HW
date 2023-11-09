using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_HW
{
    internal class Product
    {
       
        //Tạo lớp Product với các trường name, cost, onhand

        string name;
        double cost;
        int onhand;

        //constructor
        public Product(string n, double c, int h)
        {
            name = n;
            cost = c;
            onhand = h;
        }

        //Ghi đè phương thức ToString của lớp Product 
        //để trả về chuỗi thông tin của Product
        public override string ToString()
        {
            return String.Format("{0,-10}Cost: {1,6:C}  On hand: {2}", name, cost, onhand); 
        }


        //Viết code thêm 5 sản phẩm vào ArrayList và hiển thị 
        //ra màn hình.



    }
}
