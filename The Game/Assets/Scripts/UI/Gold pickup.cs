using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goldpickup : MonoBehaviour, Interactable
{
    public string InteractMessage => ObjectInteractMessage;

    [SerializeField] protected string ObjectInteractMessage;

    void ChangeScene()
    {
        //UnityEngine.Cursor.lockState = CursorLockMode.None;
        //UnityEngine.Cursor.visible = true;
        SceneManager.LoadScene(9);
    }

    public void Interact()
    {
        ChangeScene();
    }
}
