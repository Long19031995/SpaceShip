public class JunkDespawn : DespawnByDistance
{
    protected override void DespawnObject()
    {
        Singleton<BulletSpawner>.Instance.Despawn(transform.parent);
    }
}
