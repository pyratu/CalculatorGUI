public class LengthConvertor
{
    private static Dictionary<string, double> conversionFactors = new Dictionary<string, double>
    {
    {"meters", 1},
    {"kilometers", 0.001},
    {"centimeters", 100},
    {"millimeters", 1000},
    {"feet", 3.28084},         // 1 meter = 3.28084 feet
    {"inches", 39.3701},       // 1 meter = 39.3701 inches
    {"yards", 1.09361},        // 1 meter = 1.09361 yards
    {"miles", 0.000621371192}, // 1 meter = 0.000621371192 miles
    {"nautical miles", 0.0005399568034557235}, // 1 meter = 0.0005399568034557235 nautical miles
    };
    public static double Convert(double value, string fromUnit, string toUnit)
    {
        double result;
        if (conversionFactors.ContainsKey(fromUnit) && conversionFactors.ContainsKey(toUnit))
        {
            double fromFactor = conversionFactors[fromUnit];
            double toFactor = conversionFactors[toUnit];
            result = value * (toFactor / fromFactor);

            if (Math.Abs(result) < 0.01)
            {
                return Math.Round(result, 4); // Round to four decimal places for small values
            }
            else
            {
                return Math.Round(result, 2); // Round to two decimal places for other values
            }
        }
        else
        {
            return 0;
        }
        Console.WriteLine(result);
    }
}