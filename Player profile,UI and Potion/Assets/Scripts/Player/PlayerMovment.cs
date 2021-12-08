using System;
using System.ComponentModel;
using drinkObjects;
using UnityEngine;
using UnityEngine.InputSystem;

namespace Player
{
    public class PlayerMovment : MonoBehaviour
    {
       [SerializeField] private float movmentSpeed = 1;
       
        private Vector2 dir = new Vector2();
        private Rigidbody body;
        
        public InventoryObject inventory;
        
        private void Awake()
        {
            body = gameObject.GetComponent<Rigidbody>();
        }
       
        private void Move()
        {
            Vector3 velocity = new Vector3();

            if (dir.x != 0)
                velocity += transform.right.normalized * dir.x * movmentSpeed;
            if (dir.y != 0)
                velocity += transform.forward.normalized * dir.y * movmentSpeed;
            
            body.velocity = velocity;
        }
        private void FixedUpdate()
        {
            Move();
        }

        private void OnMove(InputValue input)
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
}
