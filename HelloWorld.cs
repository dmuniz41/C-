// See https://aka.ms/new-console-template for more information
using System;

namespace CSHelloWorld
{
  class HelloWorld
  {
    static void Main(string[] args)
    {
      // Hola Mundo
      Console.WriteLine("Hello, World!");

      string myString = "Esto es un string";
      myString = "Aqui cambia el valor de la cadena de texto";
      Console.WriteLine(myString);

      int myInt = 9;
      myInt += 10;
      Console.WriteLine(myInt);

      float myFloat = 6.5f;
      Console.WriteLine(myFloat);

      double myDouble = 6.5;
      Console.WriteLine(myDouble);

      Console.WriteLine(myDouble + myFloat + myInt);

      bool myBool = true;
      Console.WriteLine(myBool);

      var variable = "Esto es una variable";
      Console.WriteLine(variable);


      Console.WriteLine($"Este es el valor de mi entero {myInt} y este es el valor de my boleano {myBool}");

      const string MyConst = "Esta constante es un string";
      Console.WriteLine(MyConst);

      // ? Estructuras ?//

      var myArray = new string[] { "Daniel", "Daylen", "Gabi" };
      Console.WriteLine(myArray[0]);

      myArray[0] = "1";
      Console.WriteLine(myArray[0]);

      var myDictionary = new Dictionary<string, int>
      {
        {"dmuniz", 26},
        {"dmuniz2", 24},
        {"dmuniz3", 25}
      };
      Console.WriteLine(myDictionary["dmuniz"]);

      var mySet = new HashSet<string> { "Daniel", "Muniz", "Turtos" };
      Console.WriteLine(mySet.ElementAt(1));

      var myTuple = ("Daniel", "Muniz", "Turtos");
      Console.WriteLine(myTuple);

      // ? Bucles ?//

      for (int index = 0; index < 10; index++)
      {
        Console.WriteLine(index);
      }

      foreach (var myItem in myArray)
      {
        Console.WriteLine(myItem);
      }
      foreach (var myItem in myDictionary)
      {
        Console.WriteLine(myItem);
      }
      foreach (var myItem in mySet)
      {
        Console.WriteLine(myItem);
      }

      // ? Condicionales ?//

      if (myInt == 19)
      {
        Console.WriteLine("El valor es 19");
      }
      else
      {
        Console.WriteLine("El valor no es 19");
      }

      MyFunction();
      Console.WriteLine(MyFunctionWithParams(5));

      var myClass = new MyClass("Daniel");
      myClass.MyName = "Daniel Muniz";
      Console.WriteLine(myClass.MyName);

    }


    // ? Funciones ?//
    static void MyFunction()
    {
      Console.WriteLine("MyFunction");
    }
    static int MyFunctionWithParams(int param)
    {
      return 10 + param;
    }

    // class MyClass
    // {
    //   public string MyName;

    //   public MyClass(string name)
    //   {
    //     MyName = name;
    //   }
    // }
    class MyClass(string name)
    {
      public string MyName = name;
    }
  }

}