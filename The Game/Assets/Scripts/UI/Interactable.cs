using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Interactable
{
    public string InteractMessage { get; }

    public void Interact();

}
