using System;

class Program{
    public static void Main(){
        Console.Write("Enter number 1: ");
        int one = int.Parse(Console.ReadLine());
        
        Console.Write("Enter number 2: ");
        int two = int.Parse(Console.ReadLine());
        
        Console.Write("Enter number 3: ");
        int three = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"{one}" + $"{two}" + $"{three}");
    }
}