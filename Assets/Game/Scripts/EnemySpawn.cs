using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemyPrefabs; // Array de prefabs de enemigos y basura
    public float spawnInterval = 3f;
    public float moveSpeed = 5f;
    public float spawnRangeMinY = -3.5f; // Rango mínimo en el eje Y
    public float spawnRangeMaxY = 3.5f; // Rango máximo en el eje Y

    private float spawnTimer;

    void Start()
    {
        EnemyPool.Initialize(enemyPrefabs[0]);
        BasuraPool.Initialize(enemyPrefabs[1]);
        spawnTimer = 0f;
    }

    void Update()
    {
        spawnTimer += Time.deltaTime;
        if (spawnTimer >= spawnInterval)
        {
            int randomNumber = Random.Range(0, 2);
            if (randomNumber == 0)
            {
                SpawnEnemy();
            }
            else
            {
                SpawnBasura();
            }

            spawnTimer = 0f;
        }
    }

    void SpawnEnemy()
    {
        Vector3 spawnPosition = new Vector3(transform.position.x, Random.Range(spawnRangeMinY, spawnRangeMaxY), transform.position.z);
        Quaternion spawnRotation = Quaternion.identity;
        GameObject enemy = EnemyPool.GetEnemy(spawnPosition, spawnRotation);
    }

    void SpawnBasura()
    {
        Vector3 spawnPosition = new Vector3(transform.position.x, Random.Range(spawnRangeMinY, spawnRangeMaxY), transform.position.z);
        Quaternion spawnRotation = Quaternion.identity;
        GameObject basura = BasuraPool.GetBasura(spawnPosition, spawnRotation);
    }
}
