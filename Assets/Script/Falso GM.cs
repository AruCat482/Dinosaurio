using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FalsoGM : MonoBehaviour
{
    [SerializeField] GameObject textoGO, boton;
    [SerializeField] GameObject personaje, enemigo;
    [SerializeField] bool reloj;
    [SerializeField] public float tiempo;
    [SerializeField] TMP_Text textoTiempo;

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
    }

    public void Perder ()
    {
        personaje.SetActive(false);
        enemigo.SetActive(false);
        textoGO.SetActive(true);
        boton.SetActive(true);
        reloj = false;
    }
    public void ReiniciarJuego()
    {
        personaje.SetActive(true);
        enemigo.SetActive(true);
        textoGO.SetActive(false);
        boton.SetActive(false);
        reloj = true;
    }
}
