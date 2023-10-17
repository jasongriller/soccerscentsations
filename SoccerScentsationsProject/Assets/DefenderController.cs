using UnityEngine;

public class DefenderController : MonoBehaviour
{
    public float moveSpeed = 3f;

    private void Update()
    {
        transform.Translate(Vector3.back * moveSpeed * Time.deltaTime * -1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            // Player "dies", you can reload the scene or whatever action you prefer.
            UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
    }
}
