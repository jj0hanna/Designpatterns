using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "new Default Potion", menuName = "Inventory System/Items/Potion")]
public class PotionObject : ItemObject
{
    public int restoreHealthValue;
    private void Awake()
    {
        type = ItemType.HealthPotion;
    }
}
