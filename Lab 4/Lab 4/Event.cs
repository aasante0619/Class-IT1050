

namespace Lab_4
{
    class Event
    {
        public string movieGoer;
        public int Age;
        public double timeOfDay;
        public int numberOfLargeSoda;
        public int numberOfSmallSoda;
        public int numberOfHotDogs;
        public int numberOfPopcorn;
        public int numberOfCandies;



        public double TicketPrice;

        
        public void GetEventInfo()
        {
            System.Console.WriteLine(" What is the name of the moviegoer?");
            this.movieGoer = System.Console.ReadLine();

            System.Console.WriteLine("What is the moviegoer's age?");
            this.Age = int.Parse(System.Console.ReadLine());

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


        

        public void CalculateTicketPrice()
        {
            if( this.Age < 17 && this.timeOfDay < 1200)
            {
                TicketPrice = 3.99;
            }
                
            if (this.Age < 17 && this.timeOfDay > 1200)

            {
                TicketPrice = 6.99;
            }

            if (this.Age > 17 && this.Age < 55 && this.timeOfDay < 1200)

            {
                TicketPrice = 5.99;
            }

            if (this.Age > 17 && this.Age < 55 && this.timeOfDay > 1200)

            {
                TicketPrice = 10.99;
            }

            if (this.Age > 17 && this.Age > 55 && this.timeOfDay < 1200)

            {
                TicketPrice = 4.50;
            }


            if (this.Age > 17 && this.Age > 55 && this.timeOfDay > 1200)

            {
                TicketPrice = 8.50;
            }
        }

      
        



        }
    }

