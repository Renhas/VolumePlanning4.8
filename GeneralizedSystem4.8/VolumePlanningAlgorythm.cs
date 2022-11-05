using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SLAN;
using Agmon_Motzkin;

namespace GeneralizedSystem
{
    /// <summary>
    /// Алгоритм решение общего случая задачи объёмного планирования
    /// </summary>
    public static class VolumePlanningAlgorythm
    {
        /// <summary>
        /// Запуск алгоритма
        /// </summary>
        /// <returns>Вектор решения или null, если система несовместна</returns>
        /// <exception cref="ArgumentException"></exception>
        public static MyVector Run(BilateralInequalitySystem system, int steps = 1000, float epsilon = 0.001f) 
        {
            ///Сброс границ до изначальных
            system.Reset();
            if (!Algorythm.Run(system.ToInequality(), steps, epsilon, out _)) return null;
            MyVector answer = new MyVector(system.ControlledCount);

            for (int i = 0; i < system.ControlledCount; i++) 
            {
                var inequality = system[i] as ControlledBilateralInequality;
                if (inequality == null) throw new ArgumentException("Некорректная система");
                ///Дихотомический поиск
                int currentPreference = 0, minPos = 0, maxPos = inequality.PreferencesCount - 1;
                for (int j = 1; j <= inequality.PreferencesCount; j *= 2) 
                {
                    int middle = minPos + (maxPos - minPos) / 2;
                    inequality.SetSelectedPreference(middle);
                    if (Algorythm.Run(system.ToInequality(), steps, epsilon, out _))
                    {
                        currentPreference = middle;
                        minPos = middle + 1;
                    }
                    else maxPos = middle;
                }

                inequality.SetSelectedPreference(currentPreference);
                answer[i] = currentPreference + 1;
            }

            return answer;
        }
    }
}
