//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

using System;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine(CalculateTriangleSurfaceBySideAndAltitude(3,5));
        Console.WriteLine(CalculateTriangleSurfaceThreeSides(3,4,5));
        Console.WriteLine(CalculateTriangleSurfaceTwoSidesAndAngle(3,4,90)); 

    }
    static double CalculateTriangleSurfaceBySideAndAltitude(double sideA, double altitude)
    {
        double triangleSurface = (sideA + altitude) / 2;
        return triangleSurface;
    }
    static double CalculateTriangleSurfaceThreeSides(double sideA, double sideB, double sideC)
    {
        double halfPerimeter = (sideA + sideB + sideC) / 2;
        double triangleSurface = (Math.Sqrt((halfPerimeter)*(halfPerimeter-sideA)*(halfPerimeter-sideB)*(halfPerimeter-sideC)));
        return triangleSurface;
    }
    static double CalculateTriangleSurfaceTwoSidesAndAngle(double sideA, double sideB, double angle)
    {
        double triangleSurface = (sideA*sideB*Math.Sin(angle*Math.PI/180))/2; //angle is converted in radians
        return triangleSurface;
    }
}


