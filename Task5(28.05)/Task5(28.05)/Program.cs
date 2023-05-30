namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 3, 4, 1, 16, 21, 34, 48, 53 };
            int[] evenNums = { };

            getEven(nums, evenNums);

            Console.ReadLine();

        }
        static void getEven(int[] numbers, int[] evenNumbers)
        {
            int leng = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    leng++;
                    Array.Resize(ref evenNumbers, leng);
                    evenNumbers[leng - 1] = numbers[i];
                }
            }
            for(int j = 0; j < evenNumbers.Length; j++)
            {
                Console.WriteLine(evenNumbers[j]);
            }
        }
    }
}