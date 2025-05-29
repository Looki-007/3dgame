using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyBehindCamera : MonoBehaviour
{
    public UnityEvent OnDestroyed;
    

    void Update()
    {
        Vector3 camPos = Camera.main.transform.position;

        float difference = camPos.z - transform.position.z;

        if ( difference > 10)
        {
            OnDestroyed?.Invoke();
            Destroy(gameObject);
        }
    }
}
