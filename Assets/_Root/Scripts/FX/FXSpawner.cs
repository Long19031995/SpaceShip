public class FXSpawner : Spawner, ISingleton
{
    private static string smokeOne = "Smoke_1";
    public static string SmokeOne => smokeOne;

    private static string impactOne => "Impact_1";
    public static string ImpactOne => impactOne;

    private void Awake()
    {
        this.SetSingleton();
    }

    public void SetSingleton()
    {
        Singleton<FXSpawner>.Instance = this;
    }
}
