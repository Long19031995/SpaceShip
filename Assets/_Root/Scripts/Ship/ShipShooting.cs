using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    protected bool isShooting => Singleton<InputController>.Instance.OnFiring == 1;

    [SerializeField]
    protected float shootDelay;

    [SerializeField]
    protected float shootTimer;

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

        this.shootTimer += Time.fixedDeltaTime;
        if (this.shootTimer < this.shootDelay)
        {
            return;
        }
        this.shootTimer = 0;

        Vector3 spawnPos = transform.parent.position;
        Quaternion rotation = transform.parent.rotation;
        Transform newBullet = Singleton<BulletSpawner>.Instance.Spawn(BulletSpawner.BulletOne, spawnPos, rotation);
        newBullet.gameObject.SetActive(true);
    }
}
