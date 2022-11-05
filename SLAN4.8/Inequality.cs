
using System;

namespace SLAN
{
    /// <summary>
    /// Одностороннее неравенство вида ax >= b
    /// </summary>
    public class Inequality
    {
        public MyVector Coefficients { get; private set; }
        public float Min { get; set; }
        public int Dimension { get { return Coefficients.Dimension; } }

        public Inequality(int dimension, float min = 0)
        {
            Coefficients = new MyVector(dimension);
            Min = min;
        }

        public Inequality(float[] coefficients, float min = 0) : this(new MyVector(coefficients), min)
        {
        }

        public Inequality(MyVector coefficients, float min = 0)
        {
            Coefficients = new MyVector(coefficients);
            Min = min;
        }

        public float this[int index]
        {
            get { return Coefficients[index]; }
            set { Coefficients[index] = value; }
        }
        /// <summary>
        /// Вычисление значения левой части, используя вектор значений неизвестных
        /// </summary>
        public float Calculate(MyVector values)
        {
            return values * Coefficients;
        }
        /// <summary>
        /// Проверка неравенства исходя из вектора значений неизвестных
        /// </summary>
        public virtual bool Check(MyVector values) 
        {
            if (Calculate(values) < Min) return false;
            else return true;
        }

        public override string ToString()
        {
            string result = $"{Min} <= ";
            for(int i = 0; i < Coefficients.Dimension; i++) 
            {
                if (Coefficients[i] == 0) continue;
                if (Coefficients[i] > 0 && result != $"{Min} <= ") result += "+";
                else if (Coefficients[i] < 0) result += "-";
                if (Math.Abs(Coefficients[i]) != 1f) result += $"{Math.Abs(Coefficients[i])}";
                result += $"x{i + 1} ";
            }
            return result;
        }
    }
}
