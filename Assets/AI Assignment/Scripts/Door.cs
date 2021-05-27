using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    //adjust this to change speed
  //  float speed = 1f;
    //adjust this to change how high it goes
  //  float height = 2f;
   // [SerializeField] private float offset = 1;

    public GameObject door;
    public GameObject Obsticle;

  /*  void Update()
    {

        //get the objects current position and put it in a variable so we can access it later with less code
        Vector3 pos = transform.position;
        //calculate what the new Y position will be
        float newY = Mathf.Sin(Time.time * speed) - offset;
        //set the object's Y to the new calculated Y
        transform.position = new Vector3(pos.x, newY * height, pos.z); 
    }
  */

    // Opens Door
    public void OnTriggerEnter(Collider other)
    {
        door.SetActive(false);
        Obsticle.SetActive(true);
    }

   /* public void OnTriggerExit(Collider other)
    {
        door.SetActive(true); 
    }
   */


}
