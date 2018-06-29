using System;

namespace BMICalculation
{
    interface IBmiCalculation
    {
        double CriticalResult(Human human);
        BmiCalculationResult Calculation(double result);
    }
}
