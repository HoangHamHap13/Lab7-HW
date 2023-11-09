using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_HW
{
    public class Bai7_3stepMain
    {
        //Viết chương trình C# minh họa việc sử dụng lớp List Generic
        //để lưu trữ 1 danh sách sinh viên, tìm sinh viên có điểm trung bình cao nhất,
        //sắp xếp danh sách sinh viên tăng dần theo điểm trung bình
        public void Bai7_3stepbystepMain()
        {

            List<Student> list = new List<Student>()
        {
            new Student{Id ="S11", FirstName = "A", LastName = "BB", Avg = 9.5},
            new Student{Id ="S12", FirstName = "C", LastName = "DD", Avg = 9.0},
            new Student{Id ="S13", FirstName = "E", LastName = "FF", Avg = 8.0},
            new Student{Id ="S14", FirstName = "G", LastName = "HH", Avg = 6.5},
            new Student{Id ="S15", FirstName = "I", LastName = "JJ", Avg = 9.7},
            new Student{Id ="S16", FirstName = "K", LastName = "LL", Avg = 4.8},
            new Student{Id ="S17", FirstName = "M", LastName = "NN", Avg = 5.2},
        };

            //in danh sách sinh viên

            foreach (Student student in list) 
            {
                Console.WriteLine(student);
            } // = foreach (var st in list){Console.Write(st);}

            //tìm sv có điểm trung bình cao nhất
            double max = list[0].Avg;
            Student studentmax = list[0];
            foreach (var student in list) 
            { 
                if (student.Avg > max)
                {
                    max = student.Avg;
                    studentmax = student;
                }
            }

            //in kết quả
            Console.WriteLine("\nSinh viên có điểm cao nhất là:");
            Console.WriteLine(studentmax);
            
            //sắp xếp danh sách sinh viên tăng dần theo điểm trung bình
            list.Sort();
            Console.WriteLine("Danh sách sinh viên điểm trung bình tăng dần:");
            foreach (Student student in list)
            {
                Console.WriteLine(student);
            }








        }

    }




}
