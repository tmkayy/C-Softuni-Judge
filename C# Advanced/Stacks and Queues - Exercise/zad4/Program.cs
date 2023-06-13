using System.Linq;
namespace zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(System.Console.ReadLine());
            System.Collections.Generic.Queue<int> q = new System.Collections.Generic.Queue<int> (System.Console.ReadLine().Split(' ').Select(int.Parse));
            System.Console.WriteLine(q.Max());
            while (true)
            {
                if (q.Count == 0)
                {
                    System.Console.WriteLine("Orders complete");
                    return;
                }
                if (n>=q.Peek())
                {
                    n -= q.Dequeue();
                }
                else
                {
                    break;
                }
            }
            System.Console.WriteLine("Orders left: " + System.String.Join(" ", q));
        }
    }
}
