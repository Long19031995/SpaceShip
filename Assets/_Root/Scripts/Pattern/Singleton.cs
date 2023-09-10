using System;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> where T : ISingleton
{
    private static readonly Dictionary<Type, object> dictionary = new();

    public static T Instance
    {
        get
        {
            if (!dictionary.ContainsKey(typeof(T)))
            {
                Debug.Log("Has not " + typeof(T));
                return default;
            }

            return (T)dictionary[typeof(T)];
        }
        set
        {
            if (dictionary.ContainsKey(typeof(T)))
            {
                Debug.Log("Only 1 " + typeof(T));
            }
            dictionary[typeof(T)] = value;
        }
    }
}
