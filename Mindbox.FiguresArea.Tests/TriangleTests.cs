using Mindbox.FiguresArea.Primitives;

namespace Mindbox.FiguresArea.Tests;

public class TriangleTests
{
    [Fact]
    public void NegativeSide_ExpextException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(-1, 4, 4));
    }

    [Fact]
    public void NegativeAllSides_ExpextException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(-1, -2, -4));
    }

    [Fact]
    public void ZeroSide_ExpextException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(2, 0, 4));
    }

    [Fact]
    public void ZeroAllSides_ExpextException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(0, 0, 0));
    }

    [Fact]
    public void TriangleNotValid_ExpextException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 7, 5));
    }

    [Fact]
    public void Sides2_3_4_ExpectAreaAround3()
    {
        Triangle triangle = new(2, 3, 4);

        Assert.Equal(2.9047375096555625, triangle.GetArea());
    }

    [Fact]
    public void IsNotRightTriangle_ExpectFalse()
    {
        Triangle triangle = new(2, 3, 4);
        Assert.False(triangle.IsRightTriangle());
    }

    [Fact]
    public void IsRightTriangle_ExpectTrue()
    {
        Triangle triangle = new(2, 3, 3.606);
        Assert.True(triangle.IsRightTriangle());
    }

    [Fact]
    public void RightArea_ExpectAreaAround3()
    {
        Triangle triangle = new(2, 3, 3.606);

        Assert.Equal(3, triangle.GetArea());
    }
}
