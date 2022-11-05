

using System;
using System.Collections.Generic;

namespace SLAN
{
    /// <summary>
    /// Система неравенств вида AX >= B
    /// </summary>
    public class InequalitySystem
    {
        protected List<Inequality> Inequalities { get; set; }
        public int VariableCount { get; }
        public int InequalitiesCount { get { return Inequalities.Count; } }

        public InequalitySystem(int variableCount) 
        {
            Inequalities = new List<Inequality>();
            VariableCount = variableCount;
        }

        public Inequality this[int index] 
        {
            get { return Inequalities[index]; }
            set 
            { 
                if(value.Dimension != VariableCount) throw new ArgumentException("Некорректное количество элементов");
                Inequalities[index] = value;
            }
        }
        /// <summary>
        /// Добавление неравенства
        /// </summary>
        /// <exception cref="ArgumentException"></exception>
        public virtual void Add(Inequality inequality) 
        {
            if(VariableCount != inequality.Dimension) throw new ArgumentException("Некорректное количество элементов");
            Inequalities.Add(inequality);
        }
        /// <summary>
        /// Проверка системы на совместность, исходя из вектора значений неизвестных и точности эпсилон
        /// </summary>
        public bool Compatibility(MyVector values, float epsilon = 0f) 
        {
            bool result = true;
            foreach (var inequality in Inequalities) 
            {
                inequality.Min -= epsilon;
                if (!inequality.Check(values)) result = false;
                inequality.Min += epsilon;
                if (!result) break;
            }
            return result;
        }

        public override string ToString()
        {
            string result = "";
            foreach (var inequality in Inequalities) result += $"{inequality}\n";
            return result;
        }
    }
}
