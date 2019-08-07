using System;
using System.Collections.Generic;

namespace Bonus_17_CarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand C Car Dealership app");
            Console.WriteLine();

            List<Car> Carlot = new List<Car>();
            Car car1 = new Car(2005, "chevy", "Malibu", 12000);
            Car car2 = new Car(2003, "Honda", "CRV", 12300);
            Car car3 = new UsedCar(2000, "Ford", "Focus", 500, 12000);
            Carlot.Add(car1);
            Carlot.Add(car2);
            Carlot.Add(car3);


            foreach (Car e in Carlot)
            {
                Console.WriteLine(e.ToString());
            }



            CarApp carApp = new CarApp();
            Console.WriteLine();





            Console.ReadLine();
        }


    }
}
