namespace Mindbox.FiguresArea;

public abstract class Figure
{
    /// <summary>
    /// Method for calculating the area of a figure
    /// </summary>
    /// <returns>Figure area</returns>
    public abstract double GetArea();

    /// <summary>
    /// Methods for check all sides on positive
    /// </summary>
    /// <param name="sides">Sides sequence</param>
    /// <returns>True if all sides greater zero</returns>
    public static bool AllSidesGreaterZero(params double[] sides)
    {
        if (sides.Any(x => x <= 0))
            return false;
        return true;
    }
}