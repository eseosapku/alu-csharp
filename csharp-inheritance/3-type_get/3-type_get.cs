using System.Reflection;
using System;
using System.Collections.Generic;

public class Obj
{
    public static void Print(object myObj)
    {
        Type objType = myObj.GetType();

        Console.WriteLine($"{objType.Name} Properties:");
        foreach (var property in objType.GetProperties())
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine($"{objType.Name} Methods:");
        foreach (var method in objType.GetMethods().Where(m => !m.IsSpecialName))
        {
            Console.WriteLine(method.Name);
        }
    }
}
