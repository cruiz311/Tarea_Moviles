using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balaOP : MonoBehaviour
{
    public GameObject bulletPrefab;
    public int initialPoolSize = 10;
    public int maxPoolSize = 20; // Tamaño máximo del pool

    private List<GameObject> bullets;

    void Start()
    {
        bullets = new List<GameObject>();
        InitializePool(initialPoolSize);
    }

    void InitializePool(int size)
    {
        for (int i = 0; i < size; i++)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform);
            bullet.SetActive(false); // Desactiva las balas al inicio
            bullets.Add(bullet);
        }
    }

    public GameObject GetBullet()
    {
        // Busca una bala inactiva en el pool
        foreach (GameObject bullet in bullets)
        {
            if (!bullet.activeInHierarchy)
            {
                return bullet; // Devuelve una bala inactiva
            }
        }

        // Si no hay balas inactivas en el pool, crea una nueva si el tamaño del pool no ha alcanzado el máximo
        if (bullets.Count < maxPoolSize)
        {
            GameObject newBullet = Instantiate(bulletPrefab, transform);
            bullets.Add(newBullet);
            return newBullet;
        }

        // Si el tamaño del pool ya ha alcanzado el máximo, devuelve la primera bala del pool
        return bullets[0];
    }

    public void ReturnBullet(GameObject bullet)
    {
        bullet.SetActive(false); // Desactiva la bala
    }
}
