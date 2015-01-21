using System.Collections.Generic;

namespace PatternsTemplate
{
    public enum FlightClass { Econom, Business };
    public enum FlightTime { Night, Morning, Afternoon, Evening };

    public sealed class FlightHelper
    {
        private static readonly FlightHelper instance = new FlightHelper();

        readonly Dictionary<string, double> distanceToDestination = new Dictionary<string, double>()
        {
            {"Kazan", 719},    
            {"NizhnyNovgorod", 402},
            {"SaintPetersburg", 634},
            {"Sochi", 1362},
            {"Ufa", 1165},
        };

        private FlightHelper() { }

        public static FlightHelper Instance
        {
            get { return instance; }
        }

        public Dictionary<string, double> DistanceToDestination
        {
            get { return distanceToDestination; }
        }


        public double GetDistanceToDestination(string destination)
        {
            return DistanceToDestination[destination];
        }
    }

    public struct NumberOfPassengers
    {
        readonly int numberOfAdults;
        readonly int numberOfChildren;
        readonly int numberOfBabies;

        public NumberOfPassengers(int numberOfAdults, int numberOfChildren, int numberOfBabies)
        {
            this.numberOfAdults = numberOfAdults;
            this.numberOfChildren = numberOfChildren;
            this.numberOfBabies = numberOfBabies;
        }

        public int NumberOfAdults
        {
            get { return numberOfAdults; }
        }

        public int NumberOfChildren
        {
            get { return numberOfChildren; }
        }

        public int NumberOfBabies
        {
            get { return numberOfBabies; }
        }
    }
}