// Objective: Find the two Taco Bells that are the farthest apart from one another.

using System;
using System.Linq;
using System.IO;
using GeoCoordinatePortable;

namespace LoggingKata
{
    class Program
    {
        static readonly ILog logger = new TacoLogger();
        const string csvPath = "TacoBell-US-AL.csv";

        static void Main(string[] args)
        {

            logger.LogInfo("Log initialized");
            
            // Log an error if you get 0 lines and a warning if you get 1 line
            var lines = File.ReadAllLines(csvPath);

            if (lines.Length == 0)
            {
                logger.LogError("Error try again");
                return;
            }
            else if(lines.Length == 1)
            {
                logger.LogWarning("Warning 1 line");
            }

            // This will display the first item in your lines array
            logger.LogInfo($"Lines: {lines[0]}");

            // This will create a new instance of your TacoParser class
            var parser = new TacoParser();

            // Parses every line in lines collection
            var locations = lines.Select(parser.Parse).ToArray();
            
            // These will be used to store your two Taco Bells that are the farthest from each other.
            ITrackable startingPoint = null;
            ITrackable endingPoint = null;

            // stores the distance
            double furthestDistance = 0;

            // FIRST FOR LOOP -
            // Loop that goes through each item in my collection of locations 
            
            for (int i = 0; i < locations.Length; i++)
            {
                // This loop will let you select one location at a time to act as the "starting point" or "origin" location.

                //stores locA longitude and latitude in corA 
                var locA = locations[i];
                var corA = new GeoCoordinate(locA.Location.Latitude, locA.Location.Longitude);

                // SECOND FOR LOOP - iterates through locations again
                for (int j = i + 1 ; j < locations.Length; j++)
                {
                    // This allows you to pick a "destination" location for each "origin" location from the first loop. corB does the same thing as corA
                    var locB = locations[j];
                    var corB = new GeoCoordinate(locB.Location.Latitude, locB.Location.Longitude);

                    double distance = corA.GetDistanceTo(corB);

                    // If the distance is greater than the currently saved distance, update the distance variable and the two `ITrackable` variables you set above.
                    if (distance > furthestDistance)
                    {
                        furthestDistance = distance;
                        startingPoint = locA;
                        endingPoint = locB;
                    }
                    
                }

            }

            // Once you've looped through everything, you've found the two Taco Bells farthest away from each other.
            // Display these two Taco Bell locations to the console.
            
            logger.LogInfo($"The two furthest Taco Bells are {startingPoint.Name} at {startingPoint.Location.Latitude}, {startingPoint.Location.Longitude}\nfrom {endingPoint.Name} at {endingPoint.Location.Latitude}, {endingPoint.Location.Longitude}");
            logger.LogInfo($"Distance total between the two: {furthestDistance} meters");

        }
    }
}
