using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGeneretor : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject[] coins;

    public void Start()
    {
        CoinGenerator();
    }

    public void CoinGenerator()
    {
            int rand = Random.Range(0, coins.Length);
            Instantiate(coins[rand], spawnPoint.position, Quaternion.identity, transform);

    }


}
