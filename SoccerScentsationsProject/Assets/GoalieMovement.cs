using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalieController : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
           
    }

    private void Update()
    {
        // Randomly decide the dive direction and set the corresponding boolean.
        bool diveLeft = Random.Range(0, 2) == 0;

        // Set the boolean parameters in the Animator.
        if (Input.GetKeyUp(KeyCode.Space))
        {
            animator.SetBool("DiveLeft", diveLeft);
            animator.SetBool("DiveRight", !diveLeft);
        }
    }
}





