using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRotate : JunkAbstract
{
    [SerializeField]
    protected float speed = 9f;

    private void FixedUpdate()
    {
        this.Rotating();
    }

    protected virtual void Rotating()
    {
        Vector3 angle = Vector3.forward;
        this.junkController.Model.Rotate(angle * this.speed * Time.fixedDeltaTime);
    }
}
