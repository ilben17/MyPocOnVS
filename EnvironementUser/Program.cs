using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvironementUser
{
  class Program
  {
    static void Main(string[] args)
    {
      var user = Environment.UserName;
      Console.WriteLine(user);
      Console.ReadLine();
    }
  }
}
