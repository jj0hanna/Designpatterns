
using UnityEngine;


namespace Player
{
    public class PlayerMovment : MonoBehaviour
    {
       [SerializeField] private float movmentSpeed = 1;
       
        private Rigidbody body;
        
        private void Awake()
        {
            body = gameObject.GetComponent<Rigidbody>();
        }
       
        public void Move(Vector2 dir)
        {
            Vector3 velocity = new Vector3();
            
            if (dir.x != 0)
                velocity += transform.right.normalized * dir.x * movmentSpeed;
            if (dir.y != 0)
                velocity += transform.forward.normalized * dir.y * movmentSpeed;
            
            body.velocity = velocity;
        }
    }
}
