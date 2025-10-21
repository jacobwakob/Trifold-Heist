using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class boss : EnemySTATS
{
    public override void Damage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            gameObject.SetActive(false);
        }
    }
}