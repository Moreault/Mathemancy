namespace Mathemancy.Randomness.Tests;

[TestClass]
public class ServiceCollectionExtensionsTester
{
    [TestClass]
    public class AddRandomness : Tester
    {
        [TestMethod, Ignore("Throws because of keyed services")]
        public void Always_AddServices()
        {
            //Arrange
            var instance = new FakeServiceCollection();

            //Act
            instance.AddRandomness();

            //Assert
            instance.Should().BeEquivalentTo(new List<ServiceDescriptor>
            {
                new (typeof(IPseudoRandomNumberGenerator), typeof(PseudoRandomNumberGenerator), ServiceLifetime.Singleton),
                new (typeof(ISecureRandomNumberGenerator), typeof(SecureRandomNumberGenerator), ServiceLifetime.Singleton)
            });
        }
    }
}