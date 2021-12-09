using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;
[CreateAssetMenu(fileName = "new Default Potion", menuName = "Inventory System/Items/Potion")]
public class PotionObject : ItemObject
{

    private void Awake()
    {
        type = ItemType.HealthPotion;
    }

    public void Drink(Playerscript2 playerscipt)
    {
    }
}
