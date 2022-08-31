

using System.Globalization;
using System.Text;
namespace APOO
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Type r value: ");
      double raio = double.Parse(Console.ReadLine());

      double circle = Calculator.Circuference(raio);

      Console.WriteLine($"Circuference: {circle}");
      Console.WriteLine($"Volume: {Calculator.Volume(raio)}");
      Console.WriteLine($"PI: {Calculator.Pi}");


    }

  }
}

