using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
[RequireComponent(typeof(Rigidbody2D))]
public class BulletImpact : BulletAbstract
{
    [Header("Bullet Impact")]
    [SerializeField]
    protected CircleCollider2D circleCollider2D;

    [SerializeField]
    protected Rigidbody2D _rigidbody2D;

    protected override void Reset()
    {
        base.Reset();

        this.LoadCollider();
        this.LoadRigidbody();
    }

    protected virtual void LoadCollider()
    {
        if (circleCollider2D != null)
        {
            return;
        }

        circleCollider2D = GetComponent<CircleCollider2D>();
        circleCollider2D.isTrigger = true;
        circleCollider2D.radius = 0.05f;
    }

    protected virtual void LoadRigidbody()
    {
        if (_rigidbody2D != null)
        {
            return;
        }

        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.isKinematic = true;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        this.bulletController.BulletDamageSender.Send(other.transform);
    }
}
