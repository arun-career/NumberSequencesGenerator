using System.Collections.Generic;

namespace Generator.Business
{
    public interface IGeneratorService
    {
        Dictionary<string, List<string>> Execute(int number);
    }
}