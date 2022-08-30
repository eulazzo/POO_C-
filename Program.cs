using System.Globalization;
using System.Text;
namespace APOO
{
  class MainClass
  {
    public static void Main(string[] args)
    {

      Person person_1 = new Person();
      Person person_2 = new Person();

      Console.WriteLine("First Person Data: ");
      Console.Write("Name: ");
      person_1.Name = Console.ReadLine();
      Console.Write("Age: ");
      person_1.Age = int.Parse(Console.ReadLine());

      Console.Write("Second Person Data: ");

      Console.Write("Name: ");
      person_2.Name = Console.ReadLine();
      Console.Write("Age: ");
      person_2.Age = int.Parse(Console.ReadLine());

      if (person_1.Age > person_2.Age)
        Console.WriteLine($"Old Person: {person_1.Name}");
      else
        Console.WriteLine($"Old Person: {person_2.Name}");
    }

    class Person
    {
      public string Name;
      public int Age;

    }

  }
}
