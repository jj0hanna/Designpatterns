using System;
using drinkObjects;
using UnityEditor;
using UnityEngine;
using System.Linq;

namespace Player
{
    public class Playerscript2 : MonoBehaviour
    {
        private static int currenthealth = 100;
        private static int maxHealth = 200;
        private static Playerscript2 player;
        private static GameObject prefabPlayer;

        public InventoryObject inventory;
        public static event Action<int> updateHealth;
        

        private static Playerscript2 _Instance;


        private void Awake()
        {
            if (_Instance != null)
            {
                Destroy(this.gameObject);
            }
            else
            {
                _Instance = this;
            }
        }

        private void Start()
        {
            updateHealth?.Invoke(currenthealth);
        }

        private void OnDestroy()
        {
            if (_Instance == this)
            {
                _Instance = null;
            }
        }

        public static Playerscript2 GetInstance
        {
            get
            {
                if (_Instance == null)
                {
                    var obj = new GameObject().AddComponent<Playerscript2>();
                    _Instance = obj.GetComponent<Playerscript2>();
                }

                return _Instance;
            }
        }

        public int getMaxHP()
      {
          return maxHealth;
      }

      public int getHP()
      {
          return currenthealth;
      }

      public void addHP(int hp)
      {
          currenthealth += hp;
          updateHealth?.Invoke(currenthealth);
      }
      
      public void OnTriggerEnter(Collider other) // if collide with a item
      {
          if (other.CompareTag("HealthPotion"))
          {
              inventory.AddItem(ItemType.HealthPotion,1);
              Destroy(other.gameObject);
          }
          if (other.CompareTag("Weapon"))
          {
              if (!inventory.Contains(ItemType.Weapon, out ItemType item))
              {
                  inventory.AddItem(ItemType.Weapon,1);
                  Destroy(other.gameObject);
              }
             // if (inventory.Container.Count(x => x.item == ItemType.Weapon) == 0) // if i would use linq
             // {
             //     Debug.Log(!inventory.Contains(ItemType.Weapon, out ItemType item1));
             //     inventory.AddItem(ItemType.Weapon,1);
             //     Destroy(other.gameObject);
             // }
             
          }
          if (other.CompareTag("Coin"))
          {
              inventory.AddItem(ItemType.Coins,1);
              Destroy(other.gameObject);
          }
      }

      private void OnApplicationQuit()
      {
          inventory.Container.Clear();
      }
    }
}
