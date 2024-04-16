using UnityEngine;

public class Player : MonoBehaviour
{
    private SceneGlobalManager sceneGlobalManager;
    public VidaSO vidaSO;
    public PuntajeSO puntajeSO;
    public DatosPersonaje datospersonaje;
    public balaOP balas;
    public bool lost = false;
    private float Timer;
    public float fireRate = 0.5f; // Tasa de disparo en segundos
    private float nextFireTime; // Tiempo para el próximo disparo

    void Start()
    {
        balas = GetComponent<balaOP>();
        datospersonaje = GameManager.Instance.ObtenerDatosPersonaje();
        vidaSO.vidas = datospersonaje.vida;
        nextFireTime = 0f; // Inicializa el tiempo para el próximo disparo
        sceneGlobalManager = SceneGlobalManager.Instance;
    }

    void Update()
    {
        if (vidaSO.vidas <= 0 && !lost)
        {
            lost = true;
            puntajeSO.ActualizarPuntaje(puntajeSO.puntaje);
            sceneGlobalManager.changeSceneAsyncAditivo("LoseScene");

        }

        if (Input.GetMouseButton(0) && Time.time > nextFireTime)
        {
            Disparar(); // Llama al método Disparar() cuando se presiona el botón del ratón
            nextFireTime = Time.time + fireRate; // Actualiza el tiempo para el próximo disparo
        }

        Timer += Time.deltaTime;
        if (Timer > 1.0f)
        {
            puntajeSO.puntaje++;
            Timer = 0;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("enemy") || collision.gameObject.CompareTag("Basura"))
        {
            vidaSO.vidas--;
            EnemyPool.ReturnEnemy(collision.gameObject);
        }
    }

    void Disparar()
    {
        GameObject bala = balas.GetBullet(); // Obtiene una bala del pool
        if (bala != null)
        {
            bala.transform.position = transform.position; // Establece la posición de la bala al jugador
            bala.SetActive(true); // Activa la bala
        }
    }
}
