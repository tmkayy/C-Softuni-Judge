using System;

List<string> nums = Console.ReadLine().Split(' ').ToList();
int sum = 0;
foreach (var n in nums)
{
    try
    {
        int num = int.Parse(n);
        sum += num;
    }
    catch (FormatException)
    {
        Console.WriteLine($"The element '{n}' is in wrong format!");
    }
    catch (OverflowException)
    {
        Console.WriteLine($"The element '{n}' is out of range!");
    }
    Console.WriteLine($"Element '{n}' processed - current sum: {sum}");
}
Console.WriteLine($"The total sum of all integers is: {sum}");
