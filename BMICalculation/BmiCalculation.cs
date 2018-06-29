namespace BMICalculation
{
    abstract class BmiCalculation
    {
        protected Human Human { get; set; }
        protected double BmiResult { get; set; }
        protected BmiCalculation(Human human)
        {
            Human = human;
        }
        public abstract void CriticalResult();
        public abstract BmiCalculationResult Calculation();
    }
}
