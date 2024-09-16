namespace LoggingKata
{
    public interface ITrackable
    {
        // Property to get or set the name of the trackable item
        string Name { get; set; }
        
        // Property to get or set the location of the trackable item as a Point
        Point Location { get; set; }
    }
}