namespace lists_merge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> result = new List<int>();
            string[] list = input.Split('|');
            for (int i = list.Length - 1; i >= 0; i--)
            {
                string[] elements = list[i].Split(' ');
                foreach (string element in elements)
                {
                    if (element.Length > 0)
                    {
                        result.Add(int.Parse(element));
                    }
                }
            }
            foreach (int number in result)
            {
                Console.Write(number + " ");
            }
        }
    }
}
