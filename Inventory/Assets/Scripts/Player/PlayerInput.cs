using System;
using System.Collections;
using System.Collections.Generic;
using drinkObjects;
using Player;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private Vector2 dir = new Vector2();
    public InventoryObject inventory;

    public Vector2 Dirr
    {
        get => dir;
    }

    public void OnMove(InputValue input)
    {
        dir = input.Get<Vector2>();
    }

    private void OnDrinkPotion(InputValue input)// (1)
    {
        if (inventory.Contains(ItemType.HealthPotion ,out ItemType item )
            && Playerscript2.GetInstance.getHP() < Playerscript2.GetInstance.getMaxHP())
        {
            HealthPotion Object = ScriptableObject.CreateInstance<HealthPotion>();
            Object.Drink(GetComponent<Playerscript2>());
                
            inventory.RemoveItem(ItemType.HealthPotion, 1);
        }
    }
    
}
