using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_HW
{
    public class Bai7_3Main
    {
        public void Bai7_3()
        {
            var cars = new List<Car>()
            {
                new Car("Car 1", Colour.Red),
                new Car("Car 2", Colour.Black),
                new Car("Car 3", Colour.Blue),
                new Car("Car 4", Colour.White),
                new Car("Car 5", Colour.Green),
                new Car("Car 6", Colour.Yellow),
                new Car("Car 7", Colour.Red),
                new Car("Car 8", Colour.Blue),
                new Car("Car 9", Colour.Green),
                new Car("Car 10", Colour.Yellow),

                
            };

            RemoveRedCars(cars);

            //In danh sách sau khi xoá
            Console.WriteLine("Danh sách sau xoá:");
            foreach (var car in cars)
            {
                Console.WriteLine($"Car: {car.Name}\t\tColour: {car.colour}");
            }



        }
       
        
        //Xoá Red car
        public static void RemoveRedCars(List<Car> cars)
        {
            cars.RemoveAll(cars => cars.colour == Colour.Red);  
        }

    }
}
