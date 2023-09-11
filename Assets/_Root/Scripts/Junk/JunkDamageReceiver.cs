using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkDamageReceiver : DamageReceiver
{
    [SerializeField]
    protected JunkController junkController;

    private void Reset()
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

    protected override void OnDead()
    {
        this.junkController.JunkDespawn.DespawnObject();
    }
}
