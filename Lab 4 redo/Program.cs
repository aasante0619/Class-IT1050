

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Event Event1 = new Event();


            Event1.GetEventInfo();
            Event1.calculateTicketPrice();
            Event1.GetConcessionPrice();
            Event1.GetDiscountedConcessionPrice();
            Event1.GetTotalPrice();

            System.Console.WriteLine("Your total ticket cost is  " + Event1.TicketPrice);
            System.Console.WriteLine("Your total food cost is  " + Event1.FoodPriceTotal);


            System.Console.WriteLine("Your total ticket cost is  " + Event1.TicketPrice);
            System.Console.WriteLine("Your total concession cost is  " + Event1.concessionPrice);
            System.Console.WriteLine("Your total concession cost with the discount is  " + Event1.DiscountedConcessionPrice);
            System.Console.WriteLine("---------------------------------------------------");




            Event Event2 = new Event();


            Event2.GetEventInfo();
            Event2.calculateTicketPrice();
            Event2.GetConcessionPrice();
            Event2.GetDiscountedConcessionPrice();
            Event2.GetTotalPrice();
            System.Console.WriteLine("Your total ticket cost is  " + Event2.TicketPrice);
            System.Console.WriteLine("Your total concession cost is  " + Event2.concessionPrice);
            System.Console.WriteLine("Your total concession cost with the discount is  " + Event2.DiscountedConcessionPrice);

            System.Console.WriteLine("Your total ticket cost is  " + Event2.TicketPrice);
            System.Console.WriteLine("Your total food cost is  " + Event2.FoodPriceTotal);


            System.Console.WriteLine("---------------------------------------------------");



            Event Event3 = new Event();

            Event3.GetEventInfo();
            Event3.calculateTicketPrice();
            Event3.GetConcessionPrice();
            Event3.GetDiscountedConcessionPrice();
            Event3.GetTotalPrice();
            System.Console.WriteLine("Your total ticket cost is  " + Event3.TicketPrice);
            System.Console.WriteLine("Your total concession cost is  " + Event3.concessionPrice);
            System.Console.WriteLine("Your total concession cost with the discount is  " + Event3.DiscountedConcessionPrice);

            System.Console.WriteLine("Your total ticket cost is  " + Event3.TicketPrice);
            System.Console.WriteLine("Your total food cost is  " + Event3.FoodPriceTotal);

            System.Console.WriteLine("---------------------------------------------------");



            Event Event4 = new Event();


            Event4.GetEventInfo();
            Event4.calculateTicketPrice();
            Event4.GetConcessionPrice();
            Event4.GetDiscountedConcessionPrice();
            Event4.GetTotalPrice();
            System.Console.WriteLine("Your total ticket cost is  " + Event4.TicketPrice);
            System.Console.WriteLine("Your total concession cost is  " + Event4.concessionPrice);
            System.Console.WriteLine("Your total concession cost with the discount is  " + Event4.DiscountedConcessionPrice);
            System.Console.WriteLine("---------------------------------------------------");


            System.Console.WriteLine("Total Event Cost for " + Event1.movieGoer + " is  " + Event1.TotalPrice + " .");
            System.Console.WriteLine("Total Event Cost for " + Event2.movieGoer + " is  " + Event2.TotalPrice + " .");
            System.Console.WriteLine("Total Event Cost for " + Event3.movieGoer + " is  " + Event3.TotalPrice + " .");
            System.Console.WriteLine("Total Event Cost for " + Event4.movieGoer + " is  " + Event4.TotalPrice + " .");

            System.Console.WriteLine("Grand Total for ALL MOVIEGOERS IS  " + (Event1.TotalPrice + Event2.TotalPrice+ Event3.TotalPrice+ Event4.TotalPrice) + "  wow!");

            System.Console.ReadKey();





        }
    }
}
