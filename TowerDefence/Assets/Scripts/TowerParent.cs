using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerParent : MonoBehaviour
{
    [SerializeField] protected GameObject turret, projectile;
    [SerializeField] protected SpriteRenderer sr;
    [SerializeField] protected Rigidbody2D rb;
    [SerializeField] protected Collider2D col;
    protected Transform target;

    private void Awake()
    {
        turret = GetComponentInChildren<Turret>().gameObject;
        projectile = GetComponentInChildren<Projectile>().gameObject;
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }

    private void Start()
    {
        projectile.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
            target = collision.transform;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        //StartCoroutine(Shoot());
    }
}
