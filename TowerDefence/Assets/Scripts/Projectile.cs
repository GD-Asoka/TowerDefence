using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rb;
    public Transform target;
    private Vector3 targetPosition;
    public float projectileSpeed, range;
    public int damage = 1;
    

    private void Awake()
    {
        //transform.parent = null;
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        //targetPosition = target.position;
    }

    private void FixedUpdate()
    {
        Shoot();
    }

    public void Shoot()
    {
        rb.MovePosition(transform.position + (transform.position - targetPosition).normalized * projectileSpeed * Time.fixedDeltaTime);
    }
}
