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
      var myUser = Environment.UserName;
      Console.WriteLine(myUser);
      Console.ReadLine();
    }
  }
}
