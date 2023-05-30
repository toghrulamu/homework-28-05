namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = { 4, 5, 2, 6, 4, 3 };
            int[] numbers2 = { 7, 4, 2, 76, 45, 65 };

            for(int i = 0; i < numbers1.Length; i++)
            {
                if (!numbers2.Contains(numbers1[i]))
                {
                    Console.WriteLine(numbers1[i]);
                }
            }

            Console.ReadLine();
        }
    }
}