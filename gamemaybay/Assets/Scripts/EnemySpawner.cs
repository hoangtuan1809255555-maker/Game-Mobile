using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float spawnTime = 2f;

    public float minX = -7f;
    public float maxX = 7f;
    public float spawnY = 5f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnTime);
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(minX, maxX);

        Vector3 spawnPosition = new Vector3(
            randomX,
            spawnY,
            0f
        );

        Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}