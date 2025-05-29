using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudGenerator : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject[] cloud;

    public void Start()
    {
        CloudGenerators();
    }

    public void CloudGenerators()
    {
        int rand = Random.Range(0, cloud.Length);
        Instantiate(cloud[rand], spawnPoint.position, Quaternion.identity, transform);

    }
}
