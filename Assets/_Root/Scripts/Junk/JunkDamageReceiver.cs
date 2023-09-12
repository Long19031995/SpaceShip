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
        this.OnDeadFX();
        this.junkController.JunkDespawn.DespawnObject();
    }

    protected virtual void OnDeadFX()
    {
        string fxName = this.GetOnDeadFXName();
        Vector3 position = transform.position;
        Quaternion rotation = transform.rotation;
        Transform fxOnDead = Singleton<FXSpawner>.Instance.Spawn(fxName, position, rotation);
        fxOnDead.gameObject.SetActive(true);
    }

    protected virtual string GetOnDeadFXName()
    {
        return FXSpawner.SmokeOne;
    }
}
