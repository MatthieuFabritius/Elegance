using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using StarterAssets;

public class DoorOpener : MonoBehaviour
{
   
    public ThirdPersonController thirdPersonController;

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
        if (other.CompareTag("Door"))
        {
            // Handle the case where the collider is a door
        }

        if (other.CompareTag("ClosedDoor"))
        {
            if (thirdPersonController.hasKey)
            {
                thirdPersonController.hasKey = false;
            }
        }

    }

    
}
