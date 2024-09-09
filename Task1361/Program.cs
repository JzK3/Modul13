using System.Diagnostics;

namespace Task1361
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine();
            var text = File.ReadAllText(@"C:\Users\JzK\Desktop\azaz.txt");
            char[] delimiters = new char[] { ' ', '\r', '\n' };
            var words = text.Split(delimiters,StringSplitOptions.RemoveEmptyEntries);
            List<string> list = new List<string>();
            var stopWatch1 = Stopwatch.StartNew();
            foreach (var item in words)
            {
                list.Add(item);
            }
            Console.WriteLine("time 1");
            Console.WriteLine(stopWatch1.Elapsed.TotalMilliseconds);
            LinkedList<string> linkedList = new LinkedList<string>();
            var stopWatch = Stopwatch.StartNew();
            foreach (var item in words)
            {
                linkedList.AddLast(item);
            }
            Console.WriteLine("time 2");
            Console.WriteLine(stopWatch.Elapsed.TotalMilliseconds);

        }
    }
}
