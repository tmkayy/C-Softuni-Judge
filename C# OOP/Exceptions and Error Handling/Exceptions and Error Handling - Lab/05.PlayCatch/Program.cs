List<int> arrayOfIntegers = Console.ReadLine().Split(' ').Select(int.Parse).ToList(); //lol
int br = 0;
while (true)
{
    string[] s = Console.ReadLine().Split(' ');
	try
	{
		switch (s[0])
		{
			case "Replace":
				Replace(arrayOfIntegers, int.Parse(s[1]), int.Parse(s[2]));
				break;
			case "Print":
				Print(arrayOfIntegers, int.Parse(s[1]), int.Parse(s[2]));
                break;
			case "Show":
				Show(arrayOfIntegers, int.Parse(s[1]));
				break;
		}
	}
	catch (FormatException)
	{
		br++;
        Console.WriteLine("The variable is not in the correct format!");
    }
	catch (ArgumentException)
	{
        br++;
        Console.WriteLine("The index does not exist!");
    }
	if (br == 3)
	{
        Console.WriteLine(String.Join(", ", arrayOfIntegers));
		return;
    }
}

static void Replace(List<int> list, int index, int element) => list[index] = element;

static void Print(List<int> list, int start, int end)
{
	var temp = new List<int>();
	for (int i = start; i <= end; i++)
	{
		temp.Add(list[i]);
	}
    Console.WriteLine(String.Join(", ", temp));
}

static void Show(List<int> list, int index) => Console.WriteLine(list[index]);