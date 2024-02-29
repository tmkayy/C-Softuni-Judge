namespace Vehicles;
public class StartUp
{
    static void Main(string[] args)
    {
        string[] s1 = Console.ReadLine().Split(' ');
        var c = new Car(double.Parse(s1[1]), double.Parse(s1[2]), double.Parse(s1[3]));
        string[] s2 = Console.ReadLine().Split(' ');
        var t = new Truck(double.Parse(s2[1]), double.Parse(s2[2]), double.Parse(s2[3]));
        string[] s3 = Console.ReadLine().Split(' ');
        var b = new Bus(double.Parse(s3[1]), double.Parse(s3[2]), double.Parse(s3[3]));

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] s4 = Console.ReadLine().Split(' ');
            if (s4[1] == "Car")
            {
                if (s4[0] == "Drive")
                    c.Drive(double.Parse(s4[2]));
                else
                    c.Refuel(double.Parse(s4[2]));
            }
            else if (s4[1] == "Truck")
            {
                if (s4[0] == "Drive")
                    t.Drive(double.Parse(s4[2]));
                else
                    t.Refuel(double.Parse(s4[2]));
            }
            else
            {
                if (s4[0] == "DriveEmpty")
                    b.Drive(double.Parse(s4[2]));
                else if (s4[0] == "Drive")
                    b.DriveFull(double.Parse(s4[2]));
                else
                    b.Refuel(double.Parse(s4[2]));
            }
        }
        Console.WriteLine(c);
        Console.WriteLine(t);
        Console.WriteLine(b);
    }
}