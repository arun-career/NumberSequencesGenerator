using Generator.Business.Core;
using System.Collections.Generic;

namespace Generator.Business
{
    public class GenerateSpecialNumbers : IGenerator
    {
        public string Name { get { return "Special Numbers"; } }

        public List<string> Execute(int number)
        {
            var result = new List<string>();        

            for (int i = 1; i <= number; i++)
            {
                var isDivisibleBy3 = i % 3 == 0;

                var isDivisibleBy5 = i % 5 == 0;

                if (isDivisibleBy3 && isDivisibleBy5)
                    result.Add("Z");
                else if (isDivisibleBy5)
                    result.Add("E");
                else if (isDivisibleBy3)
                    result.Add("C");
                else
                    result.Add(i.ToString());
            }
           
            return result;
        }
    }
}