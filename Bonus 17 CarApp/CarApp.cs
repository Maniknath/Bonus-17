using System;
using System.Collections.Generic;

namespace Bonus_17_CarApp
{
    public class CarApp
    {
        List<Car> Inventory = new List<Car>();
        //List<UsedCar> UsedCars = new List<UsedCar>();

        public int Input;
        public int GetInput(int input)
        {
            Input = input;
            return input;
        }

        public void GetCars()
        {
            Car c = new Car();
            for (int i = 0; i < Input; i++)
            {
                Console.WriteLine("Car : " + (i + 1));
                c = new Car();
                Console.WriteLine("How many cars do you want?");
                Console.WriteLine("Make of the car:");
                c.Make = Console.ReadLine();
                Console.WriteLine("Model of the car:");
                c.Model = Console.ReadLine();
                Console.WriteLine("Year of the Car:");
                c.Year = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Price of the car:");
                c.Price = Convert.ToInt32(Console.ReadLine());

                Inventory.Add(c);


                Console.WriteLine("Current Inventory:");
                foreach (var car in Inventory)
                {
                    Console.WriteLine($" {car.Make} {car.Model} Year {car.Year} Price {car.Price}");

                }
            }

            //UsedCar uc = new UsedCar();
            //for (int i = 0; i <Input; i++)
            //{
            //    Console.WriteLine("Used Car: " + (i+1));
            //    uc = new UsedCar();
            //    Console.WriteLine("How many Used cars do you want?");


            //}



        }


    }
}
