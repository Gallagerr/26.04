using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._04
{
  internal class SetInformation
  {
    public static string SetName()
    {
      do
      {
        try
        {
          Console.WriteLine("Enter the name:");

          string name = Console.ReadLine().Trim();

          for (int i = 0; i < name.Length; i++)
          {
            if (!(name[i] >= 'a' && name[i] <= 'z') && !(name[i] >= 'A' && name[i] <= 'Z'))
            {
              throw new ArgumentException("Invalid name entered");
            }
          }

          return name;
        }
        catch (ArgumentException exception)
        {
          Console.WriteLine(exception.Message);
        }
      } while (true);
    }

    public static double SetPrice()
    {
      do
      {
        try
        {
          Console.WriteLine("Enter the price:");

          double price;

          if (double.TryParse(Console.ReadLine().Trim(), out price) && price >= 0)
          {
            return price;
          }

          throw new ArgumentException("Invalid price entered");
        }
        catch (ArgumentException exception)
        {
          Console.WriteLine(exception.Message);
        }
      } while (true);
    }

    public static int SetAmount()
    {
      do
      {
        try
        {
          Console.WriteLine("Enter the count:");

          int amount;

          if (int.TryParse(Console.ReadLine().Trim(), out amount) && amount >= 0)
          {
            return amount;
          }

          throw new ArgumentException("Invalid count entered");
        }
        catch (ArgumentException exception)
        {
          Console.WriteLine(exception.Message);
        }
      } while (true);
    }

    public static Guid SetManufacturerId()
    {
      do
      {
        try
        {
          using (var context = new StockContext())
          {
            var producers = context.Manufacturers.ToList();

            if (producers != null)
            {
              Console.WriteLine("Choose a manufacturer: ");
              for (int i = 0; i < producers.Count; i++)
              {
                Console.WriteLine($"{i + 1}) {producers[i].Name}");
              }

              int ManufacturerIndex;

              if (int.TryParse(Console.ReadLine().Trim(), out ManufacturerIndex) && (ManufacturerIndex > 0 && ManufacturerIndex <= producers.Count))
              {
                return producers[ManufacturerIndex - 1].Id;
              }

              throw new ArgumentException("No such manufacturer");
            }

            throw new ArgumentNullException("There is no manufacturer, add at least one");
          }
        }
        catch (ArgumentException exception)
        {
          Console.WriteLine(exception.Message);
        }
      } while (true);
    }
  }
}
