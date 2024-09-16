namespace LoggingKata;

// The TacoBell class represents a Taco Bell location
// It implements the ITrackable interface, which ensures it has a Name and Location
public class TacoBell : ITrackable
{
    public string Name { get; set; }
    public Point Location { get; set; }
    
}