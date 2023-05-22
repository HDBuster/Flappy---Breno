using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CompProjetil : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float disparo = 5;
    private int count;
    public GameObject explosao;

    // Start is called before the first frame update
    void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 speed = new Vector2(1,0);
        rb2d.AddForce(speed * disparo);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Hazard"))
        {
            other.gameObject.SetActive(false);
            gameObject.SetActive(false);

            GameObject exp = Instantiate(explosao, transform.position, Quaternion.identity) as GameObject;
            Destroy(explosao, 3);
        }
        if (other.gameObject.CompareTag("Parede"))
        {
            gameObject.SetActive(false);
        }
    }
}
