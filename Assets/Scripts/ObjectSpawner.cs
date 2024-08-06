using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objectsToSpawn;  // ��������I�u�W�F�N�g�̃v���n�u
    public GameObject goalObject;        // �S�[���I�u�W�F�N�g�̃v���n�u
    public int numberOfInstances;   // �������鍇�v�I�u�W�F�N�g��
    public float minZ = -1.5f;
    public float maxZ = 1.5f;
    public float startX = 5f;
    public float endX;  // A�n�_��X���W

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

