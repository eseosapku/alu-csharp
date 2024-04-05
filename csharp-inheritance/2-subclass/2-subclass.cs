using System;

public class Obj
{
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        return derivedType != baseType && baseType.IsAssignableFrom(derivedType);
    }
}
