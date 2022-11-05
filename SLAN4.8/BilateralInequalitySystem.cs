using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAN
{
    public class BilateralInequalitySystem : InequalitySystem
    {
        public readonly int ControlledCount;
        public BilateralInequalitySystem(int variableCount, int controlledCount) : base(variableCount)
        {
            ControlledCount = controlledCount;
        }

        public InequalitySystem ToInequality() 
        {
            InequalitySystem system = new InequalitySystem(VariableCount);
            foreach(var inequality in Inequalities)
            {
                system.Add(new Inequality(inequality.Coefficients, inequality.Min));
                if (inequality is BilateralInequality bilateral)
                    system.Add(new Inequality(!bilateral.Coefficients, bilateral.Max * -1));
            }
            return system;
        }

        public void Reset() 
        {
            for (int i = 0; i < ControlledCount; i++) 
            {
                if (Inequalities[i] is ControlledBilateralInequality inequality) 
                    inequality.SetSelectedPreference(0);
            }
        }
    }
}
