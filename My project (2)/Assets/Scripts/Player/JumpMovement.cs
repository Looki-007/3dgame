using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class JumpMovement : MonoBehaviour
{
    public float speed;
    private Rigidbody _rb;
    public LayerMask groundLayer;
    public float maxDistance;
    public UnityEvent OnDetectWall;
    public bool isGrounded;
    public int jump;


    public void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }
    public bool IsGrounded()
    {
        
        return Physics.Raycast(transform.position, Vector3.down, maxDistance, groundLayer);
    }
    private void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * maxDistance);

        Jump();
    }
    public void Jump()
    {
        Vector3 newVelocity = _rb.velocity;


        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            _rb.velocity = new Vector3(speed, 5f, 0f);
            jump++;
        }
    }
}
