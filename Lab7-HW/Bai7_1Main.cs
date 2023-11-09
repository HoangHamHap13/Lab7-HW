using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_HW
{
    public  class Bai7_1Main
    {
        public void Bai7_1()
        {
            //tạo collection 10 quyển sách
            List<Book> bookCollection = new List<Book>
        {
            new Book { Id = 1, Title = "Book 1", Author = "Author 1", Publisher = "Nhi Dong", Year = 2010, Price = 15.99 },
            new Book { Id = 2, Title = "Book 2", Author = "Author 2", Publisher = "Publisher X", Year = 2011, Price = 12.50 },
            new Book { Id = 3, Title = "Book 3", Author = "Author 3", Publisher = "Nhi Dong", Year = 2012, Price = 20.00 },
            new Book { Id = 4, Title = "Book 4", Author = "Author 4", Publisher = "Publisher Y", Year = 2013, Price = 18.25 },
            new Book { Id = 5, Title = "Book 5", Author = "Author 5", Publisher = "Publisher Z", Year = 2014, Price = 22.80 },
            new Book { Id = 6, Title = "Book 6", Author = "Author 6", Publisher = "Nhi Dong", Year = 2014, Price = 19.99 },
            new Book { Id = 7, Title = "Book 7", Author = "Author 7", Publisher = "Publisher K", Year = 2015, Price = 16.00 },
            new Book { Id = 8, Title = "Book 8", Author = "Author 8", Publisher = "Nhi Dong", Year = 2016, Price = 25.50 },
            new Book { Id = 9, Title = "Book 9", Author = "Author 9", Publisher = "Publisher L", Year = 2017, Price = 14.75 },
            new Book { Id = 10, Title = "Book 10", Author = "Author 10", Publisher = "Publisher M", Year = 2018, Price = 17.90 }
        };

            //In danh sách ban đầu
            Console.WriteLine("Danh sách:");
            foreach (var book in bookCollection)
            {
                Console.WriteLine($"Id: {book.Id}\t\tTitle: {book.Title}\t\tAuthor: {book.Author}" +
                    $"\t\tPublisher: {book.Publisher}\t\tYear: {book.Year}\t\tPrice: {book.Price}\t\t");

            }


            //In danh sách các quyển sách tăng dần theo giá
            Console.WriteLine("Danh sách tăng dần theo giá:");
            List<Book> booksSortedByPrice = bookCollection.OrderBy(book => book.Price).ToList();
            foreach (var book in booksSortedByPrice)
            {
                Console.WriteLine($"Title: {book.Title}\t\tPrice: {book.Price}");

            }

            //tìm quyển sách có title trùng với giá trị nhập từ bàn phím
            Console.WriteLine("\nNhập title sách cần tìm kiếm giá:");
            string inputTitle = Console.ReadLine();
            Book foundBook = bookCollection.FirstOrDefault(book => book.Title == inputTitle);
            if ( foundBook != null)
            {
                Console.WriteLine($"Sách có title trùng: {foundBook.Title}, \t\tGiá: {foundBook.Price}");
            }
            else
            {
                Console.WriteLine("Not found");
            }

            //Đưa ra những quyển sách xuất bản năm 2014
            List<Book> booksPublishedIn2014 = bookCollection.Where(book => book.Year == 2014).ToList();
            Console.WriteLine("\nDanh sách các quyển sách xuất bản năm 2014:");
            foreach (var book in booksPublishedIn2014)
            {
                Console.WriteLine($"Title: {book.Title}, Publisher: {book.Publisher}");
            }

            //Xoá những quyển sách của nhà xuât bản "Nhi Dong"
            bookCollection = bookCollection.Where(book => book.Publisher != "Nhi Dong").ToList();
            Console.WriteLine("\nDanh sách sau khi xoá các quyển sách của nxb Nhi Đồng:");
            foreach (var book in bookCollection)
            {
                Console.WriteLine($"Title: {book.Title}, Publisher: {book.Publisher}");
            }








        }
    }
}
