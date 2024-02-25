namespace remove_negative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("eneter numbers: ");
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count; i++) 
            {
                if (numbers[i] >= 0)
                {
                    result.Add(numbers[i]);
                }
            }
            if (result.Count > 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                Console.WriteLine("Empty");
            }
        }
    }
}