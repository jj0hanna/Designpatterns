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
       [SerializeField] private float rotSpeed = 1;
        
        private float rot = 0f;
        private Vector2 dir = new Vector2();
        private Rigidbody body;
        
        public InventoryObject inventory;
        void Start()
        {
        
        }

        private void Awake()
        {
            body = gameObject.GetComponent<Rigidbody>();
        }
        
        void Update()
        {
        
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

        private void Rotate()
        {
            
        }

        private void FixedUpdate()
        {
            Move();
            //Rotate();
        }

        private void OnMove(InputValue input)
        {
            dir = input.Get<Vector2>();
        }

        private void OnDrinkPotion(InputValue input)// (1)
        {
            if (inventory.Contains(ItemType.HealthPotion ,out ItemType item ))
            {
                HealthPotion Object = ScriptableObject.CreateInstance<HealthPotion>();
              //  Playerscript2.addHP();
               Object.Drink(GetComponent<Playerscript2>());
              
              
              inventory.RemoveItem(ItemType.HealthPotion, 1);
            }
            
            
           
            
          // ref int healtPotions = ref HealthPotion.healthpotions; // refferensen av. minnesplatsen av det jag vill ha. Kolla upp mer
          // if (healtPotions > 0)
          // {
          //     Playerscript2.addHP(HealthPotion.hp);
          //     healtPotions--;
          // }
          // else if (healtPotions <= 0)
          // {
          //     Debug.Log("you dont have any potions sorii");
          // }
            
        }

    }
}
