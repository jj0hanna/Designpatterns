using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class PotionFactory : MonoBehaviour
{
    [SerializeField] private Transform potionPrefab;
    private Transform CreatePotion()
    {
        return Instantiate(potionPrefab, transform);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Player"))
        {
            CreatePotion().GetComponent<Rigidbody>().AddForce(new Vector3(Random.Range(-50f, 50f),100f,Random.Range(-50f, 50f)));
        }
    }
}
