using System.Collections;

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float strafeSpeed = 3f;  // Speed for left/right strafing
    public float jumpForce = 5f;
    private Rigidbody rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Defender"))
        {
            // For now, we'll just deactivate the player. This is a simple representation of "death".
            gameObject.SetActive(false);

            // You can also add other game-over mechanics here, like displaying a game-over screen.
        }
    }
    private void Update()
    {
        float horizontalMovement = Input.GetAxis("Horizontal");



        // Move player constantly forward and allow for strafing left/right
        Vector3 moveDirection = new Vector3(horizontalMovement * strafeSpeed, 0f, moveSpeed);
        transform.Translate(moveDirection * Time.deltaTime, Space.World);

        if (Input.GetKeyDown(KeyCode.Space) && Mathf.Abs(rb.velocity.y) < 0.01f)
        {
            rb.AddForce(new Vector3(0f, jumpForce, 0f), ForceMode.Impulse);
        }
    }
}
    
