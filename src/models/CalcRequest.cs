namespace InvestCalc.Models
{
    public class CalcRequest
    {
        public string ProjectName { get; set; } = string.Empty;

        public double Capex { get; set; }
        public double Opex { get; set; }
        public double TrainingCosts { get; set; }

        public int PeriodYears { get; set; }

        public double ExpectedSavingsPerYear { get; set; }
        public double ExpectedRevenueGrowthPerYear { get; set; }
    }
}
