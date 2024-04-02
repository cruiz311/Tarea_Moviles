using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public VidaSO vidaSO; // Referencia al Scriptable Object de vida
    public PuntajeSO puntajeSO; // Referencia al Scriptable Object de puntaje
    public DatosPersonaje datospersonaje;
    // Start is called before the first frame update
    void Start()
    {
        datospersonaje = GameManager.Instance.ObtenerDatosPersonaje();
        vidaSO.vidas = datospersonaje.vida;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            vidaSO.vidas--;

            if(vidaSO.vidas <= 0)
            {
                SceneManager.LoadScene("LoseScene");
            }
        }
    }
}
