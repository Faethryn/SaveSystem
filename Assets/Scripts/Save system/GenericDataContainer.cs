using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class GenericDataContainer <T> where T : class
{

    public T _data;

    public GenericDataContainer (T data)
    {
        _data = data;
    }
}
