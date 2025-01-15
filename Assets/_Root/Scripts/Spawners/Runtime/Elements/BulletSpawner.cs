using UnityEngine;

namespace _Root.Scripts.Spawners.Runtime.Elements
{
    public class BulletSpawner : MonoBehaviour
    {
        public Transform firePoint; 
        public float speed = 10f;
        public GameObject bulletPrefab;

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(bulletPrefab, firePoint.position, transform.rotation);
            }

        }
    }

   
}
