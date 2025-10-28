using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goinsidepirate : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        Debug.Log("entered");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
