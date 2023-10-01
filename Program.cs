using carparking_csharp.Models;

decimal initialPrice = 0;
decimal priceHour = 0;

Console.Clear();
Console.WriteLine("Welcome to PArking System");

// ASK FOR THE PRICE
do Console.Write("Please enter initial parking price \n");
while (!decimal.TryParse(Console.ReadLine(), out initialPrice));
// Improved from initialPrice = Convert.ToDecimal(Console.ReadLine());
do Console.Write("Please enter price per hour \n");
while (!decimal.TryParse(Console.ReadLine(), out priceHour));
// Improved from priceHour = Convert.ToDecimal(Console.ReadLine());

Parking car = new Parking();
bool menu = true;

while(menu)
{
    Console.Clear();
    Console.WriteLine("Choose a number for the menu option:");
    Console.WriteLine("1 - Begin Parking");
    Console.WriteLine("2 - End Parking");
    Console.WriteLine("3 - List Cars");
    Console.WriteLine("4 - Exit");

    switch (Console.ReadLine())
    {
        case "1":
            car.AddCar();
            break;
        case "2":
            car.RemoveCar(initialPrice, priceHour);
            break;
        case "3":
            car.ListCar();
            break;
        case "4":
            menu = false;
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("Please choose a valid option number from 1 to 4");
            Console.ReadLine();
            break;
    }
    
}
