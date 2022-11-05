using SLAN;
using System.IO;

namespace Agmon_Motzkin
{
    public class MyReader : IMyReader
    {
        public MyReader() 
        {
        
        }

        public InequalitySystem Read(string path) 
        {
            string[] lines = File.ReadAllLines(path);
            char[] badChars = new char[] {' '};
            string[] line = lines[0].Split(badChars);
            int variablesCount = int.Parse(line[0]), inequalityCount = int.Parse(line[1]);

            InequalitySystem system = new InequalitySystem(variablesCount);
            MyVector rightParts = new MyVector(lines[inequalityCount + 1]);
            for (int i = 0; i < inequalityCount; i++) 
            {
                system.Add(new Inequality(new MyVector(lines[i + 1]), (int)rightParts[i]));
            }
            return system;
        }
    }
}
