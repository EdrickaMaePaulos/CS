namespace OrderingSystem;

class OrderingSystem
{
    enum FoodCategory  {
        MainCourse = 1,
        Dessert
    }

    static void DisplayCategories()
    {
        Console.WriteLine("Available Food Categories:");
        Console.WriteLine($"{(int)FoodCategory.MainCourse}.  {FoodCategory.MainCourse}");
        Console.WriteLine($"{(int)FoodCategory.Dessert}.  {FoodCategory.Dessert}");
    }

    static void DisplayMenu(FoodCategory foodCategory, string[] dishes)
    {
        Console.WriteLine($"\nAvailable {foodCategory}");
        for (int i = 0; i < dishes.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {dishes[i]}");
        }
    }
    static void Main(string[] args)
    {
        string[] mainCourseDishes =
        {
            "Steak",
            "Grilled Chicken"
        };

        string[] dessertDishes =
        {
            "Ice Cream",
            "Chocolate Cake"
        };
        
        DisplayCategories();
        int categoryChoice;
        while (true)
        {
            Console.Write("\nEnter the number of your preferred category: ");
            if (int.TryParse(Console.ReadLine(), out categoryChoice))
            {
                if (categoryChoice == (int)FoodCategory.MainCourse || categoryChoice == (int)FoodCategory.Dessert)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }
        }

        FoodCategory selectedCategory = (FoodCategory)categoryChoice;
        string[] selectedDishes =(selectedCategory == FoodCategory.MainCourse) ? mainCourseDishes : dessertDishes;
        
        DisplayMenu(selectedCategory, selectedDishes);

        int dishChoice;
        while (true)
        {
            Console.Write("\nEnter the number of your preferred dish: ");
            if (int.TryParse(Console.ReadLine(), out dishChoice))
            {
                if (dishChoice >= 1 && dishChoice <= selectedDishes.Length)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }

            else
            {
                Console.WriteLine("Invalid input. Try again.");
            }
        }

        string orderedDish = selectedDishes[dishChoice - 1];
        Console.WriteLine($"\nYou ordered: {orderedDish}. Enjoy your meal!");
    }
}