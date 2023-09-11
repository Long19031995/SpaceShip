using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkController : MonoBehaviour, IReset
{
    [SerializeField]
    protected Transform model;
    public Transform Model => model;

    public void Reset()
    {
        this.LoadModel();
    }

    protected virtual void LoadModel()
    {
        if (this.model != null)
        {
            return;
        }
        this.model = transform.Find("Model");
    }
}
