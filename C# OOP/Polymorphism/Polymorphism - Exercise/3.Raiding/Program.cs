
namespace Raiding;
public class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<BaseHero> RAID = new List<BaseHero>();
        for (int i = 0; i < n; i++)
        {
            string s = Console.ReadLine();
            switch (Console.ReadLine())
            {
                case "Druid":
                    var d = new Druid(s);
                    RAID.Add(d);
                    break;
                case "Paladin":
                    var p = new Paladin(s);
                    RAID.Add(p);
                    break;
                case "Rogue":
                    var r = new Rogue(s);
                    RAID.Add(r);
                    break;
                case "Warrior":
                    var w = new Warrior(s);
                    RAID.Add(w);
                    break;
                default:
                    Console.WriteLine("Invalid hero!");
                    i--;
                    break;
            }
        }
        int bosshp = int.Parse(Console.ReadLine());
        RAID.ForEach(x => Console.WriteLine(x.CastAbility()));
        Console.WriteLine((bosshp<=RAID.Sum(x=>x.Power))? "Victory!": "Defeat...");
    }
}