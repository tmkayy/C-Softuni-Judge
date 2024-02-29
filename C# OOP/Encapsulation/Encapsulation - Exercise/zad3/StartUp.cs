using System;
using System.Collections.Generic;
using System.Linq;

namespace zad3
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            try
            {
                string[] customers = Console.ReadLine().Split(';');
                List<Person> ppl = new List<Person>();
                for (int i = 0; i < customers.Length; i++)
                {
                    string[] customer = customers[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                    Person p = new Person(customer[0], double.Parse(customer[1]));
                    ppl.Add(p);
                }
                List<Product> prods = new List<Product>();
                string[] products = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < products.Length; i++)
                {
                    try
                    {
                        string[] product = products[i].Split('=', StringSplitOptions.RemoveEmptyEntries);
                        var p = new Product(product[0], double.Parse(product[1]));
                        prods.Add(p);
                    }
                    catch (ArgumentException ex) { Console.WriteLine(ex.Message); return; }
                }
                while (true)
                {
                    string[] s = Console.ReadLine().Split(' ');
                    if (s[0] == "END")
                    {
                        foreach (var item in ppl)
                        {
                            if (!item.Bag.Any())
                            {
                                Console.WriteLine($"{item.Name} - Nothing bought");
                            }
                            else
                            {
                                Console.WriteLine($"{item.Name} - {String.Join(", ", item.Bag)}");
                            }
                        }
                        return;
                    }
                    Person p = ppl[ppl.IndexOf(ppl.FirstOrDefault(x => x.Name == s[0]))];
                    if (p != null)
                        p.Add2Bag(prods.First(x => x.Name == s[1]));
                }
            }
            catch (ArgumentException ex) { Console.WriteLine(ex.Message);}
        }
    }
}
