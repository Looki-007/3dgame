using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float distanse;
    public float elevation;

    private void Update()
    {
        transform.LookAt(target);
        FollowTarget();
    }
    private void FollowTarget()
    {
        Vector3 newPos = target.position;
        
        newPos.x = 0;
        newPos.y += elevation;
        newPos.z -= distanse;
        transform.position = newPos;
    }
}
