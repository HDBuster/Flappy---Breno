using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenaMovendo : MonoBehaviour
{
    public float rolagem;

    private Renderer renderer;
    private Vector2 savedOffset;

    // Start is called before the first frame update
    void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float x = Mathf.Repeat(Time.time * rolagem, 1);
        Vector2 offset = new Vector2(x, 0);
        renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
