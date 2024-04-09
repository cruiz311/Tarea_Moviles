using System.Collections.Generic;
using UnityEngine;

public static class BasuraPool
{
    private static Queue<GameObject> poolQueue = new Queue<GameObject>();
    private static GameObject basuraPrefab; // Almacena el prefab del enemigo
    public static int poolSize = 5;

    public static void Initialize(GameObject prefab)
    {
        basuraPrefab = prefab; 
        for (int i = 0; i < poolSize; i++)
        {
            GameObject basura = GameObject.Instantiate(basuraPrefab);
            basura.SetActive(false);
            poolQueue.Enqueue(basura);
        }
    }

    public static GameObject GetBasura(Vector3 position, Quaternion rotation)
    {
        if (poolQueue.Count == 0)
        {
            Debug.LogWarning("Pool exhausted! Consider increasing pool size.");
            return null;
        }

        GameObject basura = poolQueue.Dequeue();
        basura.transform.position = position;
        basura.transform.rotation = rotation;
        basura.SetActive(true);
        return basura;
    }

    public static void ReturnBasura(GameObject basura)
    {
        basura.SetActive(false);
        poolQueue.Enqueue(basura);
    }
}
