public class JunkDespawn : DespawnByDistance
{
    public override void DespawnObject()
    {
        Singleton<JunkSpawner>.Instance.Despawn(transform.parent);
    }
}
