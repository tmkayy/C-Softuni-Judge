try
{
    double n = double.Parse(Console.ReadLine());
    if (n<0)
    {
        throw new ArgumentException();
    }
    Console.WriteLine(Math.Sqrt(n));
}
catch(ArgumentException ex)
{
    Console.WriteLine("Invalid number.");
}
finally
{
    Console.WriteLine("Goodbye.");
}