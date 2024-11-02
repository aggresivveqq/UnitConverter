using System.Security.Cryptography.X509Certificates;
using UnitConverter.Models;

namespace UnitConverter.Services
{
    public class LengthConvertionService
    {
        public double ConvertLength(double value,LengthUnit from,LengthUnit to)
        {
            if(value < 0) return 0;
            double valueInMeters = value * GetConversionbyLength(from);
            double valueTo = GetConversionbyLength(to);
            return valueInMeters / valueTo;
        }

        private double GetConversionbyLength(LengthUnit lengthUnit) {
            return lengthUnit switch
            {
                LengthUnit.Millimeter => 0.001,
                LengthUnit.Centimeter => 0.01,
                LengthUnit.Meter => 1,
                LengthUnit.Kilometer => 1000,
                LengthUnit.Inch => 0.0254,
                LengthUnit.Foot => 0.3048,
                LengthUnit.Yard => 0.9144,
                LengthUnit.Mile => 1609.34,
                _ => 1,
            };
        }

    }
}
