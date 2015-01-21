using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsTemplate
{
    public static class CalculationFacade
    {
        public static double GetPrice(Flight flight)
        {
            double price;

            if (flight.FlightClass == FlightClass.Business)
                price = CalculationBusiness.GetPrice(flight);
            else
                price = CalculationEconom.GetPrice(flight);
            return price;
        }
    }

    public static class CalculationBusiness
    {
        const double rate = 2.5;
        const double rateDistance = 0.9;
        static Dictionary<FlightTime, double> rateTime;
        public static double GetPrice(Flight flight)
        {
            rateTime = new Dictionary<FlightTime, double>
            {
                {FlightTime.Afternoon, 1.2},
                {FlightTime.Evening, 2.0},
                {FlightTime.Morning, 4.5},
                {FlightTime.Night, 3.4}
            };
            double[] ratePassengers = new double[3];
            ratePassengers[0] = 2.1;
            ratePassengers[1] = 1.4;
            ratePassengers[2] = 0.4;

            double tempDestination = FlightHelper.Instance.GetDistanceToDestination(flight.Destination);
            double tempAdults = ratePassengers[0] * flight.Passengers.NumberOfAdults;
            double tempChildren = ratePassengers[1] * flight.Passengers.NumberOfChildren;
            double tempBabies = ratePassengers[2] * flight.Passengers.NumberOfBabies;
            return ( rate + rateTime[flight.Time] ) * ( rateDistance * tempDestination + tempAdults + tempChildren + tempBabies );
         }
     }

    public static class CalculationEconom
    {
        const double rate = 0.7;
        const double rateDistance = 0.4;
        static Dictionary<FlightTime, double> rateTime;

        public static double GetPrice(Flight flight)
        {
            rateTime = new Dictionary<FlightTime, double>
            {
                {FlightTime.Afternoon, 0.2},
                {FlightTime.Evening, 1.0},
                {FlightTime.Morning, 2.5},
                {FlightTime.Night, 1.8}
            };
            double[] ratePassengers = new double[3];
            ratePassengers[0] = 1.6;
            ratePassengers[1] = 0.8;
            ratePassengers[2] = 0.4;

            double tempDestination = FlightHelper.Instance.GetDistanceToDestination(flight.Destination);
            double tempAdults = ratePassengers[0] * flight.Passengers.NumberOfAdults;
            double tempChildren = ratePassengers[1] * flight.Passengers.NumberOfChildren;
            double tempBabies = ratePassengers[2] * flight.Passengers.NumberOfBabies;
            return (rate + rateTime[flight.Time]) * (rateDistance * tempDestination + tempAdults + tempChildren + tempBabies);
        }
    }
}

