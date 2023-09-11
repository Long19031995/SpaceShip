public class BulletDespawn : DespawnByDistance
{
    public override void DespawnObject()
    {
        Singleton<BulletSpawner>.Instance.Despawn(transform.parent);
    }
}
