

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Event Event1 = new Event();
            System.Console.WriteLine("Your total ticket cost is  " + Event1.TicketPrice);
            System.Console.WriteLine("Your total food cost is  " + Event1.FoodPriceTotal);

            System.Console.WriteLine("---------------------------------------------------");




            Event Event2 = new Event();
            System.Console.WriteLine("Your total ticket cost is  " + Event2.TicketPrice);
            System.Console.WriteLine("Your total food cost is  " + Event2.FoodPriceTotal);

            System.Console.WriteLine("---------------------------------------------------");



            Event Event3 = new Event();
            System.Console.WriteLine("Your total ticket cost is  " + Event3.TicketPrice);
            System.Console.WriteLine("Your total food cost is  " + Event3.FoodPriceTotal);

            System.Console.WriteLine("---------------------------------------------------");



            Event Event4 = new Event();
            System.Console.WriteLine("Your total ticket cost is  " + Event4.TicketPrice);
            System.Console.WriteLine("Your total food cost is  " + Event4.FoodPriceTotal);
        }
    }
}