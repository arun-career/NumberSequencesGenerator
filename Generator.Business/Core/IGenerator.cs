using System.Collections.Generic;

namespace Generator.Business.Core
{
    public interface IGenerator
    {
        string Name { get; }

        List<string> Execute(int number);
    }
}