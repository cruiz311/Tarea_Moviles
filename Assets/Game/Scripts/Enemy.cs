using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Movimiento hacia la izquierda
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);

        // Si el enemigo está mirando hacia la derecha, voltearlo
        if (transform.localScale.x > 0)
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
    }
}
