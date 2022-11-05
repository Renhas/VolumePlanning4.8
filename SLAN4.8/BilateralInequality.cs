
namespace SLAN
{
    /// <summary>
    /// Двустороннее неравенство вида 
    /// </summary>
    public class BilateralInequality : Inequality
    {

        public float Max { get; set; }

        public BilateralInequality(int dimension, float min = 0, float max = 0) : base(dimension, min) 
        {
            Max = max;
        }

        public BilateralInequality(float[] coefficients, float min = 0, float max = 0) : base(coefficients, min) 
        {
            Max = max;
        }

        public BilateralInequality(MyVector coefficients, float min = 0, float max = 0) : base(coefficients, min) 
        {
            Max = max;
        }

        public override bool Check(MyVector values)
        {
            return (base.Check(values) && Calculate(values) <= Max);
        }

        public override string ToString()
        {
            return base.ToString() + $"<= {Max}";
        }
    }
}
