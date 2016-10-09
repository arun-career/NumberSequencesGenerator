using Generator.Business.Core;
using System;
using System.Collections.Generic;

namespace Generator.Business
{
    public class GenerateFibonacciNumbers: IGenerator
    {
        public string Name { get { return "Fibonacci Numbers"; } }

        public List<string> Execute(int number)
        {
            var result = new List<string>();

            var firstNumber = 0;

            var secondNumber = 1;

            result.Add(firstNumber.ToString());

            result.Add(secondNumber.ToString());

            var thirdNumber = firstNumber + secondNumber;

            for (int i = 3; thirdNumber <= number; i++)
            {                
                result.Add(thirdNumber.ToString());

                firstNumber = secondNumber;

                secondNumber = thirdNumber;

                thirdNumber = firstNumber + secondNumber;
            }

            if (number > Convert.ToInt64(result[result.Count - 1]))  //including upper limit when it is not included in the series
                result.Add(number.ToString());

            return result;
        }
    }
}