using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public KeyCode changeColorKey;
    public Color newColor;

    private Renderer renderer;
    private Color initialColor;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        initialColor = renderer.material.color;
    }

    void Update()
    {
        if (Input.GetKeyDown(changeColorKey))
        {
            renderer.material.color = newColor;
        }
        if (Input.GetKeyUp(changeColorKey))
        {
            renderer.material.color = initialColor;
        }
    }
}