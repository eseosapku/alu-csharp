using System;
using System.Collections.Generic;
using System.Reflection;

public class Obj
{
    public static void Print(object myObj)
    {
        TypeInfo typeInfo = myObj.GetType().GetTypeInfo();

        Console.WriteLine($"{typeInfo.Name} Properties:");
        foreach (PropertyInfo property in typeInfo.GetProperties())
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine($"{typeInfo.Name} Methods:");
        foreach (MethodInfo method in typeInfo.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}

public class MyDog
{
    // Declare properties as nullable if they can be assigned later
    public string Name { get; set; }
    public int Age { get; set; }
    public int Happiness { get; set; }

    public MyDog(string name, int age, int happiness)
    {
        // Assign values to properties within the constructor
        Name = name;
        Age = age;
        Happiness = happiness;
    }

    // Define other methods as needed
    public void Bark()
    {
        Console.WriteLine("Woof!");
    }
}
