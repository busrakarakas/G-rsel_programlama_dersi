using System;

public class Hemisphere
{
    private double radius = 1.0;

    public double Radius
    {
        get
        {
            return radius;
        }
        set
        {
            if (value > 0.0 && value < 12.0)
            {
                radius = value;
            }
            else
            {
                throw new ArgumentException(
                    "Radius must be greater than 0.0 and less than 12.0");
            }
        }
    }

    // Volume of hemisphere: (2/3) * π * r³
    public double Volume
    {
        get
        {
            return (2.0 / 3.0) * Math.PI * Math.Pow(radius, 3);
        }
    }

    // Curved Surface Area: 2 * π * r²
    public double CurvedSurfaceArea
    {
        get
        {
            return 2 * Math.PI * Math.Pow(radius, 2);
        }
    }

    // Total Surface Area: 3 * π * r²
    public double TotalSurfaceArea
    {
        get
        {
            return 3 * Math.PI * Math.Pow(radius, 2);
        }
    }
}
