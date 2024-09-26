namespace Mathemancy.Collisions.Tests;

[TestClass]
public sealed class BoxColliderTests : RecordTester<BoxCollider>
{
    [TestMethod]
    public void Ensure_IsJsonSerializable() => Ensure.IsJsonSerializable<BoxCollider>(Dummy, JsonSerializerOptions);
}