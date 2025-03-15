using System;


class Program{

    
    public static void Main(){
        Console.WriteLine("Enter the principal amount: ");
        double principal = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the rate of interest: ");
        double rate = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the time in years: ");
        double time = double.Parse(Console.ReadLine());
        
        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine($"The simple interest is: {simpleInterest}");
    }
}