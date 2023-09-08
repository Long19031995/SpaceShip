using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    protected Vector3 targetPos;

    [SerializeField]
    protected float moveSpeed;

    [SerializeField]
    protected float turningSpeed;

    private void FixedUpdate()
    {
        this.GetTargetPos();
        this.LookToTarget();
        this.Moving();
    }

    protected virtual void GetTargetPos()
    {
        this.targetPos = InputController.Instance.MousePos;
        this.targetPos.z = 0;
    }

    protected virtual void Moving()
    {
        Vector3 newPos = Vector3.Lerp(transform.parent.position, targetPos, this.moveSpeed);
        transform.parent.position = newPos;
    }

    protected virtual void LookToTarget()
    {
        Vector3 direction = targetPos - transform.parent.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.Euler(0, 0, angle - 90);
        transform.parent.rotation = Quaternion.RotateTowards(transform.parent.rotation, rotation, this.turningSpeed);
    }
}
