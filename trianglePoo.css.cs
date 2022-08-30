/*

using System.Globalization;
using System.Text;
namespace APOO
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Triangle triangleX = new Triangle(4.0, 5.0, 2.2);
      Triangle triangleY = new Triangle(4.90, 10.0, 9.2);

      double areaTriangleX = triangleX.TriangleArea();
      double areaTriangleY = triangleY.TriangleArea();
      Console.WriteLine($"{areaTriangleX}");
      Console.WriteLine($"{areaTriangleY}");

      Console.WriteLine(triangleX.GreaterArea(areaTriangleX, areaTriangleY));
    }

    class Triangle
    {

      private double FirstSize { get; set; }
      private double SecondSize { get; set; }
      private double ThirdSize { get; set; }

      public Triangle(double firstSize, double secondSize, double thirdSize)
      {
        FirstSize = firstSize;
        SecondSize = secondSize;
        ThirdSize = thirdSize;
      }

      public double TriangleArea()
      {
        double p = (FirstSize + SecondSize + SecondSize) / 2.0;
        double area = Math.Sqrt(p * (p - FirstSize) * (p - SecondSize) * (p - SecondSize));

        return area;
        ;
      }

      public string GreaterArea(double areaX, double areaY)
      {
        return areaX > areaY ? "Bigger Area: Triangle X" : "Bigger Area: Triangle Y ";
      }


    }
  }
}



*/