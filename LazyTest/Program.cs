using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyTest
{
  class Program
  {
    public class Table
    {
      public  static readonly Lazy<Table> PreInstance = new Lazy<Table>(() => new Table());

      public static Table GetInstance => PreInstance.Value;
      public int superficie { get; set; }
    }

    static void Main(string[] args)
    {
      Console.WriteLine($"IsTableCreated : {Table.PreInstance.IsValueCreated}{Environment.NewLine}");

      var table = Table.GetInstance;

      Console.WriteLine($"IsTableCreated : {Table.PreInstance.IsValueCreated}{Environment.NewLine}");
      Console.ReadLine();
    }
  }
}
