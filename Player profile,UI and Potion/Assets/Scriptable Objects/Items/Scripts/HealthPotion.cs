using Player;
using UnityEngine;

namespace drinkObjects
{
    public class HealthPotion : PotionObject
    {
      
         private int addHealth = 50;
         
         void Start()
        {
        
        }

    
        void Update()
        {
        
        }
        
        public new void Drink(Playerscript2 playerscipt)
        {
            playerscipt.addHP(addHealth);
            Debug.Log(playerscipt.getHP());
        }
    }
}
