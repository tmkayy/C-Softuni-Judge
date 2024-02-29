using System;

namespace ClassBoxData
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var l = double.Parse(Console.ReadLine());
                var w = double.Parse(Console.ReadLine());
                var h = double.Parse(Console.ReadLine());
                var b = new Box(l, w, h);
                Console.WriteLine("Surface Area - " + b.SurfaceArea());
                Console.WriteLine("Lateral Surface Area - " + b.LateralSurfaceArea());
                Console.WriteLine("Volume - " + b.Volume());
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); };
        }
    }
}
