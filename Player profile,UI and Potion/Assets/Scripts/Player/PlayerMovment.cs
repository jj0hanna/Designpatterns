using System;
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

        private void OnDrinkPotion(InputValue input)
        {
            //Add 10hp to currenthealth in Playerscript2
            
            HealthPotion.healthpotions -= 1; // remove one healthpotion
        }

    }
}
