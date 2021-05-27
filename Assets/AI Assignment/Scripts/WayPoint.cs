using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoint : MonoBehaviour
{
    // Lamda - Inline funtions - Funtions without actual definitions
    // Like when we use private void - just points to something // 
    // In this case points to transform.position
    public Vector3 Position => transform.position;


    // simply a way to find any object marked as a waypoint

    // Implement this OnDraw Gizmos if you want to draw gizmos that are also pickable
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 0.1f);
    }

}
