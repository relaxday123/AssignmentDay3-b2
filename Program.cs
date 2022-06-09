namespace b5
{
    class Program
    {
        public static async Task PrintPrimeNumber(int startNumber, int endNumber)
        {
            await Task.Run(() =>
            {
                int ctr;

                for (int i = startNumber; i <= endNumber; i++)
                {
                    ctr = 0;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            ctr++;
                            break;
                        }
                    }

                    if (ctr == 0 && i > 1)
                    {
                        Console.Write("{0} ", i);
                        Task.Delay(100).Wait();
                    }
                }
            });
        }

        public static void Main(string[] args)
        {
            PrintPrimeNumber(0, 100);
            PrintPrimeNumber(101, 200);
            Console.ReadKey();
        }
    }
}
