

using KnowledgeCheck2_SD_Module2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("How many cakes do you want to add? ");
        var numberOfCakes = int.Parse(Console.ReadLine());

        var cakeList = new List<CakeValue>();
        for (int i = 0; i < numberOfCakes; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var CakeValue = new CakeValue();

            Console.WriteLine("Please enter a cake name... ");
            CakeValue.Name = Console.ReadLine();

            Console.WriteLine("Please enter a cake description... ");
            CakeValue.Description = Console.ReadLine();

            Console.WriteLine("Please enter a cake price... ");
            CakeValue.Price = decimal.Parse(Console.ReadLine());

            cakeList.Add(CakeValue);
        }
        
      
        foreach (var cake in cakeList)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine($"Name: {cake.Name}, Description: {cake.Description}, Price: {cake.Price}");
            Console.WriteLine("-----------------");
        }
    }
}