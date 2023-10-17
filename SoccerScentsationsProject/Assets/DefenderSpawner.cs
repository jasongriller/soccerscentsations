using UnityEngine;


public class DefenderSpawner : MonoBehaviour
{
    public GameObject defenderPrefab;
    public float spawnInterval = 2f;

    public Transform playerTransform;
    private void Start()
    {
        InvokeRepeating("SpawnDefender", 0f, spawnInterval);
    }

    private void SpawnDefender()
    {
        float distanceAheadOfPlayer = 30f;  // You can adjust this as needed
        float distanceBetweenDefenders = 2f;

        Vector3 spawnPosition = playerTransform.position + new Vector3(0, 0, distanceAheadOfPlayer);

        for (int i = 0; i < 3; i++)
        {
            float offsetX = Random.Range(-5f, 5f) + (i * distanceBetweenDefenders);
            Instantiate(defenderPrefab, spawnPosition + new Vector3(offsetX, 1, 0), Quaternion.identity);
        }
    }


}
