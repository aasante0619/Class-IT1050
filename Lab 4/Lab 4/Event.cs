

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
        public double FoodPriceTotal;

        public double TicketPrice;
        public double ConcessionPrice;

        public Event()
        {
            System.Console.WriteLine("What is the time of day (in military time)?");
            this.timeOfDay = int.Parse(System.Console.ReadLine());

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

            this.TicketPrice = this.calculateTicketPrice();
            this.ConcessionPrice = this.calculateFoodPrices();
        }

        private double calculateTicketPrice()
        {
            if (this.timeOfDay < 1200)
            {
                return this.getMatineePrice(this.movieGoerAge);
            }
            else
            {
                return this.getEveningPrice(this.movieGoerAge);
            }
        }

        private double getMatineePrice(int age)
        {
            if (age < 17) { return 3.99; }
            else if (age < 55) { return 6.99; }
            else { return 5.99; }
        }

        private double getEveningPrice(int age)
        {
            if (age < 17) { return 4.50; }
            else if (age < 55) { return 10.99; }
            else { return 8.50; }
        }

        public double calculateFoodPrices()
        {
            double total = 0;
            total += (this.numberOfLargeSoda * 5.99);
            total += (this.numberOfSmallSoda * 3.50);
            total += (this.numberOfHotDogs * 3.99);
            total += (this.numberOfPopcorn * 4.50);
            total += (this.numberOfCandies * 1.99);
            return total;
        }
    }
}

