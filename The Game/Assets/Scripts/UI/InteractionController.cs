using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using TMPro;

public class InteractionController : MonoBehaviour
{
    [SerializeField] protected Camera firstPersonCam;

    [SerializeField] protected TextMeshProUGUI InteractionText;

    [SerializeField] protected float InteractionDistance = 5f;

    Interactable CurrentTargetedInteractable;

    public void Update()
    {
        UpdateCurrentInteractable();
        UpdateInteractionText();
        CheckForInteractionInput();
    }

    public void UpdateCurrentInteractable()
    {
        var ray = firstPersonCam.ViewportPointToRay(new UnityEngine.Vector2(0.5f, 0.5f));
        Physics.Raycast(ray, out var hit, InteractionDistance);
        CurrentTargetedInteractable = hit.collider?.GetComponent<Interactable>();
    }

    public void UpdateInteractionText()
    {
        if(CurrentTargetedInteractable == null)
        {
            InteractionText.text = string.Empty;
            return;
        }

        InteractionText.text = CurrentTargetedInteractable.InteractMessage;
    }

    public void CheckForInteractionInput()
    {
        if(Input.GetKeyDown(KeyCode.E) && CurrentTargetedInteractable != null)
        {
            CurrentTargetedInteractable.Interact();
        }
    }
}

