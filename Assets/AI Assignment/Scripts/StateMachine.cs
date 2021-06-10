using System.Collections.Generic;
using UnityEngine;



namespace StateMachines
{
    public enum States
    {
        LookingForKey,
        LookForEnd
    }

    // The delegate that dictates what the funtions will look like.
    public delegate void StateDelegate();

    public class StateMachine : MonoBehaviour
    {
        private Dictionary<States, StateDelegate> states = new Dictionary<States, StateDelegate>();

        [SerializeField] private States currentState = States.LookingForKey;
        [SerializeField] private Transform controlled; // the thing that will be affected by our statemachines
        [SerializeField] private float speed = 1f; // This isn't really in a statemachine, this is just for testing
        public Key[] keys;

        // This is used to change states from anywhere within the code that has reference
        // to the StateMachine

        public void ChangeState(States _newState)
        {
            if (_newState != currentState)
                currentState = _newState;
        }


        // Start is called before the first frame update
        void Start()
        {
            // This is the same as checking if the cariable is null, then setting it otherwise
            // retain the value 
            controlled ??= transform;

            states.Add(States.LookingForKey, LookingForKey);
            states.Add(States.LookForEnd, Rotate);

            keys = FindObjectsOfType<Key>();
            
        }

        // Update is called once per frame
        void Update()
        {
            // These two line are what actually runs the state machine
            // It works by attemping to retreve the relevent funtion for the current state,
            // then running the function if it successfully found it.
            if (states.TryGetValue(currentState, out StateDelegate state))
                state.Invoke();
            else
                Debug.LogError($"No State funtion set for state {currentState}.");
        }


        // The funtion that will run when we are in the traanslate state.
        public void LookingForKey()
        {
            Key[] keys = FindObjectsOfType<Key>();
            // Loop through keys
            

            // Find closest
            AgentSmith smith = FindObjectOfType<AgentSmith>();

            Key closestKey = null;
            float closestDistance = float.MaxValue;
            foreach (Key key in keys)
            {
                float distance = Vector3.Distance(smith.transform.position, key.transform.position);
                if (distance < closestDistance)
                {
                    closestKey = key;
                    closestDistance = distance;
                }
            }

            smith.agent.SetDestination(closestKey.transform.position);

            
         



            // Move towards found key
        }
        private void Rotate() => controlled.Rotate(Vector3.up, speed * .5f);
        
       
    }
}


