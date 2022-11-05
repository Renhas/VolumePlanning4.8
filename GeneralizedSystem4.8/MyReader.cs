using SLAN;
using System;
using System.Collections.Generic;
using System.IO;

namespace GeneralizedSystem
{
    public class MyReader : IMyReader
    {
        public MyReader() 
        {

        }

        public InequalitySystem Read(string file) 
        {
            string[] lines = File.ReadAllLines(file);
            int ControlledCount = int.Parse(lines[0].Split()[1]);
            var system = new BilateralInequalitySystem(int.Parse(lines[0].Split()[0]), ControlledCount);

            
            for (int i = 1; i < lines.Length; i++) 
            {
                if (lines[i] == "") break;
                string[] inequality = lines[i].Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);

                int min = int.Parse(inequality[0]);
                MyVector coefficients = new MyVector(inequality[1]);
                if (inequality.Length == 4)
                    system.Add(new ControlledBilateralInequality(coefficients, ReadPreferences(inequality[3]), min, int.Parse(inequality[2])));
                else if (inequality.Length == 3)
                    system.Add(new BilateralInequality(coefficients, min, int.Parse(inequality[2])));
                else if (inequality.Length == 2)
                    system.Add(new Inequality(coefficients, min));
            }
            return system;
        }

        private List<int[]> ReadPreferences(string str) 
        {
            string[] preferences = str.Split(new char[] { '[', ']', '(', ')', ',', ' '}, StringSplitOptions.RemoveEmptyEntries);
            List<int[]> list = new List<int[]>();
            for (int i = 0; i < preferences.Length; i += 2) 
            {
                list.Add(new int[] { int.Parse(preferences[i]), int.Parse(preferences[i + 1]) });
            }
            return list;
        }
    }
}