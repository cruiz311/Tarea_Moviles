using UnityEngine;

public class ObtenerJugador : MonoBehaviour
{
    public SpriteRenderer personajeRenderer;
    public DatosPersonaje datosPersonaje;

    private void Start()
    {
        datosPersonaje = GameManager.Instance.ObtenerDatosPersonaje();
        personajeRenderer.sprite = datosPersonaje.sprite;
    }
}
