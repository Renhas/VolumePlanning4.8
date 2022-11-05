using System;
using System.Globalization;

namespace SLAN
{
    /// <summary>
    /// Вектор фиксированной длины с вещественными компонентами
    /// </summary>
    public class MyVector
    {
        private float[] Values { get; set; }
        public int Dimension { get { return Values.Length; } }


        public MyVector(int dimension, int position = 0) 
        {
            Values = new float[dimension];
            for (int i = 0; i < dimension; Values[i] = 0, i++) ;
            if(position > 0) Values[position - 1] = 1;
        }

        public MyVector(float[] values) : this(values.Length)
        {
            values.CopyTo(Values, 0);
        }

        public MyVector(MyVector vector) : this(vector.Values)
        {
        }

        public MyVector(string values) : this(FromStringToFloat(values))
        {
        }

        private static float[] FromStringToFloat(string str) 
        {
            string[] values = str.Split(new char[] {' '} , StringSplitOptions.RemoveEmptyEntries);
            float[] coefficients = new float[values.Length];
            for (int i = 0; i < values.Length; i++) coefficients[i] = float.Parse(values[i], NumberStyles.Any);
            return coefficients;
        }

        public float this[int index] 
        {
            get { return Values[index]; }
            set { Values[index] = value; }
        }
        /// <summary>
        /// Получение обратного вектора
        /// </summary>
        public static MyVector operator !(MyVector vector)
        {
            MyVector result = new MyVector(vector);
            for (int i = 0; i < result.Dimension; result[i] *= -1, i++) ;
            return result;
        }

        /// Операции сложения ///
        
        public static MyVector operator +(MyVector first, MyVector second) 
        {
            if (first.Dimension != second.Dimension) throw new ArgumentException("Разная длина векторов");
            MyVector result = new MyVector(first);
            for (int i = 0; i < second.Dimension; i++) result[i] += second[i];
            return result;
        }

        public static MyVector operator +(MyVector vector, float number) 
        {
            MyVector result = new MyVector(vector);
            for (int i = 0; i < result.Dimension; result[i] += number, i++) ;
            return result;
        }

        public static MyVector operator +(float number, MyVector vector) => vector + number;

        
        /// Операции умножения ///

        public static float operator *(MyVector first, MyVector second) 
        {
            if (first.Dimension != second.Dimension) throw new ArgumentException("Разная длина векторов");
            float result = 0;
            for (int i = 0; i < first.Dimension; result += first[i] * second[i], i++) ;
            return result;
        }

        public static MyVector operator *(MyVector vector, float number) 
        {
            MyVector result = new MyVector(vector);
            for (int i = 0; i < result.Dimension; result[i] *= number, i++) ;
            return result;
        }

        public static MyVector operator *(float number, MyVector vector) => vector * number;

        /// Операции вычитания ///

        public static MyVector operator -(MyVector first, MyVector second) => first + !second;
        public static MyVector operator -(MyVector vector, float number) => vector + number * -1;
        public static MyVector operator -(float number, MyVector vector) => !vector + number;

        /// <summary>
        /// Операция деления на число
        /// </summary>
        public static MyVector operator /(MyVector vector, float number) => vector * (1 / number);

        /// Операции сравнения ///

        public static bool operator ==(MyVector first, object second) => first.Equals(second);

        public static bool operator !=(MyVector first, object second) => !(first == second);

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is MyVector)) return false;
            MyVector vector = obj as MyVector;
            if (vector.Dimension != this.Dimension) return false;
            for (int i = 0; i < vector.Dimension; i++)
            {
                if (vector[i] != this[i]) return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return Dimension;
        }

        public override string ToString()
        {
            string buf = "(";
            for (int i = 0; i < this.Dimension; buf += $"{this[i].ToString(CultureInfo.CreateSpecificCulture("en-US"))}, ",i++) ;
            return buf.Remove(buf.Length - 2) + ")";
        }

    }
}
