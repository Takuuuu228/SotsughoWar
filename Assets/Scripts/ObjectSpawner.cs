using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;  // 生成するオブジェクトのプレハブ
    public GameObject goalObject;        // ゴールオブジェクトのプレハブ
    public int numberOfInstances;   // 生成する合計オブジェクト数
    public float minZ = -1.5f;
    public float maxZ = 1.5f;
    public float startX = 5f;
    public float endX;  // A地点のX座標

    void Start()
    {
        SpawnObjects();
        SpawnGoal();
    }

    void SpawnObjects()
    {
        for(int i = 0; i < objectsToSpawn.Length; i++)
        {
            for (int j = 0; j < numberOfInstances; j++)
            {
                GameObject obj = objectsToSpawn[i];
                float randomZ = Random.Range(minZ, maxZ);
                float randomX = Random.Range(startX, endX);
                Vector3 spawnPosition = new Vector3(randomX, obj.transform.position.y, randomZ);
                Instantiate(objectsToSpawn[i], spawnPosition, objectsToSpawn[i].transform.rotation);
            }
        }

    }

    void SpawnGoal()
    {
        Vector3 goalPosition = new Vector3(endX, 0, 0);
        Instantiate(goalObject, goalPosition, Quaternion.identity);
    }
}

