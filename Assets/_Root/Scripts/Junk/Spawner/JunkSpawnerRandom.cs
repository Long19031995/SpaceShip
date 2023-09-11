using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkSpawnerRandom : MonoBehaviour, IReset
{
    [SerializeField]
    protected JunkSpawnerController junkSpawnerController;

    [SerializeField]
    protected float randomDelay = 1f;

    [SerializeField]
    protected float randomTimer = 0f;

    [SerializeField]
    protected float randomLimit = 9f;

    public void Reset()
    {
        this.LoadJunkSpawner();
    }

    protected virtual void LoadJunkSpawner()
    {
        if (this.junkSpawnerController != null)
        {
            return;
        }
        this.junkSpawnerController = GetComponent<JunkSpawnerController>();
    }

    private void FixedUpdate()
    {
        this.JunkSpawning();
    }

    protected virtual void JunkSpawning()
    {
        if (this.RandomReachLimit())
        {
            return;
        }

        this.randomTimer += Time.fixedDeltaTime;
        if (this.randomTimer < this.randomDelay)
        {
            return;
        }
        this.randomTimer = 0;

        Transform randomPoint = this.junkSpawnerController.JunkSpawnPoints.GetRandom();

        Transform prefab = this.junkSpawnerController.JunkSpawner.RandomPrefab();
        Vector3 position = randomPoint.position;
        Quaternion rotation = randomPoint.rotation;

        Transform junk = this.junkSpawnerController.JunkSpawner.Spawn(prefab, position, rotation);
        junk.gameObject.SetActive(true);
    }

    protected virtual bool RandomReachLimit()
    {
        int currentJunk = this.junkSpawnerController.JunkSpawner.SpawnedCount;
        return currentJunk >= randomLimit;
    }
}
