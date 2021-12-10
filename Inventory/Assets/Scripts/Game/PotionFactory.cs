using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class PotionFactory : MonoBehaviour
{
    [SerializeField] private Transform[] spawnObjectPrefabs;
    [SerializeField] private float yForce = 100f;
    [SerializeField] private float xForce = 50f;
    [SerializeField] private float zForce = 50f;
    private Transform CreateObject()
    {
        Transform obj = spawnObjectPrefabs[Random.Range(0, spawnObjectPrefabs.Length)];
        
        return Instantiate(obj, transform);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Player"))
        {
            CreateObject().GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-xForce, xForce),yForce,Random.Range(-zForce, zForce)));
        }
    }
}
