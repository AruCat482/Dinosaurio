using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int PuntuacionActual;
    [SerializeField] public int MejorPuntuacion;
    public static GameManager Instancia;
    [SerializeField] float tiempo;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("MejorPuntuacion", MejorPuntuacion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Perder()
    {

    }
    public void ReiniciarJuego()
    {

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
