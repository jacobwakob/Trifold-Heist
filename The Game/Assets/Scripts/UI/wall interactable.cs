using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class wallinteractable : MonoBehaviour, Interactable
{
    [SerializeField] private KeyInteractable keypickup;
    [SerializeField] protected string ObjectInteractMessage;
    public GameObject button;

    public string InteractMessage => ObjectInteractMessage;

    public void Interact()
    {
        if (keypickup != null && keypickup.keypickup)
        {
            ObjectInteractMessage = "Press E to open";
            Destroy(button);
            Destroy(gameObject);
        }
        else
        {
            ObjectInteractMessage = "You need a key to open";
        }
    }
}