using Player;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class UIManager : MonoBehaviour
    {
        public Text uiHealth;

        void Awake()
        {
            Playerscript2.updateHealth += ShowHealth;
        }
        void ShowHealth(int updatehealth)
        {
            uiHealth.text = " Health:" + updatehealth;
        }
    }
}
