using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.InputSystem;

public class TakeObjects : MonoBehaviour
{
    [Header("Variables")]
    public float interactDistance = 2f;
    public TMP_Text interactibleText;
    public GameObject interactMessage;

    void Update()
    {

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hitInfo;
        Debug.DrawRay(ray.origin, ray.direction * interactDistance, Color.green);
        if (Physics.Raycast(ray, out hitInfo, interactDistance) && hitInfo.collider.CompareTag("TakeObjects"))
        {
            if (hitInfo.distance <= interactDistance)
            {
                if (!interactMessage.activeSelf)
                {
                    interactMessage.SetActive(true);
                    interactibleText.text = "Press F to interact.";
                }
            }
        }
        else
        {
            if (interactMessage.activeSelf)
                interactMessage.SetActive(false);
        }
        // Commande pour intéragir
        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            if (interactMessage.activeSelf)
            {
                if (hitInfo.collider.gameObject.tag == "TakeObjects")
                {
                    Destroy(hitInfo.collider.gameObject);
                }
            }
        }
    }
}