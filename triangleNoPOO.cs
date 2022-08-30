/*
using System.Globalization;
using System.Text;
namespace APOO
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Sides of the triangle X: ");

      double xa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double xb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double xc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      Console.WriteLine("Sides of the triangle Y: ");
      double ya = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double yb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      double yc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

      double p = (xa + xb + xc) / 2.0;
      double areaX = Math.Sqrt(p * (p - xa) * (p - xb) * (p - xc));

      p = (ya + yb + yc) / 2.0;
      double areaY = Math.Sqrt(p * (p - ya) * (p - yb) * (p - yc));

      Console.WriteLine($"Area of the triangle X: {areaX:F2} ");
      Console.WriteLine($"Area of the triangle Y: {areaY:F2} ");

    }
  }
}
*/