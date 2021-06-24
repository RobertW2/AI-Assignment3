using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject door;
    public GameObject key1;

    private void OnTriggerEnter(Collider other)
    {
        // We got the key
        Destroy(gameObject);

        door.SetActive(false);
    }
}
