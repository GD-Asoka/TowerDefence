using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleController : MonoBehaviour, IDamagable
{
    public Grid grid;
    private float xIn, yIn;
    private Rigidbody2D rb;
    public float moveSpeed = 1f, rotationSpeed = 1f;
    WeaknessCalculator wc = new WeaknessCalculator();

    public int health = 100;

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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Projectile"))
            TakeDamage(collision.gameObject.GetComponent<Projectile>().damage);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
    }
}
