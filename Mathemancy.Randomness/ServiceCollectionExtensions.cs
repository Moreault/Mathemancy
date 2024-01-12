namespace ToolBX.Mathemancy.Randomness;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds Mathemancy.Randomness services.
    /// </summary>
    public static IServiceCollection AddRandomness(this IServiceCollection services, AutoInjectOptions? options = null) => services.AddAutoInjectServices(Assembly.GetExecutingAssembly(), options);
}