namespace ToolBX.Mathemancy;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds Mathemancy services.
    /// </summary>
    public static IServiceCollection AddMathemancy(this IServiceCollection services, AutoInjectOptions? options = null) => services.AddAutoInjectServices(Assembly.GetExecutingAssembly(), options);
}