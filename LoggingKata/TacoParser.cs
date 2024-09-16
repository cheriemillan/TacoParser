namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {

            // U use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array's Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log error message and return null
                logger.LogError("Array is less than 3");
                return null; 
            }
            
            // Get the latitude from my array at cells[0] by parsing
            var latitude = double.Parse(cells[0]);
            
            // Get the longitude from my array at cells[1] by parsing
            var longitude = double.Parse(cells[1]);
            
            
            // grab the array at cells[2]
            string name = cells[2];
            
            // Then I created a TacoBell class that conforms to ITrackable
            
            // Created an instance of point and set the values of latitude and longitude
            var cords = new Point()
            {
                Latitude = latitude,
                Longitude = longitude

            };
            
            // Created an instance of the TacoBell Class and set the values of Name and Location
            var tacoBell = new TacoBell()
            {
                Name = name,
                Location = cords

            };
            
            
            return tacoBell;
            // since it conforms to ITrackable

        }
    }
}
