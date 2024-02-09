using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleController : MonoBehaviour
{
    public Grid grid;
    private float xIn, yIn;
    private Rigidbody2D rb;
    public float moveSpeed = 1f, rotationSpeed = 1f;

    private void Awake() 
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() 
    {
        xIn = Input.GetAxis("Horizontal");
        yIn = Input.GetAxis("Vertical");
    }

    private void FixedUpdate() 
    {
        if(yIn > 0)
        {
            rb.MovePosition(transform.position + yIn * moveSpeed * Time.fixedDeltaTime * transform.up);
        }
        rb.MoveRotation(rb.rotation + xIn * rotationSpeed * -1);
    }
}
