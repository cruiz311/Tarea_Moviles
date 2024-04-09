using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public GameObject player;
    public balaOP balaop;
    public PuntajeSO puntajeSO;

    private void Start()
    {
        player = GameObject.Find("Player");
        balaop = player.GetComponent<balaOP>();
        StartCoroutine(DestroyAfterLifetime());
    }

    void Update()
    {
        // Movimiento hacia la izquierda
        transform.Translate(Vector3.right * 5 * Time.deltaTime);

        // Si el enemigo está mirando hacia la derecha, voltearlo
        if (transform.localScale.x > 0)
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Basura"))
        {
            puntajeSO.puntaje++;
            BasuraPool.ReturnBasura(collision.gameObject);
            balaop.ReturnBullet(gameObject); // Devuelve la bala al pool
        }
    }

    IEnumerator DestroyAfterLifetime()
    {
        yield return new WaitForSeconds(5);
        balaop.ReturnBullet(gameObject); // Devuelve la bala al pool después de 5 segundos
    }
}
