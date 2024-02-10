using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerParent : MonoBehaviour
{
    public GameObject turret, projectile;
    public SpriteRenderer sr;
    public Rigidbody2D rb;
    public Collider2D col;
    public Transform target;
    public SO_Enemy SOenemy;
    public int level, health;
    public float range;
    public LayerMask towerLayer;

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
        projectile.GetComponent<Projectile>().projectileSpeed = SOenemy.projectileSpeed;
    }

    private void Update()
    {
        if (target)
            turret.transform.forward = (target.position - transform.position).normalized;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            target = collision.transform;
            StartCoroutine(Shoot());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        target = null;
    }

    private IEnumerator Shoot()
    {
        while(target != null)
        {
            if (!projectile.activeInHierarchy)
            {
                projectile.SetActive(true);
                projectile.GetComponent<Projectile>().target = target;
            }
            yield return null;
        }        
    }

    protected void LevelUp()
    {

    }
}
