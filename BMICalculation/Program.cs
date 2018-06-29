using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculation
{
    internal class BMI : BmiCalculation
    {
        public override BmiCalculationResult Calculation()
        {
            switch (Human.Sexuality)
            {
                case Sexuality.Female:
                    if (BmiResult < 18)
                    {
                        return BmiCalculationResult.太瘦;
                    }
                    else if (BmiResult > 22)
                    {
                        return BmiCalculationResult.太胖;
                    }
                    else
                    {
                        return BmiCalculationResult.適中;
                    }
                case Sexuality.Male:
                    if (BmiResult < 20)
                    {
                        return BmiCalculationResult.太瘦;
                    }
                    else if (BmiResult > 25)
                    {
                        return BmiCalculationResult.太胖;
                    }
                    else
                    {
                        return BmiCalculationResult.適中;
                    }
                default:
                    return BmiCalculationResult.NULL;
            }
        }

        public override void CriticalResult()
        {
            BmiResult = Human.Weight / Math.Pow(Human.Height, 2);
        }
        public BMI(Human human) : base(human)
        {
            CriticalResult();
        }
    }




    class Program
    {
        static void Main(string[] args)
        {
            var tester = new Human(Sexuality.Male, 1.73, 82);
            var bmi = new BMI(tester);
            Console.WriteLine(bmi.Calculation().ToString());
            Console.Read();
        }
    }
}
