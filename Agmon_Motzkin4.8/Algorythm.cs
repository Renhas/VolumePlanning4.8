using SLAN;
using System;

namespace Agmon_Motzkin
{
    /// <summary>
    /// Статический класс, инкапсулирующий в себе алгоритм Агмона-Моцкина
    /// </summary>
    public static class Algorythm
    {
        /// <summary>
        /// Метод, запускающий алгоритм
        /// </summary>
        /// <returns>true, если система совместна; false, иначе</returns>
        /// <exception cref="ArgumentException"></exception>
        public static bool Run(InequalitySystem system, int steps, float epsilon, out MyVector answer) 
        {
            if (steps <= 0 || epsilon < 0 || system == null) throw new ArgumentException("Некорректные параметры алгоритма");
            answer = new MyVector(system.VariableCount);

            for (int i = 0; i < steps; i++) 
            {
                if (system.Compatibility(answer)) return true;
                ///Имитация эпсилон-окрестности
                if (system.Compatibility(answer, epsilon)) return true;

                float? maxValue = null;
                int maxId = -1;

                for (int j = 0; j < system.InequalitiesCount; j++) 
                {
                    float t = (-system[j].Calculate(answer) + system[j].Min) / (system[j].Coefficients * system[j].Coefficients);
                    if (maxValue == null || maxValue < t) 
                    {
                        maxValue = t;
                        maxId = j;
                    }
                }
                if (maxValue != null) answer += Math.Abs((float)maxValue) * system[maxId].Coefficients;
                
            }
            return false;
        }
    }
}