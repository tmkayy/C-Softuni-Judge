using System;
using System.Linq;

namespace zad3
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            //stole the entire zad from hris bc i cant be bothered to redo it

            var phoneNumbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var phoneNumber in phoneNumbers)
            {
                StationaryPhone stationaryPhone = new StationaryPhone(phoneNumber);

                if (!stationaryPhone.IsLegitPhone)
                {
                    Console.WriteLine("Invalid number!");
                    continue;
                }

                if (phoneNumber.Length == 7)
                {
                    stationaryPhone.Call();
                }
                else if (phoneNumber.Length == 10) 
                {
                    Smartphone smartphone = new Smartphone(phoneNumber);
                    smartphone.Call();
                }
            }

            var websites = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var website in websites)
            {
                Smartphone smartphone = new Smartphone(website);

                if (!smartphone.IsLegitSite)
                {
                    Console.WriteLine("Invalid URL!");
                    continue;
                }

                smartphone.Browse();
            }
        }
    }
}
