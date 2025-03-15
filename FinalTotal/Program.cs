

class MainClass {
    static public void Main()
    {
        int total = 10;
        Console.Write("Enter an integer: ");
        int integer = int.Parse(Console.ReadLine());
        if (integer > 0){
            if (integer % 2 == 0){
                total += integer * integer;
                Console.WriteLine(total);
            }
            else{
                total += integer * integer * integer;
                Console.WriteLine(total);
            }
        }
        else if (integer < 0){
            Console.Write ("Enter another integer: ");
            int power = int.Parse(Console.ReadLine());
            int result = (int)Math.Pow(integer, power);
            total += result;
            Console.WriteLine(total);
        }
        else {
            Console.WriteLine("Nothing happened.");
        }
    }
}