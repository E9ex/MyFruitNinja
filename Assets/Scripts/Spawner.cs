using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    private Collider spawnArea;
    public GameObject[] FruitPreFabs;
    public float MinSpawnDelay = 0.25f;
    public float MaxSpawnDelay = 1f;
    public float minangle = -15f;
    public float maxangle = 15f;
    public float minforce = 18f;

    public float maxforce = 22f;

    public float maxLifetime = 5f;
    
    

    private void Awake()
    {
        spawnArea = GetComponent<Collider>();
    }

    private void OnEnable()
    {
        //StartCoroutine(Spawn());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

   /* private IEnumerator Spawn()
    {
        //32.
    }*/
}
