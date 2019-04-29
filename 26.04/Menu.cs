using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._04
{
  class Menu
  {
    public static Column ChooseColumn()
    {
      do
      {
        try
        {
          Console.WriteLine("Select the field you want to change.:" +
                            "1) Name\n" +
                            "2) Price\n" +
                            "3) Quantity\n" +
                            "4) ManufacturerId");

          int column;

          if (int.TryParse(Console.ReadLine().Trim(), out column) && column >= 1 && column <= 6)
          {
            return (Column)column;
          }

          throw new ArgumentException("there is no such field");
        }
        catch (ArgumentException exception)
        {
          Console.WriteLine(exception.Message);
        }
      } while (true);
    }
    public static Operation ChooseOperation()
    {
      do
      {
        try
        {
          Console.WriteLine("Select the operation you want to perform with the data: " +
                            "1) Add\n" +
                            "2) Remove\n" +
                            "3) Edit");

          int operation;

          if (int.TryParse(Console.ReadLine().Trim(), out operation) && operation >= 1 && operation <= 3)
          {
            return (Operation)operation;
          }

          throw new ArgumentException("there is no such operation");
        }
        catch (ArgumentException exception)
        {
          Console.WriteLine(exception.Message);
        }
      } while (true);
    }
    public static void ChooseWhoWillBeRemoved()
    {
      do
      {
        try
        {
        }
        catch (Exception)
        {

          throw;
        }
      } while (true);
    }
  }
}
