using System;
using UnityEngine;

namespace Player
{
    public class Playerscript2 : MonoBehaviour
    {
        [SerializeField] private GameObject OrgprefabPlayer;
        private static float currenthealth;
        private static Playerscript2 player;
        private static GameObject prefabPlayer;
        
        
      static Playerscript2()
      {
          currenthealth = 100;
      }
      

      public static Playerscript2 getInstance()
      {
       //  if (player == null)
       //  {
       //      player = ((GameObject) Instantiate(Resources.Load("Player"))).GetComponent<Playerscript2>();
       //  }

         return player;

      }

      public static float getHP()
      {
          return currenthealth;
      }

      public static void addHP(float hp)
      {
          currenthealth += hp;
      }

      private void Awake()
      {
          prefabPlayer = OrgprefabPlayer;
      }
    }
}
