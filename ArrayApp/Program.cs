namespace ArrayBubbleSort
{
    class RandomAndBubbleSort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie viel Elemente sollen im Array sein? : ");
            int numberInput = Convert.ToInt32(Console.ReadLine());
            int[] numbersArr = new int[numberInput];

            Console.Write("So sieht das Array aus: [");
            Random rnd = new Random();

            for (int item = 0; item < numberInput; item++)
            {
                numbersArr[item] = rnd.Next(1000);
                Console.Write($"{numbersArr[item]} ");
            }
            Console.WriteLine("\b]");
            Console.WriteLine("----------------");

            Console.Write("So sieht das nach der Sorstierung aus: [");

            //BubbleSort korrigieren und versuchen mit C# constructor zu schreiben

            for (int item = 0; item < numbersArr.Length; item++)
            {
                for (int sort = 0; sort < numbersArr.Length - 1; sort++)
                {
                    if (numbersArr[sort] > numbersArr[sort + 1])
                    {
                        int temp = numbersArr[sort];
                        numbersArr[sort] = numbersArr[sort + 1];
                        numbersArr[sort + 1] = temp;
                    }
                }
            }
            foreach (int item in numbersArr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("\b]");
            Console.ReadKey();
        }
    }
}