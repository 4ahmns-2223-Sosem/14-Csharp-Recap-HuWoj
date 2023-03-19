using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMethods : MonoBehaviour
{
    public int zahlEins;
    public int zahlZwei;

    public bool addieren;
    public bool subtrahieren;
    public bool multiplizieren;
    public bool dividieren;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(addieren == true)
        {
            ZahlAddieren();
        }

        else if(subtrahieren == true)
        {
            ZahlSubtrahieren();
        }

        else if(multiplizieren == true)
        {
            ZahlMultiplizieren();
        }

        else
        {
            ZahlDividieren();
        }
    }

    public void ZahlAddieren()
    {
        Debug.Log(zahlEins + zahlZwei);
    }

    public void ZahlSubtrahieren()
    {
        Debug.Log(zahlEins - zahlZwei);
    }

    public void ZahlMultiplizieren()
    {
        Debug.Log(zahlEins * zahlZwei);
    }

    public void ZahlDividieren()
    {
        Debug.Log(zahlEins / zahlZwei);
    }
}
