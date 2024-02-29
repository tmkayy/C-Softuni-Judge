Zad2();

static void Zad2()
{
    List<int> list = new List<int>();
    int br = 1;
    for (int i = 0; i < 10; i++)
    {
        try
        {
            int n = int.Parse(Console.ReadLine());
            if (n <= br || n >= 100)
            {
                Console.WriteLine($"Your number is not in range {br} - 100!");
                i--;
            }
            else
            {
                list.Add(n);
                br = n;
            }
        }
        catch
        {
            i--;
            Console.WriteLine("Invalid Number!");
        }
    }
    Console.WriteLine(String.Join(", ", list));
}