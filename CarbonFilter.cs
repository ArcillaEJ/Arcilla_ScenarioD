class CarbonFilter : WaterFilter
{
    private double debrisLevel;

    public double DebrisLevel
    {
        get { return debrisLevel; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Debris level cannot be negative.");
            debrisLevel = value;
        }
    }

    public CarbonFilter(string id, int usage, double debris)
        : base(id, usage)
    {
        DebrisLevel = debris;
    }

    public override void ProcessWater()
    {
        Console.WriteLine("Carbon Filter Processing...");
        Console.WriteLine($"Removing physical debris level: {DebrisLevel}");
    }
}