using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkController : MonoBehaviour, IReset
{
    [SerializeField]
    protected Transform model;
    public Transform Model => model;

    [SerializeField]
    protected JunkDespawn junkDespawn;
    public JunkDespawn JunkDespawn => junkDespawn;

    public void Reset()
    {
        this.LoadModel();
        this.LoadJunkDespawn();
    }

    protected virtual void LoadModel()
    {
        if (this.model != null)
        {
            return;
        }
        this.model = transform.Find("Model");
    }

    protected virtual void LoadJunkDespawn()
    {
        if (this.junkDespawn != null)
        {
            return;
        }
        this.junkDespawn = GetComponentInChildren<JunkDespawn>();
    }
}
