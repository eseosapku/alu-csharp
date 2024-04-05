using System;
using System.Collections.Generic;
using System.Reflection;

public class Obj
{
    public static void Print(object myObj)
    {
        Type type = myObj.GetType();

        Console.WriteLine($"{type.Name} Properties:");
        foreach (PropertyInfo property in type.GetProperties())
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine($"{type.Name} Methods:");
        foreach (MethodInfo method in type.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}
