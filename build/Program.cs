using Cake.Frosting;
using dotenv.net;
using Overleaf.Cake.Frosting;
using Overleaf.Cake.Frosting.Extensions;
using Overleaf.Cake.Frosting.Tasks;

namespace Build;

public static class Program
{
    public static int Main(string[] args)
    {
        DotEnv.Fluent()
            .WithEnvFiles("../.env")
            .Load();

        return new CakeHost()
            .AddAssembly(typeof(CleanTask).Assembly)
            .UseWorkingDirectory("..")
            .InstallTools()
            .UseContext<BuildContext>()
            .Run(args);
    }
}