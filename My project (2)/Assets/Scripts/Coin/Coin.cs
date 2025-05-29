using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


    public class Coin : MonoBehaviour
    {

    public void OnTriggerEnter(Collider other)
        {
            CoinTaker taker = other.GetComponent<CoinTaker>();
        

            if (taker != null)
            {
            taker.Take();
            Destroy(gameObject);

            }
        }
    }

