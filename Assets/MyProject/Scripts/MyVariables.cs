using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyVariables : MonoBehaviour
{
    // Valuevariablen
    public int intVariable;
    public float floatVariable;
    public string stringVariable;
    public bool boolVariable;

    // Referenzvariablen
    public GameObject gameObjectVariable;


    // Start is called before the first frame update
    void Start()
    {
        // Valuevariablen - Werte zuweisen
        intVariable = 1;
        floatVariable = 0.999f;
        stringVariable = "Ich hab keine Ahnung was ich da mache, aber es scheint zu stimmen...";
        boolVariable = true;

        // Referenzvariablen - Werte zuweisen
        gameObjectVariable = GameObject.Find("Testobjekt");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
