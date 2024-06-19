using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SO_Enemy : ScriptableObject
{
    public LayerMask enemyLayer, playerLayer;
    public enum TYPE
    {
        FIRE,
        GRASS,
        WATER
    }

    public TYPE type;
    public int level, health, damage, projectileSpeed;
    public GameObject level1, level2, level3;
    public Sprite fire, water, grass;
    public float range;

   // public Dictionary<>
}
