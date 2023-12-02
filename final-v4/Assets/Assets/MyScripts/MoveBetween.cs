    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    
    public class MoveBetween : MonoBehaviour

    // the following script was adjusted from a few unity tutorials regarding transform.position
    // and a tutorial I found on YouTube about how to script waypoints from Sleepy Lava
    // it uses two "waypoints" which are just transparent square sprites in my scene
    // and makes the "enemy" move between them
    {
        [SerializeField] List<Transform> waypoints;
        [SerializeField] float moveSpeed = 2f;
        Vector3 targetPosition;
        int waypointIndex = 0;
        int index = 1;
        private bool isFacingRight = true;
        void Start()
        {
            transform.position = waypoints[waypointIndex].position;
            UpdateTransform();
        }
        void Update()
        {   transform.position = Vector2.MoveTowards
            (transform.position, targetPosition, moveSpeed * Time.deltaTime);
            if (transform.position == targetPosition) 
            {
                UpdateTransform();
                flipSprite();
            }
        }
    
        private void UpdateTransform()
        {
             waypointIndex += index;
             targetPosition = waypoints[waypointIndex].position;
             if (waypointIndex >= waypoints.Count -1) index = -1;
             else if (waypointIndex <= 0 && index == -1)index = 1;
        }
        private void flipSprite()
{
    isFacingRight = !isFacingRight;
 
    Vector3 transformScale = transform.localScale;
    transformScale.x *= -1;
    transform.localScale = transformScale;
}
    } 
