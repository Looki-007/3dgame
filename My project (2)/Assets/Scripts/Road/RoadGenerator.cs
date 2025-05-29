using name1;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    public GameObject segmentPrefabs;
    public GameObject segmentPrefabs2;

    private Vector3 spawnPos = Vector3.zero;
    private Vector3 spawnPos2 = Vector3.zero;

    private void Start()
    {
        FirstGenerate();


        spawnPos2.z -= 10;

        Instantiate(segmentPrefabs2, spawnPos2, Quaternion.identity, transform);
    }

    private void FirstGenerate()
    {
        for (int i = 0;i < 20; i++)
        {
            SpawnSegment(segmentPrefabs);
        }
        
    }

    private void SpawnSegment(GameObject segment)
    {
        GameObject newsegment = Instantiate(segment, spawnPos, Quaternion.identity, transform);

        var destroyer = newsegment.GetComponent<DestroyBehindCamera>();
        if (destroyer != null)
        {
            destroyer.OnDestroyed.AddListener(() => SpawnSegment(segmentPrefabs));
        }
        

        spawnPos.z += 10;
    }



}
