using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Texto : MonoBehaviour
{
    [SerializeField] TMP_Text PuntuacionActual, MejorPuntuacion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PuntuacionActual.text = GameManager.Instancia.PuntuacionActual.ToString();
        MejorPuntuacion.text = GameManager.Instancia.MejorPuntuacion.ToString();
    }
}
