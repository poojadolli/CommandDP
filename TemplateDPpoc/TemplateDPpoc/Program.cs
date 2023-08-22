using TemplateDPpoc.Model;

namespace TemplateDPpoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage coffee = new Coffee();
            Console.WriteLine("Making coffee:");
            coffee.PrepareBeverage();

            Console.WriteLine();

            Beverage tea = new Tea();
            Console.WriteLine("Making tea:");
            tea.PrepareBeverage();
        }
    }
}