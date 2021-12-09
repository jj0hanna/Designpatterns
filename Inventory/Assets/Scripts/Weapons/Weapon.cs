using UnityEngine;

namespace Weapons
{
    public class Weapon : MonoBehaviour
    {
        private int bullets;
        private float bulletSpeed;
        private static Weapon weapon;
        
        private Weapon()
        {
            bullets = 10;
            bulletSpeed = 30f;
        }

        public static Weapon GetWeapon;
     
    }
}
