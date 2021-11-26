using UnityEngine;

namespace Player
{
    public class Playerscript2 : MonoBehaviour
    {
        private float currenthealth;
        private static Player player;
        private static GameObject prefabPlayer;
        
      private Playerscript2()
      {
          this.currenthealth = 100;
      }
      

      public static Playerscript2 getInstance()
      {
          if (player == null)
          {
              player = Instantiate(prefabPlayer).GetComponent<Player>();
          }

          return prefabPlayer.AddComponent<Playerscript2>();

      }
    }

    public class Renderer: MonoBehaviour
    {
        
    }
}
