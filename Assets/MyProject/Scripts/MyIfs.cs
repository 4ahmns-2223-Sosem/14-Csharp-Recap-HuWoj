using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyIfs : MonoBehaviour
{
    public int randomNumber;

    // Start is called before the first frame update
    void Start()
    {
        if(randomNumber < 7)
        {
            Debug.Log("Du bist drunter - W�hle eine h�here Zahl");
        }

        else if (randomNumber > 7)
        {
            Debug.Log("Du bist dr�ber - W�hle eine niedrigere Zahl");
        }

        else
        {
            Debug.Log("Du hast gewonnen - 7 ist die richtige Zahl");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
