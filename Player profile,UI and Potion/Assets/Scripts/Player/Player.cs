using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Player
{
    public class Player : MonoBehaviour
    {
        private float maxHealth = 100f;
        private float minHealth = 0;
        private float currentHealth;
        private static Player player;
        
        public Text uiHealth;
        //private static Transform prefabPlayer;

        private Player()
        {
            currentHealth = maxHealth;
        }

        public static Player getInstance()
        {
            if (player == null)
            {
               // player = Instantiate(prefabPlayer).GetComponent<Player>();
                // player = Instantiate(new Player());
            }
           

            return player;


        }

        private void Update()
        {
            OnGUI();
        }

        void HealthPotion()
        {
            float newhealth;
            float potion = 10f;
            currentHealth = currentHealth + potion;
            newhealth = currentHealth;
            Debug.Log(currentHealth);
            
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("box"))
            {
                Debug.Log("in");
                HealthPotion();
            }
        }
        void OnGUI()
        {
            uiHealth.text = " Health:" + currentHealth;
        }
    }
    
}
