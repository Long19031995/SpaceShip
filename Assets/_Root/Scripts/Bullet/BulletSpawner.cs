public class BulletSpawner : Spawner, ISingleton
{
    private static string bulletOne = "Bullet_1";
    public static string BulletOne => bulletOne;

    private void Awake()
    {
        this.SetSingleton();
    }

    public void SetSingleton()
    {
        Singleton<BulletSpawner>.Instance = this;
    }
}
