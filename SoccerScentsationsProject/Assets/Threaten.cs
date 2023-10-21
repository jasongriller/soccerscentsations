using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Threaten : MonoBehaviour
{
    public Animator anim;

    void Start ()
    {
        anim = GetComponent<Animator>();
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.Play("Threaten (Idle)");
        }
    }
}

