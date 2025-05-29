using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinsGroup;
    public Transform spawnPoint;

    public void Start()
    {
        Spawn();
    }
    public void Spawn()
    {
        Instantiate(coinsGroup,spawnPoint.position, Quaternion.identity, transform);

    }
}
