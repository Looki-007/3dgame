using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace name1
{
    public class WallGenerator : MonoBehaviour
    {
        public GameObject wall1;
        public Transform spawnPoint;

        private void Start()
        {
            GenerateWalls();
        }

        private void GenerateWalls()
        {
            Instantiate(wall1, spawnPoint.position, Quaternion.identity, transform);
        }
    }
}
