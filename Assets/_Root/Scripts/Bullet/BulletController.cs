using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField]
    protected BulletDamageSender bulletDamageSender;
    public BulletDamageSender BulletDamageSender => bulletDamageSender;

    [SerializeField]
    protected BulletDespawn bulletDespawn;
    public BulletDespawn BulletDespawn => bulletDespawn;

    private void Reset()
    {
        this.LoadDamageSender();
        this.LoadBulletDespawn();
    }

    protected virtual void LoadDamageSender()
    {
        if (this.bulletDamageSender != null)
        {
            return;
        }

        bulletDamageSender = GetComponentInChildren<BulletDamageSender>();
    }

    protected virtual void LoadBulletDespawn()
    {
        if (this.bulletDespawn != null)
        {
            return;
        }

        bulletDespawn = GetComponentInChildren<BulletDespawn>();
    }
}
