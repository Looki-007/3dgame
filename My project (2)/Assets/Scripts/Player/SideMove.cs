using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideMove : MonoBehaviour
{
    public float speed;
    private Rigidbody _rb;

    public void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        float direction = Input.GetAxis("Horizontal");
        Move(direction);
    }
    private void Move(float direction)
    {
        Vector3 newVelocity = _rb.velocity;
        newVelocity.x = direction * speed;
        _rb.velocity = newVelocity;
    }
}
