using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MovimientoEscena : MonoBehaviour
{
    private int currentWall;
    private int previousWall;

    public int CurrentWall
    {
        get { return currentWall; }
        set
        {
            if (value == 5)
            {
                currentWall = 1;
            }
            else if (value == 0)
            {
                currentWall = 4;
            }
            else
            {
                currentWall = value;
            }

        }
    }

    private void Start()
    {
        previousWall = 0;
        currentWall = 1;
    }

    private void Update()
    {
        if(currentWall != previousWall)
        {
            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Sprites" + currentWall.ToString());
        }

        previousWall = currentWall;
    }


}
