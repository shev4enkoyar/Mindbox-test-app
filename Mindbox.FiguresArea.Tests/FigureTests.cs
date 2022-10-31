namespace Mindbox.FiguresArea.Tests;

public class FigureTests
{
    [Fact]
    public void AllSidesGreaterZeroAllGreater_ExpextTrue()
    {
        Assert.True(Figure.AllSidesGreaterZero(1, 2, 3, 5, 2, 1));
    }

    [Fact]
    public void AllSidesGreaterOneZero_ExpextFalse()
    {
        Assert.False(Figure.AllSidesGreaterZero(1, 2, 0, 5, 2, 1));
    }

    [Fact]
    public void AllSidesGreaterZeroOneNegative_ExpextFalse()
    {
        Assert.False(Figure.AllSidesGreaterZero(1, 2, 3, -1, 2, 1));
    }

    [Fact]
    public void AllSidesGreaterZeroAllNegative_ExpextFalse()
    {
        Assert.False(Figure.AllSidesGreaterZero(-1, -2, -3, -1, -2, -1));
    }
}
