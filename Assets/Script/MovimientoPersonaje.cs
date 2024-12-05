using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody2D;
    [SerializeField] Animator animator;
    [SerializeField] float altura;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown ("Jump") || Input.GetButtonDown ("Fire1"))
        {
            animator.SetBool("Animacion", true);
            rigidbody2D.AddForce(Vector2.up*altura);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (Input.GetButtonDown ("Fire2"))
        {
            animator.SetBool("Animacion", false);
        }
        if (collision.transform.tag == "Enemigo")
        {
            GameManager.Instancia.Perder();
        }
    }
}
