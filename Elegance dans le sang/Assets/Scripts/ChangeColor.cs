using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChangeColor : MonoBehaviour
{
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
        if(Keyboard.current.fKey.wasPressedThisFrame)
        {
            renderer.material.color = newColor;
        }
        if (Keyboard.current.fKey.wasReleasedThisFrame)
        {
            renderer.material.color = initialColor;
        }
    }
}