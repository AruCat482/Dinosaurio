using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Texto : MonoBehaviour
{
    [SerializeField] TMP_Text PuntuacionActual, MejorPuntuacion;
    [SerializeField] GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PuntuacionActual.text = gameManager.PuntuacionActual.ToString();
        MejorPuntuacion.text = gameManager.MejorPuntuacion.ToString();
    }
}
