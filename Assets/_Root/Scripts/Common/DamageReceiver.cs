using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageReceiver : MonoBehaviour
{
    [SerializeField]
    protected int hp = 1;

    [SerializeField]
    protected int hpMax = 10;

    [SerializeField]
    protected bool isDead;

    private void Start()
    {
        this.Reborn();
    }

    protected virtual void Reborn()
    {
        this.hp = this.hpMax;
    }

    public virtual void Add(int deduct)
    {
        if (isDead)
        {
            return;
        }

        this.hp += deduct;
        if (this.hp > this.hpMax)
        {
            this.hp = this.hpMax;
        }
    }

    public virtual void Deduct(int deduct)
    {
        if (isDead)
        {
            return;
        }

        this.hp -= deduct;
        if (this.hp < 0)
        {
            this.hp = 0;
        }

        this.CheckIsDead();
    }

    protected virtual bool IsDead()
    {
        return this.hp <= 0;
    }

    protected virtual void CheckIsDead()
    {
        if (!this.IsDead())
        {
            return;
        }

        this.isDead = true;

        this.OnDead();
    }

    protected virtual void OnDead()
    {

    }
}
