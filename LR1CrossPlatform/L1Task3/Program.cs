namespace L1Task3
{
    internal class Program
    {
        private static Random _random = new Random();
        private static int[] _trials;

        static int DiceRoll(int sides) {
            return _random.Next(sides) + 1;
        }

        static int OneDice()
        {
            return DiceRoll(6);
        }

        static int TwoDice()
        {
            return DiceRoll(6) + DiceRoll(6);
        }

        static int NDice(int N, int K)
        {
            int sum = 0;
            for (int i = 0; i < N; i++)
                sum = sum + DiceRoll(K);
            return sum;
        }

        static void hist()
        {
            SortedDictionary<uint, int> histogram = new SortedDictionary<uint, int>();
            foreach (uint item in _trials)
            {
                if (histogram.ContainsKey(item))
                {
                    histogram[item]++;
                }
                else
                {
                    histogram[item] = 1;
                }
            }
            foreach (KeyValuePair<uint, int> pair in histogram)
            {
                Console.WriteLine($"{String.Format("{0,4}",pair.Key)}\t{new string('■', pair.Value)} ({pair.Value})");
            }
        }


        static void Main(string[] args)
        {
            Console.Clear();

            int n;
            int N;
            int K;
  
            Console.Write("Enter the number of trials:");
            if (!Int32.TryParse(Console.ReadLine(), out n))
                n = 10;
            Console.WriteLine($"Dice will rool {n} times!");
            _trials = new int[n];

            Console.WriteLine("\nChoose a number of dice:");
            Console.WriteLine("\t1 - one dice with 6 sides");
            Console.WriteLine("\t2 - two dice with 6 sides");
            Console.WriteLine("\t3 - N dice with K sides");
            Console.WriteLine("\t4 - exit");
            Console.Write("\r\nSelect an option 1,2,3 or 4: ");

            switch (Console.ReadLine())
            {
                case "1":
                    for (int i = 0; i < n; i++)
                        _trials[i] = OneDice();
                    hist();
                    break;
                case "2":
                    for (int i = 0; i < n; i++)
                        _trials[i] = TwoDice();
                    hist();
                    break;
                case "3":
                    Console.Write("Enter the number of dice:");
                    if (!Int32.TryParse(Console.ReadLine(), out N))
                        N = 3;
                    Console.WriteLine($"You choose a {N} dice!");
                    Console.Write("Enter the number of sides:");
                    if (!Int32.TryParse(Console.ReadLine(), out K))
                        K = 8;
                    Console.WriteLine($"Your dice will have {K} sides!");
                    for (int i = 0; i < n; i++)
                        _trials[i] = NDice(N,K);
                    hist();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
            }
            Console.ReadKey();
        }
    }
}