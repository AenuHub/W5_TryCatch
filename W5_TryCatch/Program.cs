public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"{number} squared is {number * number}.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
        
        Console.ReadKey();
    }
}