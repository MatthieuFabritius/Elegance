using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using UnityEngine.InputSystem;

public class Door : MonoBehaviour
{
    private ThirdPersonController thirdPersonController;
    // Start is called before the first frame update
    void Start()
    {
        thirdPersonController = FindObjectOfType<ThirdPersonController>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Door"))
        {
            if (Keyboard.current.eKey.wasReleasedThisFrame)
            {

            }
        }

        if (other.CompareTag("ClosedDoor"))
        {
            if (thirdPersonController.hasKey)
            {
                if (Keyboard.current.eKey.wasReleasedThisFrame)
                {
                    thirdPersonController.hasKey = false;
                }
                
            }
        }
    }
    






}
