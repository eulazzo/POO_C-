

using System.Globalization;
using System.Text;
namespace APOO
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Product prod = new Product();
      Console.Write($"Add Product Info: ");

      prod.Name = Console.ReadLine();
      prod.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      prod.Quantity = int.Parse(Console.ReadLine());
      prod.ShowProductInfo();

      Console.Write($"How much product do you want to add in stock: ");
      int addQuantity = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
      prod.AddProduct(addQuantity);
      prod.ShowProductInfo();

      Console.Write($"How much product do you want to remove in stock: ");
      int removeQuantity = int.Parse(Console.ReadLine());
      prod.RemoveProduct(removeQuantity);
      prod.ShowProductInfo();

    }

    class Product
    {
      public string Name;
      public double Price;
      public int Quantity;

      public double QuantityInStock()
      {
        return Price * Quantity;
      }

      public void AddProduct(int quantity)
      {
        Quantity += quantity;
      }

      public void RemoveProduct(int quantity)
      {
        if (Quantity > quantity)
          Quantity -= quantity;
      }

      public void ShowProductInfo()
      {
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Price: $" + Price.ToString("F2", CultureInfo.InvariantCulture));
        Console.WriteLine("Quantity: " + Quantity);
        Console.WriteLine($"Total: ${QuantityInStock().ToString("F2", CultureInfo.InvariantCulture)}\n");
      }

    }


  }
}

