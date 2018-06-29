namespace BMICalculation
{
    public class Human
    {
        public Sexuality Sexuality { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public Human(Sexuality sexuality, double height, double weight)
        {
            Sexuality = sexuality;
            Height = height;
            Weight = weight;
        }
    }
}
