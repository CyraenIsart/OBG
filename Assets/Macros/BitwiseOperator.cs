using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static public class BitwiseOperators
{
    static public object BitwiseOr(IEnumerable list, Type type)
    {
        if (!type.IsEnum)
            throw new Exception("Type is not an enum");
        int intVal = 0;
        foreach (var val in list)
        {
            if (val.GetType() != type)
                throw new Exception("List item type is not of type " + type.Name);
            intVal = intVal | (int)val;
        }
        return Enum.ToObject(type, intVal);
    }
}