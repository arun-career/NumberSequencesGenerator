using Generator.Business.Core;
using System.Collections.Generic;

namespace Generator.Business
{
    public class GenerateEvenNumbers : IGenerator
    {
        public string Name { get { return "Even Numbers"; } }

        public List<string> Execute(int number)
        {
            var result = new List<string>();

            for (int i = 1; i <= number; i++)
            {
                 if (i % 2 == 0)
                    result.Add(i.ToString());
            }

            if (number > 1 && number % 2 == 1)  //including upper limit when it is odd number
                result.Add(number.ToString());

            return result;
        }
    }
}