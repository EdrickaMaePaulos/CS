namespace Pattern;

class Program
{
    static void Main(string[] args)
    {
       Console.Write("Enter n: ");
       int n = int.Parse(Console.ReadLine());
       
       PrintPatternBox(n);
       Console.WriteLine();
       PrintPatternTriangle(n);
       
    }

    public static void PrintPatternBox(int n)
    {
        for (int i = 0; i < 2 * n - 1; i++)
        {
            for (int j = 0; j < 2 * n - 1; j++)
            {
                int value = Math.Max(Math.Abs(n - 1 - i), Math.Abs(n - 1 - j)) + 1;
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
    public static void PrintPatternTriangle(int n)
    {
        for (int i = 0; i < 2 * n - 1; i++)
        {
            for (int j = 0; j < 2 * n - i - 1; j++)
            {
                int value = Math.Max(Math.Abs(n - 1 - i), Math.Abs(n - 1 - j)) + 1;
                Console.Write(value + " ");
            }
            Console.WriteLine();
        }
    }
}