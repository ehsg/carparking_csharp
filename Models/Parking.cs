using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace carparking_csharp.Models
{
    public class Parking
    {
        List<string> plateList = new List<string>();


        public void AddCar()
        {
            Console.Clear();
            string car;
            //Repeat the question until plate has at least one character
            do
            {
                Console.WriteLine("Please enter the car plate to add:");
                car = Console.ReadLine();
            }
            while(string.IsNullOrEmpty(car.Trim()));
            // Check is the car is already on the list
            if (!plateList.Contains(car))
            {
                plateList.Add(car);
                Console.WriteLine($"Car plate {car} added, Press enter to continue");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry can not add this car, it is already on the system, \n Press enter to continue");
                Console.ReadLine();
            }
        }

        public void RemoveCar(decimal initialPrice, decimal priceHour)
        {
            Console.Clear();
            string car;
            //Repeat the question until plate has at least one character
            do
            {
                Console.WriteLine("Please enter the car plate to remove:");
                car = Console.ReadLine();
            }
            while(string.IsNullOrEmpty(car.Trim()));
            //Try to find the plate on the current list, give price and remove from list
            if (plateList.Contains(car))
            {
                int hours = 0;
                do Console.Write("How many hours the car stayed? \n");
                while (!int.TryParse(Console.ReadLine(), out hours));
                Console.WriteLine($"Total price is USD {initialPrice + (priceHour * hours)}");
                plateList.Remove(car);
                Console.WriteLine($"Car plate {car} removed, Press enter to continue");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry. Could not find the plate, try again. \n Press enter to continue");
                Console.ReadLine();
            }

        }

        public void ListCar()
        {
            Console.Clear();
            //List the car plates registered on memory
            foreach(string car in plateList)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("List Complete, Press enter to continue");
            Console.ReadLine();
        }


    }
}