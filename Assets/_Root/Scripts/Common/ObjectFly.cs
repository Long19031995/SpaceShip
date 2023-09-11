using UnityEngine;

public class ObjectFly : MonoBehaviour
{
    [SerializeField]
    protected float moveSpeed = 1;

    [SerializeField]
    protected Vector3 direction = Vector3.up;

    private void FixedUpdate()
    {
        transform.parent.Translate(this.direction * this.moveSpeed * Time.fixedDeltaTime);
    }
}
