using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour, ISingleton, IReset
{
    [SerializeField]
    protected Camera mainCamera;
    public Camera MainCamera => mainCamera;

    private void Awake()
    {
        this.SetSingleton();
    }

    public void SetSingleton()
    {
        Singleton<GameController>.Instance = this;
    }

    public void Reset()
    {
        this.LoadCamera();
    }

    protected virtual void LoadCamera()
    {
        if (this.mainCamera != null)
        {
            return;
        }

        this.mainCamera = FindObjectOfType<Camera>();
    }
}
