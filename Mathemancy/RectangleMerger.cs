namespace ToolBX.Mathemancy;

public interface IRectangleMerger
{
    /// <summary>
    /// Merges adjascent rectangles into as few rectangles as possible.
    /// </summary>
    IReadOnlyList<Rectangle<float>> Merge(IReadOnlyList<Rectangle<float>> rectangles);
}

[AutoInject(ServiceLifetime.Singleton)]
public class RectangleMerger : IRectangleMerger
{
    public IReadOnlyList<Rectangle<float>> Merge(IReadOnlyList<Rectangle<float>> rectangles)
    {
        if (rectangles == null) throw new ArgumentNullException(nameof(rectangles));

        if (rectangles.Any(x => x.Width == 0 || x.Height == 0))
            throw new ArgumentException($"Can't merge rectangles : This method does not merge rectangles with a width or height of 0 but {rectangles.Count(x => x.Width == 0 || x.Height == 0)} out of {rectangles.Count} had an invalid width or height.");

        var output = rectangles.Distinct().ToList();

        foreach (var current in output.Where(current => output.Any(x => x != current && x.Left <= current.Left && x.Right >= current.Right && x.Top <= current.Top && x.Bottom >= current.Bottom)).ToList())
            output.Remove(current);
            
        while (true)
        {
            foreach (var current in output.ToList())
            {
                if (output.Any(x => current.TopRight == x.TopLeft && current.BottomRight == x.BottomLeft))
                {
                    var other = output.Single(x => current.TopRight == x.TopLeft && current.BottomRight == x.BottomLeft);
                    var newRectangle = new Rectangle<float>(current.TopLeft, other.Right - current.Left, current.Height);

                    output.Remove(current);
                    output.Remove(other);
                    output.Add(newRectangle);
                    return Merge(output);
                }

                if (output.Any(x => x.TopRight == current.TopLeft && x.BottomRight == current.BottomLeft))
                {
                    var other = output.Single(x => x.TopRight == current.TopLeft && x.BottomRight == current.BottomLeft);
                    var newRectangle = new Rectangle<float>(other.TopLeft, current.Right - other.Left, current.Height);

                    output.Remove(current);
                    output.Remove(other);
                    output.Add(newRectangle);
                    return Merge(output);
                }

                if (output.Any(x => current.BottomLeft == x.TopLeft && current.BottomRight == x.TopRight))
                {
                    var other = output.Single(x => current.BottomLeft == x.TopLeft && current.BottomRight == x.TopRight);
                    var newRectangle = new Rectangle<float>(current.TopLeft, current.Width, other.Bottom - current.Top);

                    output.Remove(current);
                    output.Remove(other);
                    output.Add(newRectangle);
                    return Merge(output);
                }

                if (output.Any(x => x.BottomLeft == current.TopLeft && x.BottomRight == current.TopRight))
                {
                    var other = output.Single(x => x.BottomLeft == current.TopLeft && x.BottomRight == current.TopRight);
                    var newRectangle = new Rectangle<float>(other.TopLeft, current.Width, current.Bottom - other.Top);

                    output.Remove(current);
                    output.Remove(other);
                    output.Add(newRectangle);
                    return Merge(output);
                }

            }
            return output;
        }
    }
}