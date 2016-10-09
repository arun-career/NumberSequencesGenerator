using Generator.Business.Core;
using System.Collections.Generic;

namespace Generator.Business
{
    public class GenerateOddNumbers : IGenerator
    {
        public string Name { get { return "Odd Numbers"; } }

        public List<string> Execute(int number)
        {
            var result = new List<string>();

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 1)
                    result.Add(i.ToString());
            }

            if (number > 1 && number % 2 == 0)  //including upper limit when it is even number
                result.Add(number.ToString());

            return result;
        }
    }
}