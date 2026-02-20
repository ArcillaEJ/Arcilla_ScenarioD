using System;

abstract class WaterFilter
{
    private string filterID;
    private int usageCount;

    public string FilterID
    {
        get { return filterID; }
    }

    public int UsageCount
    {
        get { return usageCount; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Usage count cannot be negative.");
            usageCount = value;
        }
    }

    public WaterFilter(string id, int usage)
    {
        filterID = id;
        UsageCount = usage;
    }

    public abstract void ProcessWater();

    public double CalculateEfficiency()
    {
        if (UsageCount == 0)
            throw new DivideByZeroException("No water processed yet.");

        return 100.0 / UsageCount;
    }
}