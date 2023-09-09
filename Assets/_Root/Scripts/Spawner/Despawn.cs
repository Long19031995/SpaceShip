using UnityEngine;

public abstract class Despawn : MonoBehaviour
{
    private void FixedUpdate()
    {
        this.Despawning();
    }

    protected virtual void Despawning()
    {
        if (!this.CanDespawn())
        {
            return;
        }

        DespawnObject();
    }

    protected virtual void DespawnObject()
    {
        Destroy(transform.parent.gameObject);
    }

    protected abstract bool CanDespawn();
}
