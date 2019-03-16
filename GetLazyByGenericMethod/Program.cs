using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetLazyByGenericMethod
{
  class Program
  {
    public class Table
    {
      public override string ToString()
      {
        return $"I am table";
      }
    }

    public class Chaise
    {
      public override string ToString()
      {
        return $"I am chair";
      }
    }

    public static Lazy<T> GetLazy<T>() where T : new()
    {
      return new Lazy<T>(() => new T());
    }

    static void Main(string[] args)
    {
      var instanceTable = GetLazy<Table>().Value;

      Console.WriteLine(instanceTable.ToString());
      Console.ReadLine();

    }
  }
}
