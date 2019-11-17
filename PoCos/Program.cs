using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoCos
{
    class Program
    {
        static void Main(string[] args)
        {

            Driver Dave = new Driver
            {
                FirstName = "Dave",
                LastName = "Thomas",
                LicenseNumber = 123456,
                Gender = "Male"
            };

            Driver Wendy = new Driver();
            Dave.FirstName = "Wendy";
            Dave.LastName = "Thomas";
            Dave.LicenseNumber = 654321;
            Dave.Gender = "Female";

            Console.WriteLine("{0} license number {1}, {2}.",
                Dave.Gender, Dave.LicenseNumber, Dave.FullName());

            Console.WriteLine();

            Console.WriteLine("{0} license number {1}, {2}.",
                Wendy.Gender, Wendy.LicenseNumber, Wendy.FullName());

            Console.WriteLine();

            Book saga = new Book();
            saga.Title = "'The Get Back Alivers'";
            saga.Authors = new string[] { "Chris Cooper", "The Anomaly" };
            saga.Pages = 99;
            saga.SKU = "CC351TA9";
            saga.Publisher = "Brave Quest";
            saga.Price = 19.99m;

            Console.WriteLine("From {0}: {1} by {2}: {3} Pages: " +
               "Price ${4}: SKU {5}", saga.Publisher, saga.Title,
               saga.Authors[1], saga.Pages, saga.Price, saga.SKU
               );
            Console.WriteLine();

            Plane seaPlane = new Plane("Blue");
            seaPlane.Manufacturer = "Brave Quest Aerodynamics";
            seaPlane.Model = "T100 Series";
            seaPlane.Variant = "Bermuda Triangle";
            seaPlane.Capacity = 4;
            seaPlane.Engines = "Duel";

            Console.WriteLine(" A {0}, {1} engine powered, {2} {3} {4} " +
                "with room for {5}", seaPlane.Color, seaPlane.Engines, seaPlane.Manufacturer, 
            seaPlane.Model, seaPlane.Variant, seaPlane.Capacity );
            
            Console.WriteLine();

            Console.ReadKey();
        }
    }

    public class Driver
    {
        public String FirstName;
        public string LastName;
        public int LicenseNumber;
        public string Gender;

        public string FullName()
        {
            string space = " ";
            string FullName = String.Concat(FirstName, space, LastName);
            return FullName;


        }
    }

    public class Book
    {
        public string Title;
        public string[] Authors;
        public int Pages;
        public string SKU;
        public string Publisher;
        public Decimal Price;

    }

    public class Plane
    {
        public String Manufacturer;
        public String Model;
        public String Variant;
        public int Capacity;
        public String Engines;

        public string Color { get; set; }

        public Plane(string initialColor)
        {
            Color = initialColor;
        }
    }
}