using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Anim : MonoBehaviour
{
    public Animator anim;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
        agent = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        // Set walk animation
        anim.SetTrigger("Walk");

        if(Mathf.Approximately(agent.velocity.magnitude, Mathf.Epsilon))
        {
            // Set standing still animation
            anim.SetTrigger("Idle");
        }
    }
}
