using UnitConverter.Models;

namespace UnitConverter.Services
{
    public class WeightConversionService
    {

        public double ConvertWeight(double value, WeightUnit from, WeightUnit to)
        { if(value < 0) return 0;
            double valueInKilograms = value * GetConversionByWeight(from);
            double valueTo = GetConversionByWeight(to);
            double result = valueInKilograms / valueTo;
            return result;
        }


        private double GetConversionByWeight(WeightUnit weightUnit)
        {
            return weightUnit switch
            {
                WeightUnit.Milligram => 0.000001,
                WeightUnit.Gram => 0.001,
                WeightUnit.Kilogram => 1,
                WeightUnit.Ounce => 0.0283495,
                WeightUnit.Pound => 0.453592,
                _ => 1,
            };

                
        
        }
    }
}
