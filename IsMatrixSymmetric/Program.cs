class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n > 100)
        {
            Console.WriteLine("Массив должен быть меньше или равен 100");
            return;
        }
        int[,] array = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            string[] row = Console.ReadLine().Split();
            for (int j = 0; j < n; j++)
            {
                array[i, j] = int.Parse(row[j]);
            }
        }

        if (isMatrixSymmetric(array))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }

    static bool isMatrixSymmetric(int[,] array)
    {
        int n = array.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (array[i, j] != array[j, i])
                {
                    return false;
                }
            }
        }
        return true;
    }
}