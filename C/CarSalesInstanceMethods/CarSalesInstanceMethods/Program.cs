using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesInstanceMethods
{
    class Program
    {

        class Vehicle
        {
            public string type;
            public string make;
            public string model;
            public int price;
            public Boolean sold;

            public static int numberOfCars;

            public void AddVehicle(string type, string make, string model, int price)
            {
                this.type = type;
                this.make = make;
                this.model = model;
                this.price = price;
                this.sold = false;
            }

            //display the car for an indivdual car
            public void ListVehicle()
            {
                Console.WriteLine("The details of this vehicle are: ");
                Console.Write("Make and model: {0} {1}, price: £{2:N0}.", make, model, price);
                if (sold)
                {
                    Console.WriteLine("This vehicle has been sold.");
                }
                else
                {
                    Console.WriteLine("This vehicle is still available");
                }
                Console.WriteLine();
            }

            //record the sales of a car
            public void Sold(bool isSold, int price)
            {
                this.sold = isSold;
                this.price = price;
                //adjust stock levels
                Car.numberOfCars--;
            }

            //list all the cars
            public static void ListAllVehicles(List<Vehicle> allVehicles)
            {
                int totalValueSold = 0;
                int totalValueInStock = 0;


                foreach (Vehicle item in allVehicles)
                {
                    Console.WriteLine("The details of this {0] are: ", item.type);
                    Console.Write("Make and model: {0} {1}, price: {2:N0}.", item.make, item.model, item.price);
                    if (item.sold)
                    {
                        Console.WriteLine("This {0} has been sold.,", item.type);
                        totalValueSold += item.price;
                    }
                    else
                    {
                        Console.WriteLine("This {0} is unsold.", item.type);
                        totalValueInStock += item.price;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("The total value of vehicles sold is: £{0:N0}.", totalValueSold);
                Console.WriteLine("The total value of vehicles in stock is: £{0:N0}.", totalValueSold);

                Console.WriteLine();
            }
        }

        class Car : Vehicle
        {
            public static int numberOfCars;

            public void AddCar(string make, string model, int price)
            {
                AddVehicle(type = "car", make, model, price);
                numberOfCars++;
            }

            public void SoldCar(bool isSold, int price)
            {
                Sold(isSold, price);
                numberOfCars--;
            }
        }

        class MotorCycle : Vehicle
        {
            public static int numberOfBikes;

            public void AddBike(string make, string model, int price)
            {
                AddVehicle(type = "motorbike", make, model, price);
                numberOfBikes++;
            }

            public void SoldBike(bool isSold, int price)
            {
                Sold(isSold, price);
                numberOfBikes--;
            }
        }

        static void Main(string[] args)
        {
            Car.numberOfCars = 0;
            MotorCycle.numberOfBikes = 0;

            List<Vehicle> allVehicles = new List<Vehicle>();

            //add vehicles
            Car car1 = new Car();
            car1.AddCar("Rolls Royce", "Silver Cloud", 35000);
            allVehicles.Add(car1);

            Car car2 = new Car();
            car2.AddCar("Aston Martin", "DB5", 750000);
            allVehicles.Add(car2);

            Car car3 = new Car();
            car3.AddCar("Reliant", "Robin", 550);
            allVehicles.Add(car3);

            MotorCycle bike1 = new MotorCycle();
            bike1.AddBike("Triumph", "Tiger 800", 10000);
            allVehicles.Add(bike1);

            MotorCycle bike2 = new MotorCycle();
            bike1.AddBike("Vespa", "Spirit 150", 2500);
            allVehicles.Add(bike2);


            //display cars data
            Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);
            Console.WriteLine("Total number of motorbikes in stock is: {0}", MotorCycle.numberOfBikes);
            Console.WriteLine();

            Vehicle.ListAllVehicles(allVehicles);

            //record the sale of a car and a bike
            car3.SoldCar(true, 350);
            bike2.SoldBike(true, 2000);

            //display cars data
            Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);
            Console.WriteLine("Total number of motorbikes in stock is: {0}", MotorCycle.numberOfBikes);
            Console.WriteLine();
            }
        }
    }