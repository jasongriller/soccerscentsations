using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float moveSpeed = 3;
    public float sidewaysSpeed = 3;

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // collider by Mark
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Defender"))
        {
            // For now, we'll just deactivate the player. This is a simple representation of "death".
            gameObject.SetActive(false);

            // You can also add other game-over mechanics here, like displaying a game-over screen.
        }
    }

    // Update is called once per frame
    void Update()
    {
        // constant movement in straight line
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        
        // left and right movement
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * sidewaysSpeed, Space.World);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * sidewaysSpeed, Space.World);
        }

        // code for flipping
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetBool("flip", true);
        }
        else if (Input.GetKeyUp(KeyCode.W)) // When you want to transition back to running
        {
            animator.SetBool("flip", false);
        }

        // checking if we have a gun 
        

    }
}
