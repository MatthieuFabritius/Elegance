using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using UnityEngine.InputSystem;

public class Door : MonoBehaviour
{
    public Animator animator;
    public AnimationClip animationClip;
    private ThirdPersonController thirdPersonController;

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
                animator.Play(animationClip.name);
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