using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {



            Elevator elevator1 = new Elevator(2, 400);

            Passenger A1 = new Passenger("A1", 180);
            elevator1.AddOccupant(0, A1);

            Passenger A2 = new Passenger("A2", 220);
            elevator1.AddOccupant(1, A2);

            elevator1.isOverCapacity();


            Elevator elevator2 = new Elevator(3, 600);

            Passenger A1 = new Passenger("A1", 200);
            elevator1.AddOccupant(0, A1);

            Passenger A2 = new Passenger("A2", 200);
            elevator1.AddOccupant(1, A1);

            Passenger A3 = new Passenger("A3", 201);
            elevator1.AddOccupant(2, A1);

            elevator2.isOverCapacity();

        }
    }
}
