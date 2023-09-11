using UnityEngine;

public class JunkFly : ObjectFly, IReset
{
    public void Reset()
    {
        this.moveSpeed = 0.5f;
    }

    private void OnEnable()
    {
        this.GetFlyDirection();
    }

    protected virtual void GetFlyDirection()
    {
        Vector3 cameraPosition = Singleton<GameController>.Instance.MainCamera.transform.position;
        Vector3 objectPosition = transform.parent.position;

        cameraPosition.x += Random.Range(-7, 7);
        cameraPosition.y += Random.Range(-7, 7);

        Vector3 direction = cameraPosition - objectPosition;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.parent.rotation = Quaternion.Euler(0, 0, angle - 90);
    }
}
