using Mathemancy.UnitTesting;
using ToolBX.Eloquentest.Dummies;

namespace Mathemancy.Collisions.Tests;

[TestClass]
public sealed class BoxColliderTests : RecordTestBase<BoxCollider>
{
    [TestMethod]
    public void Ensure_IsJsonSerializable() => Ensure.IsJsonSerializable<BoxCollider>(Dummy, JsonSerializerOptions);
}