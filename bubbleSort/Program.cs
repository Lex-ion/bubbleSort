namespace bubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] pole = { 1,2,3,4,5,6,7,8 };
           Random rand = new Random();

            int[] randomPole = { 2, 8, 6, 9,7, 4,10,9,5, 6, 3, 1, 2 };
            BubbleSort(randomPole);
            //Render(pole,0);
        }

        public static int[] BubbleSort(int[] input)
        {
            while (true)
            {
                bool changed = false;
                for (int i = 0; i < input.Length - 1; i++)
                {
                    Render(input, i);

                    if (input[i] < input[i + 1])
                    {
                        int tmp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = tmp;
                        changed = true;
                    }
                    Thread.Sleep(500);
                }
                if (!changed)
                {
                    break;
                }
            }
            return input;
        }


        public static void Render(int[] pole, int cyklus)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < pole.Length ; i++)
            {
                if (i == cyklus|| i-1 ==cyklus)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                for (int j = 0; j < pole[i]; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
                Console.ForegroundColor =ConsoleColor.White;
            }
        }
    }
}