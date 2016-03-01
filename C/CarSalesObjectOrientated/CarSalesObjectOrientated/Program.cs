using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesObjectOrientated
{
    class Car
    {
        public string make;
        public string model;
        public int price;
        public bool sold;
        
        private int _mileage;
        public static int numberOfCars;

        public int Mileage
        {
            get
            {
                return _mileage;
            }
            set
            {
                if (value > 0)
                    _mileage = value;
            }

        }

        public void AddCar(string make, string model, int price, bool sold)
        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
        }     

        public void DisplayCars()
        {
            Console.WriteLine("Make: " + this.make + ", Model: " + this.model + ", Price: £" + this.price + ", Sold: " + this.sold + ".");
        }
    }
    //end of car class    

    class Program
    { 
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Current cars in stock: ");
            Car.numberOfCars = 0;

            //add cars data
            Car car1 = new Car();
            car1.AddCar("Rolls Royce", "Silver Cloud", 35000, true);
            car1.Mileage = 25000;
            Car.numberOfCars++;
            car1.DisplayCars();

            Car car2 = new Car();
            car2.AddCar("Aston Martin", "DB5", 750000, false);
            Car.numberOfCars++;
            car2.DisplayCars();

            Car car3 = new Car();
            car3.AddCar("Reliant", "Robin", 550, false);
            Car.numberOfCars++;
            car3.DisplayCars();

            //display cars data
            Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);




        }//end main
    }
}
