namespace ChallengeLabsWeek4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = GetInfoFromUser("Please enter a number.");
            int[] ints = new int[num];
            Console.WriteLine($"Input {num} elements in the array:");

            for (int i = 0; i < num; i++) 
            {
                ints[i] = GetInfoFromUser($"Element {i + 1}: ");
            }

            Dictionary<int, int> selectionCount = new Dictionary<int, int>();

            foreach (int i in ints)
            {
                if (selectionCount.ContainsKey(i))
                {
                    selectionCount[i]++;
                }
                else
                {
                    selectionCount[i] = 1;
                }
            }

            foreach (var i in selectionCount) 
            {
                if (i.Value == 1)
                {
                    PrintResults(i.Key, i.Value, "time.");
                }
                else
                {
                    PrintResults(i.Key, i.Value, "times.");
                }
            }
        }

        internal static int GetInfoFromUser(string request)
        {
            string? userInput;
            do
            {
                Console.WriteLine(request);
                userInput = Console.ReadLine();
                return Convert.ToInt32(userInput);
            }while (userInput == "");
        }

        internal static void PrintResults(int i, int j, string occurance)
        {
            Console.WriteLine($"{i} occurs {j} {occurance}");
        }
    }
}
