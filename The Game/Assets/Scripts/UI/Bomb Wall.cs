using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BombWall : MonoBehaviour, Interactable
{
    [SerializeField] private BombPickup BombPick;
    [SerializeField] protected string ObjectInteractMessage;
    public GameObject button;

    public string InteractMessage => ObjectInteractMessage;

    public void Interact()
    {
        if (BombPick != null && BombPick.BombPick)
        {
            ObjectInteractMessage = "Press E to blow up";
            Destroy(button);
            Destroy(gameObject);
        }
        else
        {
            ObjectInteractMessage = "You need a bomb to blow up";
        }
    }
}
