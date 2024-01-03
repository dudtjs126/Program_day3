namespace collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // List 사용하기
            {
                List<int> numbers = new List<int>();
                numbers.Add(1);
                numbers.Add(2);
                numbers.Add(3);
                numbers.Remove(2);

                foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }

                for (int i = 0; i < numbers.Count; i++)
                {
                    Console.WriteLine(numbers[i]);
                }
            }
        }
    }
}
