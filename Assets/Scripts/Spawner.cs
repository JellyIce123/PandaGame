using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject Prefabs;
    public Transform[] SpawnPoints;
    public float spawnIntervals = 3f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            SpawnThings();
            yield return new WaitForSeconds(spawnIntervals);
        }
    }

    void SpawnThings()
    {
        if (SpawnPoints.Length == 0)
        {
            Debug.Log("Add some spawn points in");
            return;
        }

        int randomspawnIndex = Random.Range(0, SpawnPoints.Length);
        Transform spawnPoint = SpawnPoints[randomspawnIndex];

        Instantiate(Prefabs, spawnPoint.position, spawnPoint.rotation);
    }
}
