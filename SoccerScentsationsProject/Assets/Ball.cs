using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
    public Transform target;
    public float Force;
    public Slider forceUI;
    int speedCounter;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            speedCounter++;
            if((speedCounter % 3) == 0)
            {
                Force++;
            }
            slider();
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            shoot();
            StartCoroutine(Wait());
        }
    }

    void shoot()
    {
        Vector3 Shoot = (target.position - this.transform.position).normalized;
        GetComponent<Rigidbody>().AddForce(Shoot * Force, ForceMode.Impulse);
    }

    public void slider()
    {
        forceUI.value = Force;
    }

    public void ResetGauge()
    {
        Force = 0;
        forceUI.value = 0;
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(1.5f);
        ResetGauge();
    }
}