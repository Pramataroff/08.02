namespace remove_last_one
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("eneter numbers: ");
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int result = numbers.Count - 1;
            while (numbers.Contains(result))
            {
                numbers.Remove(result);
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}