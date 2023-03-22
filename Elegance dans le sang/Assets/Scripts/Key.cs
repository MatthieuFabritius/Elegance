using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Key : MonoBehaviour
{
    public KeyCode grabKey;
    private ThirdPersonController thirdPersonController;
    // Start is called before the first frame update
    void Start()
    {
        thirdPersonController = FindObjectOfType<ThirdPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collison Detected !!!!");
        if (Keyboard.current[grabKey].wasPressedThisFrame)
        {
                thirdPersonController.hasKey = true;
                Destroy(gameObject);
            }
        
    }
}
