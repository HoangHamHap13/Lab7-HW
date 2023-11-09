using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_HW
{
    public class Car
    {
        //Tạo lớp Car lưu trữ thông tin (name, color)
        public string Name { get; set; } 
        public Colour colour { get; set; } //kiểu thông tin Colour

        public Car(string name, Colour colour)
        {
            Name = name;
            this.colour = colour;
        }
        

    }

    public enum Colour
    {
        Red, Green, Blue, Yellow, White, Black
    }


}
