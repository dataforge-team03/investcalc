using InvestCalc.Models;

namespace InvestCalc.Services
{
    public class LocalCalcService
    {
        public CalcResponse Calculate(CalcRequest req)
        {
            double tco = req.Capex + (req.Opex * req.PeriodYears) + req.TrainingCosts;

            double yearlyBenefit = req.ExpectedSavingsPerYear + req.ExpectedRevenueGrowthPerYear;
            double benefits = yearlyBenefit * req.PeriodYears;

            double roi = tco == 0 ? 0 : ((benefits - tco) / tco) * 100;
            double payback = yearlyBenefit == 0 ? 0 : tco / yearlyBenefit;

            return new CalcResponse(req.ProjectName, tco, roi, payback);
        }
    }
}
