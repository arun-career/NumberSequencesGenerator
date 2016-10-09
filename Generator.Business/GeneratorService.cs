using Generator.Business.Core;
using System.Collections.Generic;

namespace Generator.Business
{
    public class GeneratorService : IGeneratorService
    {
        private IEnumerable<IGenerator> Generators { get; set; }

        public GeneratorService(IEnumerable<IGenerator> generators)
        {
            Generators = generators;
        }

        public Dictionary<string, List<string>> Execute(int number)
        {
            var result = new Dictionary<string, List<string>>();            

            foreach (var i in Generators)
                result.Add(i.Name, i.Execute(number));
            
            return result;
        }
    }
}