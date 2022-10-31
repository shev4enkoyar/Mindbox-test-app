namespace Mindbox.FiguresArea.Primitives;

public class Triangle : Figure
{
    private readonly int numberSides = 3;

    #region Properties

    /// <summary>
    /// First side
    /// </summary>
    public double SideA { get; }
    /// <summary>
    /// Second side
    /// </summary>
    public double SideB { get; }
    /// <summary>
    /// Third side
    /// </summary>
    public double SideC { get; }

    #endregion

    #region Constructors
    /// <summary>
    /// Triangle figure
    /// </summary>
    /// <param name="sideA">First side</param>
    /// <param name="sideB">Second side</param>
    /// <param name="sideC">Third side</param>
    /// <exception cref="ArgumentException"></exception>
    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;

        CheckTriangleExistence();
    }

    /// <summary>
    /// Triangle figure
    /// </summary>
    /// <param name="sides">Sides sequence</param>
    /// <exception cref="ArgumentException"></exception>
    public Triangle(IEnumerable<double> sides)
    {
        if (!sides.Count().Equals(numberSides))
            throw new ArgumentException("Number of elements in the sequence does not match the number of sides");

        double[] sidesArr = sides.ToArray();
        SideA = sidesArr[0];
        SideB = sidesArr[1];
        SideC = sidesArr[2];

        CheckTriangleExistence();
    }
    #endregion

    #region Methods
    private void CheckTriangleExistence()
    {
        if (!AllSidesGreaterZero(SideA, SideB, SideC))
            throw new ArgumentException("Not all sides are greater than zero");

        if (!IsSidesGreaterSumSides())
            throw new ArgumentException("Triangle with given sides cannot exist");
    }

    /// <summary>
    /// Calculate the area of a triangle
    /// </summary>
    public sealed override double GetArea()
    {
        if (IsRightTriangle())
            return GetRightArea();
        return GetHeronArea();
    }

    #region Area calculate
    /// <summary>
    /// Calculate the area of a right triangle
    /// </summary>
    private double GetRightArea()
    {
        double[] sides = { SideA, SideB, SideC };
        Array.Sort(sides);
        return 0.5 * sides[0] * sides[1];
    }

    /// <summary>
    /// Calculate the area of a triangle using Heron's formula
    /// </summary>
    private double GetHeronArea()
    {
        double halfPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
    }
    #endregion
    /// <summary>
    /// The method allows you to find out if a triangle can exist
    /// </summary>
    /// <returns>True if the side is less than the sum of the other two sides, false otherwise</returns>
    public bool IsSidesGreaterSumSides()
    {
        if (SideA + SideB <= SideC || SideA + SideC <= SideB || SideB + SideC <= SideA)
            return false;
        return true;
    }

    /// <summary>
    /// The method allows you to find out if the triangle is right-angled
    /// </summary>
    /// <returns>True if the triangle is a right triangle, false otherwise</returns>
    public bool IsRightTriangle()
    {
        return Math.Round(Math.Pow(SideA, 2), 1) + Math.Round(Math.Pow(SideB, 2), 1) == Math.Round(Math.Pow(SideC, 2), 1)
            || Math.Round(Math.Pow(SideA, 2), 1) + Math.Round(Math.Pow(SideC, 2), 1) == Math.Round(Math.Pow(SideB, 2), 1)
            || Math.Round(Math.Pow(SideC, 2), 1) + Math.Round(Math.Pow(SideB, 2), 1) == Math.Round(Math.Pow(SideA, 2), 1);
    }
    #endregion
}
