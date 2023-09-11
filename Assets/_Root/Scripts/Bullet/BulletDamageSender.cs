using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamageSender : DamageSender
{
    [SerializeField] protected BulletController bulletController;

    private void Reset()
    {
        this.LoadBulletController();
    }

    protected virtual void LoadBulletController()
    {
        if (this.bulletController != null)
        {
            return;
        }

        this.bulletController = transform.parent.GetComponent<BulletController>();
    }

    public override void Send(DamageReceiver damageReceiver)
    {
        base.Send(damageReceiver);
        this.DestroyObject();
    }

    protected override void DestroyObject()
    {
        this.bulletController.BulletDespawn.DespawnObject();
    }
}
