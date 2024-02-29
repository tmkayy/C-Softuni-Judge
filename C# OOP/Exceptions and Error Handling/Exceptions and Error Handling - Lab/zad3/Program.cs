using System.Text.RegularExpressions;

char[] c1 = { ',', ' ' };
List<string> lol = Console.ReadLine().Split(c1, StringSplitOptions.RemoveEmptyEntries).ToList();
List<string> output = new List<string>();
for (int i = 0; i < lol.Count - 1; i += 2)
{
    var c = new Card(lol[i], lol[i + 1]);
    try
    {
        output.Add(c.Validation());
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
Console.WriteLine(String.Join(" ", output));

class Card
{
    Regex r = new Regex(@"10|[2-9JQKA]");
    Regex r2 = new Regex(@"[SHDC]");

    public Card(string face, string suit)
    {
        Face = face;
        Suit = suit;
    }

    public string Face { get; set; }
    public string Suit { get; set; }

    public string Validation()
    {
        if (r.IsMatch(Face) && r2.IsMatch(Suit))
        {
            if (Suit == "S")
            {
                return $"[{Face}\u2660]";
            }
            else if (Suit == "H")
            {
                return $"[{Face}\u2665]";
            }
            else if (Suit == "D")
            {
                return $"[{Face}\u2666]";
            }
            else
            {
                return $"[{Face}\u2663]";
            }
        }
        else
        {
            throw new Exception("Invalid card!");
        }
    }
}
