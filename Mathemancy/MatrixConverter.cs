namespace ToolBX.Mathemancy;

public interface IMatrixConverter
{
    Matrix<float> ToBillboard(Vector3<float> objectPosition, Vector3<float> cameraPosition, Vector3<float> cameraUpVector, Vector3<float>? cameraForwardVector);
}

[AutoInject]
public class MatrixConverter : IMatrixConverter
{
    public Matrix<float> ToBillboard(Vector3<float> objectPosition, Vector3<float> cameraPosition, Vector3<float> cameraUpVector, Vector3<float>? cameraForwardVector)
    {
        var vector = new Vector3<float>(objectPosition.X - cameraPosition.X, objectPosition.Y - cameraPosition.Y, objectPosition.Z - cameraPosition.Z);
        var lengthSquared = vector.LengthSquared();
        if (lengthSquared < 0.0001f)
        {
            vector = cameraForwardVector.HasValue ? -cameraForwardVector.Value : Vector3<float>.Forward;
        }
        else
        {
            vector *= 1f / (float)Math.Sqrt(lengthSquared);
        }

        var vector3 = cameraUpVector.Cross(vector).Normalize();
        var vector2 = vector.Cross(vector3);

        return new Matrix<float>
        {
            M11 = vector3.X,
            M12 = vector3.Y,
            M13 = vector3.Z,
            M14 = 0,
            M21 = vector2.X,
            M22 = vector2.Y,
            M23 = vector2.Z,
            M24 = 0,
            M31 = vector.X,
            M32 = vector.Y,
            M33 = vector.Z,
            M34 = 0,
            M41 = objectPosition.X,
            M42 = objectPosition.Y,
            M43 = objectPosition.Z,
            M44 = 1
        };
    }
}