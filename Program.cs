class Program
{
    static void Main(string[] args)
    {
        try
        {
            WaterFilter carbon = new CarbonFilter("CF-01", 5, 20);
            WaterFilter chemical = new ChemicalFilter("CH-01", 0, 15);

            carbon.ProcessWater();
            Console.WriteLine("Efficiency: " + carbon.CalculateEfficiency());
            Console.WriteLine();

            chemical.ProcessWater();
            Console.WriteLine("Efficiency: " + chemical.CalculateEfficiency()); // This will throw error
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Efficiency Error: " + ex.Message);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Input Error: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("System Shutdown");
        }
    }
}