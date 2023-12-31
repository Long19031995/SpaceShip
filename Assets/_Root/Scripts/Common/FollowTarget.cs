using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField]
    protected Transform target;

    [SerializeField]
    protected float speed = 2f;

    private void FixedUpdate()
    {
        this.Following();
    }

    protected virtual void Following()
    {
        if (this.target == null)
        {
            return;
        }
        transform.position = Vector3.Lerp(transform.position, this.target.transform.position, this.speed * Time.fixedDeltaTime);
    }
}
