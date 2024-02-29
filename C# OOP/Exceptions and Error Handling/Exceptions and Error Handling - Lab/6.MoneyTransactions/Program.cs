using System.Security.Principal;

var accs = new Dictionary<int, double>();
string[] s1 = Console.ReadLine().Split(',');
for (int i = 0; i < s1.Length; i++)
{
    string[] s2 = s1[i].Split('-');
    accs.Add(int.Parse(s2[0]), double.Parse(s2[1]));
}
while (true)
{
    string[] s = Console.ReadLine().Split(' ');
    if (s[0]=="End")
    {
        return;
    }
    try
    {
        if (!accs.ContainsKey(int.Parse(s[1])))
        {
            throw new ArgumentException("Invalid account!");
        }
        switch (s[0])
        {
            case "Deposit":
                accs[int.Parse(s[1])] += double.Parse(s[2]);
                break;
            case "Withdraw":
                if (accs[int.Parse(s[1])] - double.Parse(s[2]) >= 0)
                {
                    accs[int.Parse(s[1])] -= double.Parse(s[2]);
                }
                else
                    throw new ArgumentException("Insufficient balance!");
                break;
            default:
                throw new ArgumentException("Invalid command!");
        }
        Console.WriteLine($"Account {s[1]} has new balance: {accs[int.Parse(s[1])]:f2}");
    }
    catch (ArgumentException ae)
    {
        Console.WriteLine(ae.Message);
    }
    Console.WriteLine("Enter another command");
}