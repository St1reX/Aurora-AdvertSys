using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities
{
    public class DistanceCalculator
    {
        private const double EarthRadiusKm = 6371.0;

        public static double CalculateDistance(string lat1, string lon1, string lat2, string lon2)
        {
            double latitude1 = double.Parse(lat1);
            double longitude1 = double.Parse(lon1);
            double latitude2 = double.Parse(lat2);
            double longitude2 = double.Parse(lon2);

            double dLat = DegreesToRadians(latitude2 - latitude1);
            double dLon = DegreesToRadians(longitude2 - longitude1);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(DegreesToRadians(latitude1)) * Math.Cos(DegreesToRadians(latitude2)) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return EarthRadiusKm * c;
        }

        private static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }
    }
}
