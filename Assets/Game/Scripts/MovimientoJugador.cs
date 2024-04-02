using UnityEngine;

public enum TipoControl { Acelerometro, Giroscopio }

public class MovimientoJugador : MonoBehaviour
{
    public float velocidadMaxima = 5f; // Velocidad m�xima del jugador
    public float sensibilidadGiroscopio = 1f; // Sensibilidad del giroscopio

    public TipoControl tipoControl = TipoControl.Acelerometro; // Tipo de control seleccionado

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Obtener el input del aceler�metro si est� seleccionado
        if (tipoControl == TipoControl.Acelerometro)
        {
            float inputY = Input.acceleration.y;
            MoverJugador(inputY);
        }
        // Obtener el input del giroscopio si est� seleccionado
        else if (tipoControl == TipoControl.Giroscopio)
        {
            float inputY = Input.gyro.rotationRateUnbiased.y * sensibilidadGiroscopio;
            MoverJugador(inputY);
        }
    }

    // M�todo para mover al jugador en el eje Y
    void MoverJugador(float inputY)
    {
        // Limitar el valor de inputY al rango especificado (-3.5 a 3.5)
        float inputYClamped = Mathf.Clamp(inputY, -3.5f, 3.5f);

        // Escalar el valor limitado a la velocidad m�xima
        float velocidadY = inputYClamped * velocidadMaxima / 3.5f;

        rb.velocity = new Vector2(0f, velocidadY);
    }
}
