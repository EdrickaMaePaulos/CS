using System;

class DigitProduct{
    static void Main(){
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        int product = 1;
        
        while (n > 0){
            int digit = n % 10;
            if (digit != 0){
                product *= digit;
            }
            n /= 10;
        }
        Console.WriteLine("Digit Product: " + product);
    }
}