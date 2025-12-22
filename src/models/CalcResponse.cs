namespace InvestCalc.Models
{
    public class CalcResponse
    {
        public string ProjectName { get; set; } = string.Empty;
        public double Tco { get; set; }
        public double Roi { get; set; }
        public double PaybackPeriodYears { get; set; }

        public CalcResponse() { }

        public CalcResponse(string projectName, double tco, double roi, double paybackPeriodYears)
        {
            ProjectName = projectName;
            Tco = tco;
            Roi = roi;
            PaybackPeriodYears = paybackPeriodYears;
        }
    }
}
