public class BulletDespawn : DespawnByDistance
{
    protected override void DespawnObject()
    {
        Singleton<BulletSpawner>.Instance.Despawn(transform.parent);
    }
}
