using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstaclePrefabs;
    [SerializeField] private float spawnTime = 1;
    private float timer = 0;

    private void Update()
    {
        if (timer > spawnTime)
        {
            int rand = Random.Range(0, obstaclePrefabs.Length);

            GameObject obs = Instantiate(obstaclePrefabs[rand]);
            obs.transform.position = transform.position; //+ new Vector3(0, 0, 0)
            Destroy(obs, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }

}
