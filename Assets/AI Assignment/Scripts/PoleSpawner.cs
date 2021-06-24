using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoleSpawner : MonoBehaviour
{
    public GameObject pole;

    public void OnTriggerEnter(Collider collision)
    {
        pole.SetActive(true);
    }
}
