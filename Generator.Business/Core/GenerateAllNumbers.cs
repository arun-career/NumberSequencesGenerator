using Generator.Business.Core;
using System.Collections.Generic;

namespace Generator.Business
{
    public class GenerateAllNumbers : IGenerator
    {
        public string Name { get { return "All Numbers"; } }

        public List<string> Execute(int number)
        {
            var result = new List<string>();

            for (int i = 1; i <= number; i++)
                result.Add(i.ToString());

            return result;
        }
    }
}