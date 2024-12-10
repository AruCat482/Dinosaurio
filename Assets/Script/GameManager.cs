using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject textoGO, boton;
    [SerializeField] GameObject personaje, enemigo, enemigo2;
    [SerializeField] bool reloj;
    [SerializeField] public float tiempo;
    [SerializeField] TMP_Text textoTiempo;
    [SerializeField] public int PuntuacionActual;
    [SerializeField] public int MejorPuntuacion;
    [SerializeField] TMP_Text PuntuacionActual1, MejorPuntuacion1;
    [SerializeField] GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
  

        textoGO.SetActive(false);
        boton.SetActive(false);
        reloj = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (reloj == true)
        {
            tiempo += Time.deltaTime;
            int minutos = (int)tiempo / 60;
            int segundos = (int)tiempo % 60;
            Debug.Log($"{minutos:D2}:{segundos:D2}");
            textoTiempo.text = $"{minutos:D2}:{segundos:D2}";
        }
        PuntuacionActual1.text = gameManager.PuntuacionActual.ToString();
        MejorPuntuacion1.text = gameManager.MejorPuntuacion.ToString();

        //Input.GetButtonDown = gameManager.ReiniciarJuego();
    }

    public void Perder()
    {
        personaje.SetActive(false);
        enemigo.SetActive(false);
        enemigo2.SetActive(false);
        textoGO.SetActive(true);
        boton.SetActive(true);
        reloj = false;
        GameObject[] Enemigos = GameObject.FindGameObjectsWithTag("Enemigo");
        for (int i = 0; i < Enemigos.Length; i++)
        {
            Destroy(Enemigos[i]);
        }
    }
    public void ReiniciarJuego()
    {
        Debug.Log("Otra vez...");
        personaje.SetActive(true);
        enemigo.SetActive(true);
        enemigo2.SetActive(true);
        textoGO.SetActive(false);
        boton.SetActive(false);
        reloj = true;
        tiempo = 0;
        PuntuacionActual = 0;
    }
    public void ActualizarPuntuacion()
    {
        PuntuacionActual++;
        if (PuntuacionActual > MejorPuntuacion)
        {
            MejorPuntuacion = PuntuacionActual;
            PlayerPrefs.SetInt("MejorPuntuacion", MejorPuntuacion);
        }
    }
}
