namespace find_index_of_given_item_in_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4 };

            Console.WriteLine("Enter a number to find:");
            int target = int.Parse(Console.ReadLine());

            int find = FindIndex(numbers, target);

            if (find == -1)
            {
                Console.WriteLine("Number not found in the array.");
            }
            else
            {
                Console.WriteLine($"Number found at index {find}.");
            }
        }

        static int FindIndex(int[] numbers, int target)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

