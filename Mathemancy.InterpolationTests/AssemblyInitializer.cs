namespace Mathemancy.Interpolation.Tests;

//TODO 3.0.0 Figure out a way to load the assembly automatically
[TestClass]
public static class AssemblyInitializer
{
    [AssemblyInitialize]
    public static void AssemblyInitialize(TestContext _) => AssemblyInitializerBase.Initialize("Eloquentest.Dummies");
}

//TODO Use from Eloquentest
public static class AssemblyInitializerBase
{
    public static void Initialize(string assemblyName) => LoadAssembly(assemblyName);

    private static void LoadAssembly(string assemblyName)
    {
        var loadedAssembly = AppDomain.CurrentDomain.GetAssemblies()
            .FirstOrDefault(a => a.GetName().Name.Equals(assemblyName, StringComparison.OrdinalIgnoreCase));

        if (loadedAssembly != null)
        {
            return;
        }

        try
        {
            Assembly.Load(assemblyName);
        }
        catch
        {
            throw new InvalidOperationException($"Assembly {assemblyName} could not be loaded.");
        }
    }
}