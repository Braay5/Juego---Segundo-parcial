using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotónManipulador : MonoBehaviour
{
    private MovimientoEscena currentDisplay;

    private void Start()
    {
        currentDisplay = GameObject.Find("movimientoEscena").GetComponent<MovimientoEscena>();
    }

    public void TeclaDerecha()
    {
        currentDisplay.CurrentWall = currentDisplay.CurrentWall + 1;
    }

    public void TeclaIzquierda()
    {
        currentDisplay.CurrentWall = currentDisplay.CurrentWall - 1;
    }

}
