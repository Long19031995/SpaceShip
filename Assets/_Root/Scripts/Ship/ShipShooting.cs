using UnityEngine;

public class ShipShooting : MonoBehaviour
{
    [SerializeField]
    protected bool isShooting => InputController.Instance.OnFiring == 1;

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
        Transform newBullet = Spawner.Instance.Spawn(spawnPos, rotation);
        newBullet.gameObject.SetActive(true);
    }
}
