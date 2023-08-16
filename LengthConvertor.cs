public class LengthConvertor
{
    private static Dictionary<string, double> conversionFactors = new Dictionary<string, double>
    {
        {"Millimeters", 0.001},
        {"Centimeters", 0.01},
        {"Meters", 1},
        {"Kilometers", 1000},
    };
    public static double Convert(double value, string fromUnit, string toUnit)
    {
        if (conversionFactors.ContainsKey(fromUnit) && conversionFactors.ContainsKey(toUnit))
        {
            return value * (conversionFactors[fromUnit] / conversionFactors[toUnit]);
        }
        else
        {
            throw new ArgumentException("Unsupported units");
        }
    }
}