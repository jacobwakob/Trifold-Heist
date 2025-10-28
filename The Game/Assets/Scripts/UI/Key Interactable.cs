using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInteractable : MonoBehaviour, Interactable
{
    public string InteractMessage => ObjectInteractMessage;

    [SerializeField] protected string ObjectInteractMessage;

    public bool keypickup = false;

    void ChangeScene()
    {
        //UnityEngine.Cursor.lockState = CursorLockMode.None;
        //UnityEngine.Cursor.visible = true;
        //SceneManager.LoadScene(3);
    }

    public void Interact()
    {
        keypickup = true;
        gameObject.SetActive(false);

    }
}
