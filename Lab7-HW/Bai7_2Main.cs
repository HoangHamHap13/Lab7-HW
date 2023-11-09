using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_HW
{
    public class Bai7_2Main
    {
        public void Bai7_2()
        {
            //Tạo Hashtable lưu danh sách ngày trong tuần với key từ 1-7
            Hashtable dayOfWeek = new Hashtable();
            dayOfWeek.Add(1, "Sunday");
            dayOfWeek.Add(2, "Monday");
            dayOfWeek.Add(3, "Tuesday");
            dayOfWeek.Add(4, "Wednesday");
            dayOfWeek.Add(5, "Thursday");
            dayOfWeek.Add(6, "Friday");
            dayOfWeek.Add(7, "Saturday");

            //In ra các ngày trong tuần bao gồm cả key và value.
            Console.WriteLine("Danh sách các ngày trong tuần:");
            foreach (DictionaryEntry day in dayOfWeek)
            {
                Console.WriteLine($"Key: {day.Key} - Value: {day.Value}");
            }

            CheckTuesday(dayOfWeek);

        }

        //Tìm ngày TueDay, in ra thông báo nếu tìm thấy hoặc không
        public static void CheckTuesday(Hashtable dayOfWeek)
        {
            if (dayOfWeek.ContainsValue("Tuesday"))
            {
                Console.WriteLine("Tuesday exists.");
            }
            else
            {
                Console.WriteLine("Tuesday doesn't exist.");
            }
        }

        





    }
}
