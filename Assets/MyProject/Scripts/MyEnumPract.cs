using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    Done,
    WorkInProgress,
    Cancel
}

public class MyEnumPract : MonoBehaviour
{
    State myState;

    // Start is called before the first frame update
    void Start()
    {
        myState = State.Cancel;

        // Mit Switch
        switch (myState)
        {
            case State.Done:
                Debug.Log((int)State.Done);
                break;
            case State.WorkInProgress:
                Debug.Log((int)State.WorkInProgress);
                break;
            case State.Cancel:
                Debug.Log((int)State.Cancel);
                break;
        }

        // mit If-Statements
        if(myState == State.Done)
        {
            Debug.Log((int)State.Done);
        }

        else if (myState == State.WorkInProgress)
        {
            Debug.Log((int)State.WorkInProgress);
        }

        else
        {
            Debug.Log((int)State.Cancel);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
