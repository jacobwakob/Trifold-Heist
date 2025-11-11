using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour
{

    [Header("Dash")]
    public float dashSpeed = 0.3f;
    public float dashTime = 0.2f;
    public float dashCooldown = 1f;
    public bool canDash = true;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && canDash)
        {
            StartCoroutine(Dashing());
        }
    }

    IEnumerator Dashing()
    {
        canDash = false;

        float startTime = Time.time;

        while (Time.time < startTime + dashTime)
        {
            transform.Translate(Vector3.forward * dashSpeed);
            yield return null;
        }

        yield return new WaitForSeconds(dashCooldown);

        canDash = true;
    }
}
