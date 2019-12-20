using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLot
{
    class Program
    {
        static void Main(string[] args)
        {   //                                      First Car lot with 3 cars
            CarLot Coopins = new CarLot("Coop's Awesome Cars!");

            Coopins.AddCar(new Truck("GO FAST", "Bugatti", "C550", "999.99", "Sonic The Hedgehog fast!"));

            Coopins.AddCar(new Car("SOLVE MYSTERIES", "Volvo", "The Mystery Machine", "55k", "Van", "5"));

            Coopins.AddCar(new Car("SPEED RACER", "Mach 5", "The Winner", "43945.27", "Sportscar", "2"));

            Coopins.PrintLot();

            //                                      Second Car lot with 4 cars
           CarLot Rubin = new CarLot("Rubin's Odd Cars!");

            Rubin.AddCar(new Truck("PLANET EXPRESS SHIP", "", "Space Jam", "1999.99", "8"));

            Rubin.AddCar(new Car("THE BATMOBILE", "The Batman (Wayne Enterprises", "Classified", "Classified", "Type: Classified", "2"));

            Rubin.AddCar(new Car("UFO", "???", "???", "???", "???", "???"));

            Rubin.AddCar(new Car("EXPERIMRNTAL MILITARY AIRCRAFT", "Classified", "Classified", "Classified", "Indigo Drive", "Classified"));

            Rubin.PrintLot();

            Console.WriteLine();
            Console.ReadKey();
        }
    }

    public class CarLot
    {
        public string Name { get; set; }
        public List<Vehicle> Autos { get; set; }

        public CarLot(string name)
        {
            Name = name;
            Autos = new List<Vehicle>();
        }

        public void AddCar(Vehicle vehicle)
        { // adds car to carlot list
            Autos.Add(vehicle);
        }

        public void PrintLot()
        { // prints the lot name number of cars and details from truck or car class
            Console.WriteLine(Name);
            Console.WriteLine(Autos.Count + " Vehicles on the Lot!");
            foreach (Vehicle auto in Autos)
            {
                auto.PrintDetails();
            }
        }
    }

    public abstract class Vehicle
    {
        public string License { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Price { get; set; }

        public Vehicle(string license, string make, string model, string price)
        {
            License = license;
            Make = make;
            Model = model;
            Price = price;
        }

        public abstract void PrintDetails(); // method with no body, because it can't be instantiated
    }

    class Truck : Vehicle
    {
        public string BedSize { get; set; }

        public Truck(string license, string make, string model, string price, string bedSize) :
            base(license, make, model, price)
        {
            BedSize = bedSize;
        }

        public override void PrintDetails()
        { // overide abtract method specific to truck, prints relevant fields
            Console.WriteLine();
            Console.WriteLine("{0} {1}, Truck with {2} bed; Plate #: {3};" +
                " ${4}", Make, Model, BedSize, License, Price);
            Console.WriteLine();
        }
    }

    class Car : Vehicle
    {
        public string Type { get; set; }
        public string Doors { get; set; }

        public Car(string license, string make, string model, string price, string type, string doors) :
                base(license, make, model, price)
        {
            Type = type;
            Doors = doors;
        }

        public override void PrintDetails()
        { // overide abtract method specific to car, prints relevant fields
            Console.WriteLine();
            Console.WriteLine("{0} {1}, {2} with {3} doors; Plate #: {4};" +
                " ${5}", Make, Model, Type, Doors, License, Price);
            Console.WriteLine();
        }
    }
}