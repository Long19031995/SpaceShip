using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    [SerializeField]
    protected bool isShooting;

    [SerializeField]
    protected Transform bulletPrefab;

    private void FixedUpdate()
    {
        this.Shooting();
    }

    protected virtual void Shooting()
    {
        if (!this.isShooting)
        {
            return;
        }

        Vector3 spawnPos = transform.parent.position;
        Quaternion rotation = transform.parent.rotation;
        Instantiate(this.bulletPrefab, spawnPos, rotation);
    }
}
