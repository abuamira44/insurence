public class Insuree
{
    internal int Age;
    internal decimal Quote;

    public int CarYear { get; internal set; }
    public string CarMake { get; internal set; }
    public string CarModel { get; internal set; }
    public int SpeedingTickets { get; internal set; }
    public bool HasDUI { get; internal set; }
    public string CoverageType { get; internal set; }
    public object InsureeId { get; internal set; }
}