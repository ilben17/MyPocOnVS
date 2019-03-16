
using System;
using Newtonsoft.Json;

namespace ImpliciteOperator
{
  class Program
  {
    public class Animal 
    {
      public string Name { get; set; }
      public bool Mammal { get; set; }

      public static implicit operator Animal(Dog dog) //le nom de la methode doit être le nom du type de retour
      {
        return new Animal
        {
          Name = dog.Name,
          Mammal = false
        };
      }      
    }

    public class Dog
    {
      public string Name { get; set; }

      public static implicit operator Dog(Animal animal) 
      {
        return new Dog
        {
          Name = animal.Name,
        };
      }
    }

    static void Main(string[] args)
    {
      Animal obj = new Dog {Name = "Bruno"};

      Console.WriteLine(obj.GetType().FullName); //ImpliciteOperator.Program + Dog
      Console.WriteLine(JsonConvert.SerializeObject(obj, Formatting.Indented)); // {name : Bruno}

      Dog obj2 = new Animal { Name = "Jack" };

      Console.WriteLine(obj2.GetType().FullName); 
      Console.WriteLine(JsonConvert.SerializeObject(obj2, Formatting.Indented));

      Console.ReadLine();
    }
  }
}
