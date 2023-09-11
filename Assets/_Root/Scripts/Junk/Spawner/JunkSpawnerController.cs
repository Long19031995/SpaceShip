using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawnerController : MonoBehaviour, IReset
{
    [SerializeField]
    protected JunkSpawner junkSpawner;
    public JunkSpawner JunkSpawner => junkSpawner;

    [SerializeField]
    protected JunkSpawnPoints junkSpawnPoints;
    public JunkSpawnPoints JunkSpawnPoints => junkSpawnPoints;

    public void Reset()
    {
        this.LoadJunkController();
        this.LoadJunkSpawnPoints();
    }

    protected virtual void LoadJunkController()
    {
        if (this.junkSpawner != null)
        {
            return;
        }

        this.junkSpawner = GetComponent<JunkSpawner>();
    }

    protected virtual void LoadJunkSpawnPoints()
    {
        if (this.junkSpawnPoints != null)
        {
            return;
        }
        this.junkSpawnPoints = FindObjectOfType<JunkSpawnPoints>();
    }
}
