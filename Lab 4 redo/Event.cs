

namespace Lab_4
{
    class Event
    {
        public string movieGoer;
        public int movieGoerAge;
        public double timeOfDay;
        public int numberOfLargeSoda;
        public int numberOfSmallSoda;
        public int numberOfHotDogs;
        public int numberOfPopcorn;
        public int numberOfCandies;
        public double concessionPrice;
        public double DiscountedConcessionPrice;
        public double TotalPrice;




        public double FoodPriceTotal;


        public double TicketPrice;
        public double ConcessionPrice;

 

        public void calculateTicketPrice()
        {
            if (this.timeOfDay < 1200 && this.movieGoerAge < 18)
            {
                TicketPrice = 3.99;

            }
            if (this.timeOfDay < 1200 && this.movieGoerAge > 18 && this.movieGoerAge < 65)
            {
                TicketPrice = 5.99;
            }

                      
            if (this.timeOfDay < 1200 && this.movieGoerAge > 18 && this.movieGoerAge > 65)
            {

                TicketPrice = 4.50;
            }


            if (this.timeOfDay > 1200 && this.movieGoerAge < 18)
            {
                TicketPrice = 6.99;

            }
            if (this.timeOfDay > 1200 && this.movieGoerAge > 18 && this.movieGoerAge < 65)
            {
                TicketPrice = 10.99;
            }


            if (this.timeOfDay < 1200 && this.movieGoerAge > 18 && this.movieGoerAge > 65)
            {

                TicketPrice = 8.50;
            }


        }

        public void GetEventInfo()
        {

            System.Console.WriteLine(" What is the name of the moviegoer?");
            this.movieGoer = System.Console.ReadLine();

            System.Console.WriteLine("What is the moviegoer's age?");
            this.movieGoerAge = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("What is the time of day (in military time)?");
            this.timeOfDay = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many large sodas does the moviegoer want?");
            this.numberOfLargeSoda = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many small sodas does the moviegoer want?");
            this.numberOfSmallSoda = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many hot dogs does the moviegoer want?");
            this.numberOfHotDogs = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many orders of popcorn does the moviegoer want?");
            this.numberOfPopcorn = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("How many orders of Candies does the moviegoer want?");
            this.numberOfCandies = int.Parse(System.Console.ReadLine());

        }

        public void  GetConcessionPrice()
        {

            concessionPrice = 0;
            concessionPrice += (this.numberOfLargeSoda * 5.99);
            concessionPrice += (this.numberOfSmallSoda * 3.50);
            concessionPrice += (this.numberOfHotDogs * 3.99);
            concessionPrice += (this.numberOfPopcorn* 4.50);
            concessionPrice += (this.numberOfCandies * 1.99);
            
        }

        public void GetDiscountedConcessionPrice()
        {

            DiscountedConcessionPrice = this.concessionPrice;

            if (this.numberOfPopcorn > 0 && this.numberOfLargeSoda > 0)
                {
                this.TicketPrice -= 2;
                }
            
            if (this.timeOfDay > 1200)
            {
                DiscountedConcessionPrice = this.concessionPrice - 1.48;
            }

            this.DiscountedConcessionPrice -= (1.99  *(numberOfCandies /4));

         }

        public void GetTotalPrice()
    
        {
            this.TotalPrice = 0;
            this.TotalPrice += this.DiscountedConcessionPrice;
            this.TotalPrice += this.TicketPrice;


    

    }
}

