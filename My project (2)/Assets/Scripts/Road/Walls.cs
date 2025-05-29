using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace name1
{
    public class Walls : MonoBehaviour
    {
        
        public Transform spawnPoint;
        public GameObject[] walls;

        public void Start()
        {
            WallsGenerator();
        }

        public void WallsGenerator()
        {
            int rand = Random.Range(0, walls.Length);
            Instantiate(walls[rand], spawnPoint.position, Quaternion.identity, transform);

        }
    }
}
