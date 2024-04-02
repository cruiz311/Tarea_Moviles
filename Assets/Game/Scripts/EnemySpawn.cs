using UnityEngine;
using System.Collections;

public class EnemySpawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 3f;
    public float moveSpeed = 5f;
    public float spawnRangeMinX = -3.5f;
    public float spawnRangeMaxX = 3.5f;

    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    IEnumerator SpawnEnemies()
    {
        while (true)
        {
            // Calcular una posición aleatoria en el eje Y dentro del rango especificado
            float spawnPosY = Random.Range(spawnRangeMinX, spawnRangeMaxX);
            Vector3 spawnPosition = new Vector3(transform.position.x, spawnPosY, transform.position.z);

            // Instanciar el enemigo en la posición calculada
            GameObject newEnemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

            // Obtener el componente Enemy y establecer su velocidad de movimiento
            Enemy enemyComponent = newEnemy.GetComponent<Enemy>();
            if (enemyComponent != null)
            {
                enemyComponent.moveSpeed = moveSpeed;
            }

            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
