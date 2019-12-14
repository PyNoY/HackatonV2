﻿using System;

namespace HartaAplicatie
{
    class Program
    {
        const double PIx = Math.PI;
        const double RADIO = 6378.16;
        public static double Radians(double x)
        {
            return x * PIx / 180;
        }
        public static double DistanceBetweenPlaces(double lon1, double lat1, double lon2, double lat2)
        {
            double R = 6371; // km

            double sLat1 = Math.Sin(Radians(lat1));
            double sLat2 = Math.Sin(Radians(lat2));
            double cLat1 = Math.Cos(Radians(lat1));
            double cLat2 = Math.Cos(Radians(lat2));
            double cLon = Math.Cos(Radians(lon1) - Radians(lon2));

            double cosD = sLat1 * sLat2 + cLat1 * cLat2 * cLon;

            double d = Math.Acos(cosD);

            double dist = R * d;

            return dist;
        }
        static void Main(string[] args)
        {
            double distanta = DistanceBetweenPlaces(25.601196, 45.6579, 25.601196, 45.657974);
            distanta = Math.Round(distanta, 3);
            if (distanta < 1)
            {
                distanta = distanta * 1000;
                Console.WriteLine("Mai sunt " + distanta+ " metri pana la destinatie.");
            }
            else
            {
                Console.WriteLine(distanta);
            }
        }
    }
}
