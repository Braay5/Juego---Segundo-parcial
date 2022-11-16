using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControladorDeEscena : MonoBehaviour
{
    public GameObject Jugador;
    public Camera CamaraDeJuego;
    public GameObject[] BloquePrefab;
    public float PunteroDeJuego;
    public float LugarSeguroGeneracion = 12;
    public Text TextoDeJuego;
    public bool Perdiste;



    // Start is called before the first frame update
    void Start()
    {
        PunteroDeJuego = -7;
        Perdiste = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Jugador != null)
        {
            CamaraDeJuego.transform.position = new Vector3(Jugador.transform.position.x, CamaraDeJuego.transform.position.y, CamaraDeJuego.transform.position.z);
            TextoDeJuego.text = "Puntaje  " + Mathf.Floor(Jugador.transform.position.x);

        }

        else
        {
            if(!Perdiste)
            {
                Perdiste = true;
                TextoDeJuego.text += "\nSe terminó el juego :( \nPresiona click izquierdo del mouse para volver a empezar";
            }
            if(Perdiste)
            {
                if(Input.GetMouseButton(0))
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                }
            }
        }

        while (Jugador != null && PunteroDeJuego < Jugador.transform.position.x + LugarSeguroGeneracion)
        {
            int indiceBloque = Random.Range(0, BloquePrefab.Length - 1);
            if(PunteroDeJuego < 0)
            {
                indiceBloque = 3;
            }

            GameObject ObjetoBloque = Instantiate(BloquePrefab[indiceBloque]);
            ObjetoBloque.transform.SetParent(this.transform);
            Bloque bloque = ObjetoBloque.GetComponent<Bloque>();
            ObjetoBloque.transform.position = new Vector2(PunteroDeJuego + bloque.tamaño / 2, 0);
            PunteroDeJuego += bloque.tamaño;
        }
    }
}
