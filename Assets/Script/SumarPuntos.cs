using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumarPuntos : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.ActualizarPuntuacion();
        Debug.Log("Puntito que me llevo!!");
    }
}
