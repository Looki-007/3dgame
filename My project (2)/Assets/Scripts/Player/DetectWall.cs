using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DetectWall : MonoBehaviour
{
    public float maxDistance;
    public UnityEvent OnDetectWall;
    public LayerMask wallLayer;
    public void Start()
    {
        
    }
    void Update()
    {
        Debug.DrawRay(transform.position, transform.forward*maxDistance);
        if(Physics.Raycast(transform.position, transform.forward, maxDistance,wallLayer))
        {
            OnDetectWall?.Invoke();
        }
    }
}
