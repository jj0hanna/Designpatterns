using System;
using System.Collections;
using System.Collections.Generic;
using Player;
using UnityEngine;
[CreateAssetMenu(fileName = "new Default Potion", menuName = "Inventory System/Items/Potion")]
public abstract class PotionObject : ItemObject
{

    private void Awake()
    {
        type = ItemType.HealthPotion;
    }

    public abstract void Drink(Playerscript2 playerscipt);
}
