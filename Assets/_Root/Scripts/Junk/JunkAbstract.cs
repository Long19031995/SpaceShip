using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class JunkAbstract : MonoBehaviour, IReset
{
    [SerializeField]
    protected JunkController junkController;
    public JunkController JunkController => junkController;

    public void Reset()
    {
        this.LoadJunkController();
    }

    protected virtual void LoadJunkController()
    {
        if (this.junkController != null)
        {
            return;
        }
        this.junkController = transform.parent.GetComponent<JunkController>();
    }
}
