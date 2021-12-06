using Player;
using UnityEngine;

namespace drinkObjects
{
    public class HealthPotion : PotionObject
    {
         public ItemObject item;
         private float addHealth = 50;
        
        //public static int healthpotions = 0;
        //public static float hp = 10f;
        
    
        void Start()
        {
        
        }

    
        void Update()
        {
        
        }
        
        public override void Drink(Playerscript2 playerscipt)
        {
            playerscipt.addHP(addHealth);
            Debug.Log(playerscipt.getHP());
        }
    }
}
