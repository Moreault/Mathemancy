namespace ToolBX.Mathemancy.Randomness;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Adds Mathemancy.Randomness services. Only use if you're not using [AutoInject].
    /// </summary>
    public static IServiceCollection AddRandomness(this IServiceCollection services)
    {
        return services.AddSingleton<IPseudoRandomNumberGenerator, PseudoRandomNumberGenerator>()
            .AddSingleton<ISecureRandomNumberGenerator, SecureRandomNumberGenerator>();
    }
}