namespace Vehicles;
public class StartUp
{
    static void Main(string[] args)
    {
        string[] s1 = Console.ReadLine().Split(' ');
        var c = new Car(double.Parse(s1[1]), double.Parse(s1[2]));
        string[] s2 = Console.ReadLine().Split(' ');
        var t = new Truck(double.Parse(s2[1]), double.Parse(s2[2]));
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] s3 = Console.ReadLine().Split(' ');
            if (s3[1] == "Car")
            {
                if (s3[0] == "Drive")
                    c.Drive(double.Parse(s3[2]));
                else
                    c.Refuel(double.Parse(s3[2]));
            }
            else
            {
                if (s3[0] == "Drive")
                    t.Drive(double.Parse(s3[2]));
                else
                    t.Refuel(double.Parse(s3[2]));
            }
        }
        Console.WriteLine(c);
        Console.WriteLine(t);
    }
}