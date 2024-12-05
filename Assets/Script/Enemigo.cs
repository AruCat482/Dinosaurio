using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField] float velocidad;
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicionMinima, posicionInicial;
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip[] audioClip;

    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
        posicionMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));
        posicionInicial = camara.ViewportToWorldPoint(new Vector2(1, 1));
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocidad * Vector2.left * Time.deltaTime);
        if (transform.position.x < posicionMinima.x)
        {
            Destroy(gameObject, 0.5f);
        }
    }
}
