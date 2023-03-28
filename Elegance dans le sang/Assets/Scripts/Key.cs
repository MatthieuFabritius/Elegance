using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public KeyCode grabKey;
    private ThirdPersonController thirdPersonController;

    void Start()
    {
        thirdPersonController = FindObjectOfType<ThirdPersonController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Detected !!!!");
        if (Input.GetKeyDown(grabKey))
        {
            thirdPersonController.hasKey = true;
            Destroy(gameObject);
        }
    }
}