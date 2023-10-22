using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody rb;
    Animator animator;
    CapsuleCollider capsuleCollider;

    public Transform cameraTransform;

    private float yaw = 0;
    private float pitch = 0;


    private float speed;
    public float runSpeed = 0.6f;
    public float rotationSpeed = 2.5f;


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        animator = gameObject.GetComponent<Animator>();
        capsuleCollider = gameObject.GetComponent<CapsuleCollider>();
    }

    void Update()
    {
        float y = Input.GetAxis("Horizontal") * rotationSpeed;
        float z = Input.GetAxis("Vertical") * speed;
        transform.Translate(0, 0, z);
        cameraTransform.Rotate(0, y, 0);

        yaw += rotationSpeed * Input.GetAxis("Mouse X");
        pitch -= rotationSpeed * Input.GetAxis("Mouse Y");
        transform.eulerAngles = new Vector3(0, yaw, 0);
        cameraTransform.eulerAngles = new Vector3(pitch, yaw, 0);

        if (Input.GetKey(KeyCode.UpArrow))
        {
            animator.SetBool("isRunning", true);
            animator.SetBool("isIdle", false);
            animator.SetBool("flip", true);
        }
        else 
        {
            animator.SetBool("isRunning", false);
            animator.SetBool("isIdle", true);
            animator.SetBool("flip", false);
        }
            speed = runSpeed;
        }
}
