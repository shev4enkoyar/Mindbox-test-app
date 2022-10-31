namespace Mindbox.FiguresArea.Primitives;

public class Circle : Figure
{
    #region Properties

    /// <summary>
    /// Circle radius
    /// </summary>
    public double Radius { get; }

    #endregion

    /// <summary>
    /// Circle figure
    /// </summary>
    /// <param name="radius">Circle radius</param>
    /// <exception cref="ArgumentException">If the radius of the circle is negative or zero</exception>
    public Circle(double radius)
    {
        if (!AllSidesGreaterZero(radius))
            throw new ArgumentException("Radius cannot be negative or zero");
        Radius = radius;
    }

    #region Methods

    /// <summary>
    /// Method for getting the area of a circle
    /// </summary>
    /// <returns>Area of a circle</returns>
    public sealed override double GetArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }

    #endregion

}