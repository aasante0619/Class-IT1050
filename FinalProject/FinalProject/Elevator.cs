using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Elevator
    {

        private double MaxWeight;
        public Passenger[] Occupants;

        public Elevator (int maxOccupants, double maxWeight)

        {

            Occupants = new Passenger[maxOccupants];

            MaxWeight = maxWeight;
            
        }





        public void AddOccupant(int index, Passenger passenger)

        {

            Occupants[index] = passenger;
           
            
        }


        public double GetCurrentWeight()


        {

            double elevatorweight = 0;

           elevatorweight += Passenger.GetWeight()

        }

        public bool isOverCapacity()

        {

        if (GetCurrentWeight() > MaxWeight)

            {

                return true;
            }

        else

            {

                return false;
            }



        }
    }

}
