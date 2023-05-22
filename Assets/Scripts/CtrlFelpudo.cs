using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.InputSystem;

public class CtrlFelpudo : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float movx;
    private float movy;
    public float speed = 1;
    public float air = 5;
    public GameObject projetil;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void OnFire(InputValue clickValue)
    {
        Instantiate(projetil, new Vector2(transform.position.x + 2, transform.position.y), Quaternion.identity);
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movx = movementVector.x;
        movy = movementVector.y;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 movement = new Vector2(movx, movy);
        Vector2 drag = new Vector2(movx - air, 0);

        rb2d.AddForce(movement * speed);
        rb2d.AddForce(drag);
    }
}
