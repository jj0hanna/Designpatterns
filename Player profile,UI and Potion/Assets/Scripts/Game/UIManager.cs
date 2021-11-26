using Player;
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
           
                uiHealth.text = " Health:" + Playerscript2.getHP();
            
            //uiHealth.text = " Score:" + currenthealth.ToString();
        }
    }
}
