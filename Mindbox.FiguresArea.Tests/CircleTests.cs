using Mindbox.FiguresArea.Primitives;

namespace Mindbox.FiguresArea.Tests;

public class CircleTests
{
    [Fact]
    public void NegativeRadius_ExpextException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }

    [Fact]
    public void ZeroRadius_ExpextException()
    {
        Assert.Throws<ArgumentException>(() => new Circle(0));
    }

    [Fact]
    public void Radius5_ExpectAreaAround79()
    {
        Circle circle = new(5);

        Assert.Equal(78.53981633974483, circle.GetArea());
    }

    [Fact]
    public void RadiusWithFloat_ExpectAreaAround54()
    {
        Circle circle = new(4.145);

        Assert.Equal(53.97578192114257, circle.GetArea());
    }

    [Fact]
    public void RadiusWithPI_ExpectAreaAround31()
    {
        Circle circle = new(Math.PI);

        Assert.Equal(31.006276680299816, circle.GetArea());
    }
}
