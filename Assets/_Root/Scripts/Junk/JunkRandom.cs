using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JunkRandom : MonoBehaviour, IReset
{
    [SerializeField]
    protected JunkSpawnerController junkController;

    public void Reset()
    {
        this.LoadJunkSpawner();
    }

    protected virtual void LoadJunkSpawner()
    {
        if (this.junkController != null)
        {
            return;
        }
        this.junkController = GetComponent<JunkSpawnerController>();
    }

    private void Start()
    {
        this.JunkSpawning();
    }

    protected virtual void JunkSpawning()
    {
        Transform randomPoint = this.junkController.JunkSpawnPoints.GetRandom();

        Vector3 position = randomPoint.position;
        Quaternion rotation = randomPoint.rotation;

        Transform junk = this.junkController.JunkSpawner.Spawn(JunkSpawner.JunkOne, position, rotation);
        junk.gameObject.SetActive(true);

        Invoke(nameof(this.JunkSpawning), 1f);
    }
}
