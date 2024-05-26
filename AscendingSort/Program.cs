namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = { { 7, 3, 2 }, 
                         { 4, 9, 6 }, 
                         { 1, 8, 5 } };

            Console.WriteLine("An array is set:");
            for (int i = 0;  i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("Sorted array:");
            int[] arraySort = new int[a.Length];
            var counter = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    arraySort[counter++] = a[i, j];
                }
            }
            Array.Sort(arraySort);
            counter = 0;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = arraySort[counter++];
                    Console.Write(a[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
