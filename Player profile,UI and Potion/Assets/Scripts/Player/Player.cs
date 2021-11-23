using System.Runtime.CompilerServices;
using UnityEngine;

namespace Player
{
    public class Player : MonoBehaviour
    {
        private float maxHealth = 100f;
        private float minHealth = 0;
        private float currentHealth;
        private static Player player;
        [SerializeField] public static Transform prefabPlayer;

        private Player()
        {
            currentHealth = maxHealth;
        }

        public static Player getInstance()
        {
            if (player == null)
            {
                player = Instantiate(prefabPlayer).GetComponent<Player>();
                // player = Instantiate(new Player());
            }
            return player;
        }
    }
}
