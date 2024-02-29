using WildFarm.Models.Animals;
using WildFarm.Models.Foods;

namespace WildFarm;
public class StartUp
{
    static void Main(string[] args)
    {
        List<Animal> animals = new List<Animal>();

        while (true)
        {
            string[] s = Console.ReadLine().Split();
            if (s[0] == "End")
            {
                break;
            }

            Animal a = AnimalFactory.MAKEBIRTHED(s);
            Console.WriteLine(a.Sound());
            animals.Add(a);

            Food f = FoodFactory.FOFFOD(Console.ReadLine().Split());

            try
            {
                a.Eat(f);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        animals.ForEach(Console.WriteLine);
    }
}
