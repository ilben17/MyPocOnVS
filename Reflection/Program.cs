using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
  class Program
  {
    public static object GetInstance(Type type)
    {
      var constructor = type.GetConstructors();
      var constructorOrdered = constructor.OrderByDescending(c => c.GetParameters().Length);
      var constructorFirst = constructorOrdered.First();

      var argsList = constructorFirst.GetParameters();
      var argsList2 = argsList.Select(param => GetInstance(param.ParameterType));
      var argsList2Mapped = argsList2.ToArray();

      return Activator.CreateInstance(type, argsList2Mapped);
    }
    static void Main(string[] args)
    {
      GetInstance(typeof(MyClass));
    }

    public class MyClass
    {
      public MyClass()
      {
          
      }

      public MyClass(int a, int b)
      {
          
      }

      public MyClass(int a, int b, int c)
      {
          
      }
    }
  }
}
