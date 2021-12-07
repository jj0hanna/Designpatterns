using System;
using drinkObjects;
using UnityEditor;
using UnityEngine;
using System.Linq;

namespace Player
{
    public class Playerscript2 : MonoBehaviour
    {
        [SerializeField] private GameObject OrgprefabPlayer;
        private static int currenthealth;
        private static int maxHealth;
        private static Playerscript2 player;
        private static GameObject prefabPlayer;

        public InventoryObject inventory;
        
        
      static Playerscript2()
      {
          currenthealth = 100;
          maxHealth = 200;
      }


      public static Playerscript2 getInstance { get; } = new Playerscript2();

      
     //{
     //  // if (player == null)
     //  // {
     //  //   
     //  // }

     //   return player;

     //}
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
