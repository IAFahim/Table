using UnityEngine;

namespace _Root.Scripts.Gun_Mechanism.Runtime
{
    public class GunMoveAroundCircle : MonoBehaviour
    {
        public float radius = 5f;     
        public float speed = 1f;
        public Camera mainCamera;

        private void Awake()
        {
            mainCamera = Camera.main;
        }
        
        
        private void Update()
        {
            var mousePosition = Input.mousePosition;
            mousePosition = mainCamera.ScreenToWorldPoint(mousePosition);
            var gunPosition = transform.position;
            var positionDifference = mousePosition - gunPosition;
            var gunAngleZ = Mathf.Atan2(positionDifference.y, positionDifference.x) * Mathf.Rad2Deg;
            var gunAngle = gunAngleZ - 90;
            transform.eulerAngles = new Vector3(0, 0, gunAngle);
            
        }


    }
}