

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Event Event1 = new Event();

            Event1.GetEventInfo();
            Event1.CalculateTicketPrice();
            System.Console.WriteLine("Your total ticket cost is  " + Event1.TicketPrice);

            System.Console.WriteLine("---------------------------------------------------");




            Event Event2 = new Event();

            Event2.GetEventInfo();
            Event2.CalculateTicketPrice();
            System.Console.WriteLine("Your total ticket cost is  " + Event2.TicketPrice);

            System.Console.WriteLine("---------------------------------------------------");



            Event Event3 = new Event();

            Event3.GetEventInfo();
            Event3.CalculateTicketPrice();
            System.Console.WriteLine("Your total ticket cost is  " + Event3.TicketPrice);

            System.Console.WriteLine("---------------------------------------------------");



            Event Event4 = new Event();

            Event4.GetEventInfo();
            Event4.CalculateTicketPrice();
            System.Console.WriteLine("Your total ticket cost is  " + Event4.TicketPrice);



        }
    }
}
