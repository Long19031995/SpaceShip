using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    private static T instance;
    public static T Instance => instance;

    protected virtual void Awake()
    {
        if (instance != null)
        {
            Debug.Log("Only 1 " + typeof(T));
        }

        instance = this as T;
    }
}
