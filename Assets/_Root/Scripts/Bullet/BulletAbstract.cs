using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAbstract : MonoBehaviour
{
    [Header("Bullet Abstract")]
    [SerializeField]
    protected BulletController bulletController;
    public BulletController BulletController => bulletController;

    protected virtual void Reset()
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
}
