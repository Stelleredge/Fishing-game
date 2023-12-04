using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public GameObject fishPrefab;
    public float swimSpeed = 5f;
    public float maxDistance = 10f;
    public float spawnInterval = 5f; // Adjust this value based on the desired spawn interval

    private float distanceTraveled = 0f;
    private bool moveRight = true;

    void Start()
    {
        // Start spawning fish after a delay and repeat at the specified interval
        InvokeRepeating("SpawnFish", 2f, spawnInterval);
    }

    void Update()
    {
        // Move the fish along the X-axis
        if (moveRight)
        {
            transform.Translate(Vector3.right * swimSpeed * Time.deltaTime);
            distanceTraveled += swimSpeed * Time.deltaTime;
        }
        else
        {
            transform.Translate(Vector3.left * swimSpeed * Time.deltaTime);
            distanceTraveled -= swimSpeed * Time.deltaTime;
        }

        // Check if the fish has traveled the desired distance
        if (distanceTraveled >= maxDistance || distanceTraveled <= 0f)
        {
            // Change direction
            moveRight = !moveRight;
        }
    }

    void SpawnFish()
    {
        // Instantiate a new fish at a random Z position
        float randomZ = Random.Range(-5f, 5f); // Adjust the range based on your scene
        Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y, randomZ);

        Instantiate(fishPrefab, spawnPosition, Quaternion.identity);
    }
}
