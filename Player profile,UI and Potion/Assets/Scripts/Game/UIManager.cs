using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class UIManager : MonoBehaviour
    {
        public Text uiHealth;
        
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
        showHealth();
        }

        void showHealth()
        {
            
            //Player.Player.getInstance().HealthPotion();
            //uiHealth.text = " Score:" + currenthealth.ToString();
        }
    }
}
