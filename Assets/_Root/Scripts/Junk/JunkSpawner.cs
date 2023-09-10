public class JunkSpawner : Spawner, ISingleton
{
    private static string junkOne = "Junk_1";
    public static string JunkOne => junkOne;

    private void Awake()
    {
        this.SetSingleton();
    }

    public void SetSingleton()
    {
        Singleton<JunkSpawner>.Instance = this;
    }
}
