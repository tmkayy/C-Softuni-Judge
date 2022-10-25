using System;

namespace zad9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double days = double.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string rate = Console.ReadLine();
            double price = 0;
            days = days - 1;
            switch (room)
            {
                case "room for one person":
                    price = 18 * days;
                    switch (rate)
                    {
                        case "positive":
                            price = price * 1.25;
                            break;
                        case "negative":
                            price = price * 0.9;
                            break;
                    }
                    break;
                case "apartment":
                    price = days * 25;
                    if (days<10)
                    {
                        price = price * 0.7;
                        switch (rate)
                        {
                            case "positive":
                                price = price * 1.25;
                                break;
                            case "negative":
                                price = price * 0.9;
                                break;
                        }
                    }
                    else if (days>=10&&days<=15)
                    {
                        price = price * 0.65;
                        switch (rate)
                        {
                            case "positive":
                                price = price * 1.25;
                                break;
                            case "negative":
                                price = price * 0.9;
                                break;
                        }
                    }
                    else
                    {
                        price = price * 0.5;
                        switch (rate)
                        {
                            case "positive":
                                price = price * 1.25;
                                break;
                            case "negative":
                                price = price * 0.9;
                                break;
                        }
                    }
                    break;
                case "president apartment":
                    price = days * 35;
                    if (days < 10)
                    {
                        price = price * 0.9;
                        switch (rate)
                        {
                            case "positive":
                                price = price * 1.25;
                                break;
                            case "negative":
                                price = price * 0.9;
                                break;
                        }
                    }
                    else if (days >= 10 && days <= 15)
                    {
                        price = price * 0.85;
                        switch (rate)
                        {
                            case "positive":
                                price = price * 1.25;
                                break;
                            case "negative":
                                price = price * 0.9;
                                break;
                        }
                    }
                    else
                    {
                        price = price * 0.8;
                        switch (rate)
                        {
                            case "positive":
                                price = price * 1.25;
                                break;
                            case "negative":
                                price = price * 0.9;
                                break;
                        }
                    }
                    break;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
