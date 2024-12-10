using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class CrearEnemigo2 : MonoBehaviour
{
    [SerializeField] GameObject enemigo;
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicionMinima, posicionInicial;

    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
        posicionMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));
        posicionInicial = camara.ViewportToWorldPoint(new Vector2(1, 1));


    }

    private void OnEnable()
    {
        StartCoroutine(CrearEnemigo1());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator CrearEnemigo1()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(2,6));
            //yield return new WaitForSeconds(4);
            GameObject enemigoNuevo = Instantiate(enemigo);
            //enemigoNuevo.transform.position = CalcularPosicionAleatoria();
        }
    }
}