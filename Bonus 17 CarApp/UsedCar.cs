namespace Bonus_17_CarApp
{
    public class UsedCar : Car
    {

        public double mileage;

        public double Mileage
        {
            get
            {
                return mileage;
            }
        }

        public UsedCar(int year, string make, string model, double price, double mileage) : base (year, make, model, price)
        {
            this.mileage = Mileage; 
        }

        public override string ToString()
        {
            return "Year:" + year + "Make:" + make + "Model:" + model + "Price:" + price + "Mileage" + mileage;
        }










    }
}
