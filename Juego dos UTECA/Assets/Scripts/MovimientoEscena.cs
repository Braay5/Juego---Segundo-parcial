using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEscena : MonoBehaviour
{
    public int EscenaActual
    {
        get { return escenaActual; }
        set
        {
            if (value == 5)
                escenaActual = 1;
            else if (value == 0)
                escenaActual == 4;
            else
                escenaActual = value;
        
        }
    }

    private int escenaActual;
    private int escenaPrevia;

    private void Start()
    {
        escenaPrevia = 0;
        escenaActual = 1;
    }

    private void Update()
    {
        if(escenaActual != escenaPrevia)
        {
            GetComponent<SpriteRenderer>().sprite = Sprites.Load<Sprite>
        }

        escenaPrevia = escenaActual;
    }
}
