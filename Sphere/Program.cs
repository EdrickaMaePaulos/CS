using System;

class DimensionsOfASphere{
    
    public static void SurfaceArea(double radius){
        double surfaceArea = 4 * Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("Surface Area: {0:F2}", surfaceArea);
    }
    
    public static void Volume(double radius){
        double volume = (4.0 / 3) * Math.PI * Math.Pow(radius, 3);
        Console.WriteLine("Volume: {0:F2}", volume);
    }
    
    public static void Main(){
        Console.Write("Enter the diameter of the sphere: ");
        double diameter = double.Parse(Console.ReadLine());
        double radius = diameter / 2;
        
        SurfaceArea(radius);
        Volume(radius);
    }
}