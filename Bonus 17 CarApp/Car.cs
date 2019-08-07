namespace Bonus_17_CarApp
{
    public class Car
    {
        public int year;
        public string make;
        public string model;
        public double price;

        public int Year {get; set;}
        public string Make {get; set;}
        public string Model {get; set;}
        public double Price {get; set;}

        public Car()
        {
            ;
        }
        public Car(int year, string make, string model, double price)
        {
            this.year = year;
            this.make = make;
            this.model = model;
            this.price = price;
        }

        public override string ToString()
        {
            return "Year:" + year + "Make:" + make + "Model:" + model + "Price" + price;
        }
    } 
}
