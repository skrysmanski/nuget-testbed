using NuGetTestBed.PackageProvider;

namespace NuGetTestBed.PackageConsumer
{
    public static class Program
    {
        public static void Main()
        {
            new MyExampleClass().Test();
        }
    }
}
