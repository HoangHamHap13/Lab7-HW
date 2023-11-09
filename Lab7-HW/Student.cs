using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_HW
{

    //lớp Student thực thi từ giao diện IComparable để thực hiện so sánh điểm trung bình 
    // 2 sv với nhau
    public class Student:IComparable<Student>
    {
        //khai báo các thuộc tính tự động
        public string Id {  get; set; }
        public string FirstName { get; set; } 
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public double Avg {  get; set; }

        //ghi đè phương thức ToString
        public override string ToString()
        {
            return "\nId:" + Id + "\nFull Name:" + FirstName + " " + LastName + 
                "\nGender:" + (Gender?"Male":"Female") + "\nAverage mark:" + Avg;
        }


        //thực thi phương thức CompareTo và so sánh điểm để sắp xếp tăng dần
        public int CompareTo(Student other)
        {
            return this.Avg.CompareTo(other.Avg);
        }



    }
}
