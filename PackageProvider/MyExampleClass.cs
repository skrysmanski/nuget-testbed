using System;
using JetBrains.Annotations;

namespace NuGetTestBed.PackageProvider
{
    public class MyExampleClass
    {
        [PublicAPI]
        public void Test()
        {
            Console.WriteLine("Hello, NuGet!");
        }
    }
}
