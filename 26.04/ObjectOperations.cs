using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._04
{
  class ObjectOperations
  {
    public static void AddProducer()
    {
      Manufacturer newManufacturer = new Manufacturer()
      {
        Name = SetInformation.SetName()
      };

      using (var context = new StockContext())
      {
        context.Manufacturers.Add(newManufacturer);
        context.SaveChanges();
      }
    }

    public static void AddProduct()
    {
      string name = SetInformation.SetName();
      double price = SetInformation.SetPrice();
      int amount = SetInformation.SetAmount();
      Guid producerId = SetInformation.SetManufacturerId();

      Product newProduct = new Product()
      {
        Name = name,
        Price = price,
        Quantity = amount,
        ManufacturerId = producerId
      };

      using (var context = new StockContext())
      {
        context.Products.Add(newProduct);
        context.SaveChanges();
      }
    }

    public static void DeleteProductById(Guid id)
    {
      using (var context = new StockContext())
      {
        var findedProduct = context.Products.Find(id);
        context.Products.Remove(findedProduct);
      }
    }

    public static void EditProduct(Product product)
    {
      switch (Menu.ChooseColumn())
      {
        case Column.Name:
          product.Name = SetInformation.SetName();
          break;
        case Column.Price:
          product.Price = SetInformation.SetPrice();
          break;
        case Column.Quantity:
          product.Quantity = SetInformation.SetAmount();
          break;
        case Column.ManufacturerId:
          product.ManufacturerId = SetInformation.SetManufacturerId();
          break;
      }

      using (var context = new StockContext())
      {
        var changeProduct = context.Products.Find(product.Id);
        context.Products.Remove(changeProduct);
        context.Products.Add(product);
        context.SaveChanges();
      }
    }
  }
}
