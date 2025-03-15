namespace LeapYear;

class Program
{
    public static void LeapYear(int year)
    {
        if (year % 400 == 0)
        {
            Console.WriteLine($"{year} is a leap year.");
        }
        else if (year % 100 == 0)
        {
            Console.WriteLine($"{year} is not a leap year.");
        }
        else if (year % 4 == 0)
        {
            Console.WriteLine($"{year} is a leap year.");
        }
    }
    
    static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        LeapYear(year);
    }
}