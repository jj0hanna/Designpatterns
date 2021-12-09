using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "new Default Weapon", menuName = "Inventory System/Items/Weapon")]
public class WeaponObject : ItemObject
{
    public int bullets;
    public float loadSpeed;
    public float damage;
    public void Awake()
    {
        type = ItemType.Weapon;
    }
}
