/*



using System.Globalization;
using System.Text;
namespace APOO
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      double width = double.Parse(Console.ReadLine());
      double height = double.Parse(Console.ReadLine());
      Retangle ret = new Retangle(width, height);

      ret.ShowInfo();


    }

    class Retangle
    {
      private double Width { get; set; }
      private double Height { get; set; }

      public Retangle(double width, double height)
      {
        this.Width = width;
        this.Height = height;
      }

      private double Area()
      {
        return (double)(this.Width * this.Height) / 2.0;
      }

      private double Perimeter()
      {
        return (2 * this.Width) + (2 * this.Height);
      }

      private double Diagonal()
      {
        double inter = (Math.Pow(this.Width, 2)) + (Math.Pow(this.Height, 2));
        return Math.Sqrt(inter);
      }

      public void ShowInfo()
      {
        Console.WriteLine("Width: " + this.Width);
        Console.WriteLine("Height: " + this.Height);
        Console.WriteLine("Area: " + this.Area());
        Console.WriteLine("Digonal: " + this.Diagonal());
      }
    }

  }
}




*/