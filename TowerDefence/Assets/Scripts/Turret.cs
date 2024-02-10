using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public float rotationSpeed = 100f;
    public bool targetInSight;
    public float range;

    private TowerParent tp;

    private void Awake()
    {
        tp = GetComponentInParent<TowerParent>();
    }

    private void Update()
    {
        transform.RotateAround(GetComponentInParent<TowerParent>().transform.position, Vector3.forward, rotationSpeed * Time.deltaTime);
        targetInSight = Physics2D.Raycast(transform.position, transform.right, range, tp.towerLayer);
    }
}
