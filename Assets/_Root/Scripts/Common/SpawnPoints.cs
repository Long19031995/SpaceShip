using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpawnPoints : MonoBehaviour, IReset
{
    [SerializeField]
    protected List<Transform> points = new List<Transform>();

    public void Reset()
    {
        this.LoadPoints();
    }

    protected virtual void LoadPoints()
    {
        if (this.points.Count > 0)
        {
            return;
        }

        foreach (Transform point in transform)
        {
            this.points.Add(point);
        }
    }

    public virtual Transform GetRandom()
    {
        if (this.points.Count == 0)
        {
            return null;
        }
        int random = Random.Range(0, this.points.Count);
        return this.points[random];
    }
}
