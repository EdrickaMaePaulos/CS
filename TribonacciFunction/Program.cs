using System;

class TribonacciSequence{
    
    public static int Tribo(int n){
        if (n == 0) return 0;
        else if (n == 1 || n == 2){
            return 1;
        }
        int a = 0, b = 1, c = 1, result = 0;
        for (int i = 3; i <= n; i++){
            result = a + b + c;
            a = b;
            b = c;
            c = result;
        }
        return result;
    }
    public static void Main(){
        Console.Write("Enter value for n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine($"Element {n} of the Tribonacci Sequence is: {Tribo(n)}.");
        
    }
}