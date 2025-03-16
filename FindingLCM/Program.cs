using System;

class LCM{
    
    static void Main(){
        Console.Write("Enter number of inputs: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        
        Console.Write($"Enter {n} inputs: ");
        string inputs = Console.ReadLine();
        string[] inputStrings = inputs.Split(' ');
        
        
        for (int i = 0; i < n; i++){
            numbers[i] = int.Parse(inputStrings[i]);
        }
        int lcm = CalculatedLCM(numbers);
        Console.WriteLine("LCM = " + lcm);
        
    }
    
    public static int CalculatedLCM(int[] numbers){
        
        if (numbers.Length == 0){
            return 1;
        }
        
        int result = numbers[0];
        for (int i = 1; i < numbers.Length; i++){
            result = FindLCM(result, numbers[i]);
        }
        return result;
    }
    
    
    public static int FindLCM(int a, int b){
        return (a * b) / FindGCD(a, b);
    }
    
    public static int FindGCD(int a, int b){
        while (b != 0){
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}