public class JunkDespawn : DespawnByDistance
{
    public override void DespawnObject()
    {
        Singleton<BulletSpawner>.Instance.Despawn(transform.parent);
    }
}
