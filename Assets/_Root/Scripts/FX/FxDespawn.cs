public class FxDespawn : DespawnByTime
{
    public override void DespawnObject()
    {
        Singleton<FXSpawner>.Instance.Despawn(transform.parent);
    }
}
