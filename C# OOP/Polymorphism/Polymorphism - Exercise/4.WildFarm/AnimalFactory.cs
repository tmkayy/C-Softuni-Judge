using WildFarm.Models.Animals;
using WildFarm.Models.Animals.Birds;
using WildFarm.Models.Animals.Mammals;
using WildFarm.Models.Animals.Mammals.Feline;

namespace WildFarm
{
    public static class AnimalFactory
    {
        // this code has been provided by https://github.com/Hristiyan-Bengyuzov
        // hris is very cool and tall
        public static Animal MAKEBIRTHED(string[] s)
        {
            return s[0] switch
            {
                "Cat" => new Cat(s[1], double.Parse(s[2]), s[3], s[4]),
                "Tiger" => new Tiger(s[1], double.Parse(s[2]), s[3], s[4]),
                "Dog" => new Dog(s[1], double.Parse(s[2]), s[3]),
                "Mouse" => new Mouse(s[1], double.Parse(s[2]), s[3]),
                "Hen" => new Hen(s[1], double.Parse(s[2]), double.Parse(s[3])),
                "Owl" => new Owl(s[1], double.Parse(s[2]), double.Parse(s[3])),
                _ => throw new ArgumentException(">Fuck you\n ):<=========>")
            };
        }
    }
}