using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombPickup : MonoBehaviour, Interactable
{
    public string InteractMessage => ObjectInteractMessage;

    [SerializeField] protected string ObjectInteractMessage;

    public bool BombPick = false;

    void ChangeScene()
    {
        //UnityEngine.Cursor.lockState = CursorLockMode.None;
        //UnityEngine.Cursor.visible = true;
        //SceneManager.LoadScene(3);
    }

    public void Interact()
    {
        BombPick = true;
        gameObject.SetActive(false);
    }
}
