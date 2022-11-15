using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zoom : MonoBehaviour
{
    private float Tama�o;
    private bool Desplazar;
    private float Xmover;
    private float Ymover;
    private Vector3 mousePosition;
    public float VelocidaddeZoom = 0.1f;


    // Start is called before the first frame update
    void Start()
    {
        Tama�o = Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if(Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            Tama�o -= VelocidaddeZoom;
        }

        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            Tama�o += VelocidaddeZoom;
        }
        Camera.main.orthographicSize = Tama�o;
        if(Input.GetMouseButtonDown(2))
        {
            Xmover = mousePosition.x;
            Ymover = mousePosition.y;
            Desplazar = true;
        }
        if(Input.GetMouseButtonUp(2))
        {
            Desplazar = false;
        }
        if(Desplazar)
        {
            Camera.main.transform.position = new Vector3(Camera.main.transform.position.x + Xmover, Camera.main.transform.position.y + Ymover, Camera.main.transform.position.z);
        }

    }
}
