using UnityEngine;

public class DespawnByDistance : Despawn, IReset
{
    [SerializeField]
    protected float limit = 70f;

    [SerializeField]
    protected float distance = 0f;

    [SerializeField]
    protected Camera mainCamera;

    public void Reset()
    {
        this.LoadComponents();
    }

    protected virtual void LoadComponents()
    {
        this.LoadCamera();
    }

    protected virtual void LoadCamera()
    {
        if (this.mainCamera != null) return;
        this.mainCamera = Transform.FindObjectOfType<Camera>() as Camera;
    }

    protected override bool CanDespawn()
    {
        this.distance = Vector3.Distance(transform.position, this.mainCamera.transform.position);
        if (this.distance > this.limit)
        {
            return true;
        }

        return false;
    }
}
