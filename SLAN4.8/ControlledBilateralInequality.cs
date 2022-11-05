using System;
using System.Collections.Generic;

namespace SLAN
{
    public class ControlledBilateralInequality : BilateralInequality
    {
        private List<int[]> _preferences;

        public int PreferencesCount { get { return _preferences.Count; } }


        public ControlledBilateralInequality(int dimension, List<int[]> preferences, int min = 0, int max = 0) : base(dimension, min, max)
        {
            SetPreferences(preferences);
        }

        public ControlledBilateralInequality(float[] coefficients, List<int[]> preferences,  int min = 0, int max = 0) : base(coefficients, min, max)
        {
            SetPreferences(preferences);
        }

        public ControlledBilateralInequality(MyVector coefficients, List<int[]> preferences, int min = 0, int max = 0) : base(coefficients, min, max)
        {
            SetPreferences(preferences);
        }

        private void SetPreferences(List<int[]> preferences) 
        {
            foreach (int[] value in preferences)
            {
                if (value.Length != 2) throw new ArgumentException("Некорректные предпочтения");
            }
            _preferences = new List<int[]>(preferences);
        }

        public void SetSelectedPreference(int preference) 
        {
            if (preference < 0 || preference >= PreferencesCount) throw new ArgumentException("Некорректный индекс предпочтения");

            this.Min = _preferences[preference][0];
            this.Max = _preferences[preference][1];
        }

        public bool Check(MyVector values, int preference)
        {
            if (preference < 0 || preference >= PreferencesCount) throw new ArgumentException("Некорректный индекс предпочтения");

            return new BilateralInequality(this.Coefficients, _preferences[preference][0], _preferences[preference][1]).Check(values);
        }

        public override bool Check(MyVector values)
        {
            return this.Check(values, 0);
        }

        public override string ToString()
        {
            string result = base.ToString() + " | ";
            foreach (var preference in _preferences) 
            {
                result += $"[{preference[0]}, {preference[1]}] ";
            }
            return result;
        }
    }
}
