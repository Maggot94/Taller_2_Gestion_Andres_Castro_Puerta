using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bisiesto: MonoBehaviour {

    [SerializeField]
    private int entrada;

    [SerializeField]
    private InputField Casilla;

    [SerializeField]
    private Text Answer; 



    // Use this for initialization
    void Start () {

        
         
	}
	
	// Update is called once per frame
	void Update () {
        if (Casilla.text != null)
        {
            entrada = Int32.Parse(Casilla.text);
        }
       
        if (EsBisiesto(entrada))
        {
            Answer.text = "Es Bisiesto";
        }
        else
        {
            Answer.text = "No Es Bisiesto";
        }
    }

    public bool EsBisiesto( int Entrada)
    {
        if (Entrada % 4 == 0)
        {
            if (Entrada % 100 == 0)
            {
                if (Entrada % 400 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        else
        {
            return false;
        }


    }
}
