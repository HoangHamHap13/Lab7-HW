using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_HW
{
    public class Bai7_2stepMain
    {


        public void Bai7_2stepbystepMain()
        {
            //Viết chương trình minh hoạ sử dụng SortedList Generic
            //tạo lớp SortedList
            SortedList<string, string> listEm = new SortedList<string, string>();
            //đưa dư liệu vào
            listEm.Add("E01", "Nguyễn Văn A");
            listEm.Add("E02", "Trần Thị B");
            listEm.Add("E03", "Đỗ Trọng C");
            listEm.Add("E04", "Phạm Gia D");
            listEm.Add("E05", "Ngô Minh E");
            //in danh sách
            Console.WriteLine("Danh sách nhân viên:");
            foreach (var key in listEm.Keys)
            {
                Console.WriteLine(key + ":" + listEm[key]);
            }

            //tìm kiếm tất cả các nhân viên có tên bắt đầu bằng T
            Console.WriteLine("Danh sách nhân viên tên bắt đầu bằng T:");
            foreach (var key in listEm.Keys)
            {
                if (listEm[key].StartsWith("T"))
                {
                    Console.WriteLine(key + ":" + listEm[key]);
                }
            }

            //xoá nhân viên mã E04
            listEm.Remove("E04");

            //kiểm tra nếu chưa có E06 thì thêm vào
            if (!listEm.ContainsKey("E06"))
            {
                listEm.Add("E06", "Hà Tiểu F");
            }

            //in ra danh sách sau khi chỉnh sửa
            Console.WriteLine("Danh sách nhân viên FINAL:");
            foreach (var key in listEm.Keys)
            {
                Console.WriteLine(key + ":" + listEm[key]);
            }





        }
    }
}
