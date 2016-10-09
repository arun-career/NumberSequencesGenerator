using Generator.Business.Core;
using Microsoft.Practices.Unity;

namespace Generator.Business
{
    public static class CoreDependency
    {
        public static void Register(UnityContainer container)
        {
            container.RegisterType<IGenerator, GenerateAllNumbers>("GenerateAllNumbers");
            container.RegisterType<IGenerator, GenerateFibonacciNumbers>("GenerateFibonacciNumbers");
            container.RegisterType<IGenerator, GenerateEvenNumbers>("GenerateEvenNumbers");
            container.RegisterType<IGenerator, GenerateOddNumbers>("GenerateOddNumbers");
            container.RegisterType<IGenerator, GenerateSpecialNumbers>("GenerateSpecialNumbers");
        }
    }
}