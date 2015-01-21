using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTemplate
{
    public class Flight
    {
        readonly string destination;
        readonly NumberOfPassengers passengers;
        readonly FlightClass flightClass;
        readonly FlightTime time;
        private double price;
        
        public Flight()
        {
            destination = "";
            passengers = new NumberOfPassengers(0, 0, 0);
            flightClass = FlightClass.Econom;
            time = FlightTime.Night;
        }
        public Flight(string destination, NumberOfPassengers number, FlightClass flightClass, FlightTime time)
        {
            this.destination = destination;
            this.passengers = number;
            this.flightClass = flightClass;
            this.time = time;
        }
        public string Destination
        {
            get { return destination; }
        }
        public NumberOfPassengers Passengers
        {
            get { return passengers; }
        }
        public FlightClass FlightClass
        {
            get { return flightClass; }
        }
        public FlightTime Time
        {
            get { return time; }
        }
        public double Price
        {
            get{ return price; }
            set{ price = value;}
        }
    }
}
