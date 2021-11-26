using UnityEngine;

namespace drinkObjects
{
    public class HealthPotion : MonoBehaviour
    {
        public static int healthpotions = 0;
    
        void Start()
        {
        
        }

    
        void Update()
        {
        
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                healthpotions++;
                Destroy(gameObject);
                Debug.Log(healthpotions);
            }
        }
    }
}
