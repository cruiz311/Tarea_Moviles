using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public GameManager gameManager;

    private static UiManager _instance;
    public static UiManager Instance { get { return _instance; } }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;

            // Buscar el GameManager en la escena
            gameManager = FindObjectOfType<GameManager>();
        }
    }
}
