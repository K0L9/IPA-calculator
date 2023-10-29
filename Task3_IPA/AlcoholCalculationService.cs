namespace Task3_IPA
{
    public static class AlcoholCalculationService
    {
        public static double CalculateTotalValue(double value, int vesselCount)
        {
            if (vesselCount < 0 || value <= 0)
                throw new ArgumentOutOfRangeException($"Argument can't be less than 0");

            return value * vesselCount;
        }
        public static double CalculateAlcoCount(double value, int vesselCount, double alcoProcent)
        {
            if (alcoProcent < 0 || alcoProcent > 100) throw new ArgumentOutOfRangeException("Procent must be in 0 - 100");
            try
            {
                double totalValue = CalculateTotalValue(value, vesselCount);
                return (totalValue * alcoProcent) / 100;
            }
            catch (Exception) { throw; }
        }
    }
}
