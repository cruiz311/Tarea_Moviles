using System.Collections.Generic;
using UnityEngine;

public static class EnemyPool
{
    private static Queue<GameObject> poolQueue = new Queue<GameObject>();
    private static GameObject enemyPrefab; // Almacena el prefab del enemigo
    public static int poolSize = 5;

    public static void Initialize(GameObject prefab)
    {
        enemyPrefab = prefab; // Establece el prefab del enemigo
        for (int i = 0; i < poolSize; i++)
        {
            GameObject enemy = GameObject.Instantiate(enemyPrefab);
            enemy.SetActive(false);
            poolQueue.Enqueue(enemy);
        }
    }

    public static GameObject GetEnemy(Vector3 position, Quaternion rotation)
    {
        if (poolQueue.Count == 0)
        {
            Debug.LogWarning("Pool exhausted! Consider increasing pool size.");
            return null;
        }

        GameObject enemy = poolQueue.Dequeue();
        enemy.transform.position = position;
        enemy.transform.rotation = rotation;
        enemy.SetActive(true);
        return enemy;
    }

    public static void ReturnEnemy(GameObject enemy)
    {
        enemy.SetActive(false);
        poolQueue.Enqueue(enemy);
    }
}
