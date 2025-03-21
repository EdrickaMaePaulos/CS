﻿using System;

public class Blender{
    public void Blend(){
        Console.WriteLine("There's nothing to blend here, princess.");
    }
    
    public void Blend(string fruit1, string fruit2){
        Console.WriteLine($"Blending {fruit1} and {fruit2}, princess.");
    }
    
    public void Blend(string fruit1, string fruit2, int n){
        for (int i = 0; i < n; i++){
            Console.WriteLine($"Blending {fruit1} and {fruit2}, princess.");
        }
    }
}
public class Program
{
        
    public static void TestBlender(int version, string fruit1, string fruit2, int n)
    {
        Blender blend = new Blender();
        Console.WriteLine($"Testing Blender Version: {version}");

        switch (version)
        {
            case 1:
                blend.Blend();
                break;
            case 2:
                blend.Blend(fruit1, fruit2);
                break;
            case 3:
                blend.Blend(fruit1, fruit2, n);
                break;
        }

        Console.WriteLine();
    }

    public static void Main(string[] args)
    {
        Console.Write("Enter test case number (1-3): ");
        int testCaseNumber = int.Parse(Console.ReadLine());

        switch (testCaseNumber)
        {
            case 1:
                // Test Case 1: Version 1 (No fruits)
                TestBlender(1, "", "", 0);
                break;
            case 2:
                // Test Case 2: Version 2 (Two fruits)
                TestBlender(2, "Strawberry", "Raspberry", 0);
                break;
            case 3:
                // Test Case 3: Version 3 (Two fruits, blended multiple times)
                TestBlender(3, "Peach", "Mango", 3);
                break;
            default:
                Console.WriteLine("Invalid test case number");
                break;
        }
    }
}