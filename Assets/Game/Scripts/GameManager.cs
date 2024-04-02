using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;
    public static GameManager Instance { get { return _instance; } }

    public int puntos = 0;
    private float puntosganados;

    private DatosPersonaje datosPersonaje;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Update()
    {

    }

    public int ObtenerPuntaje()
    {
        puntosganados += Time.deltaTime;
        return Mathf.FloorToInt(puntosganados);
    }

    public void changeScene(string nombreScena)
    {
        SceneManager.LoadScene(nombreScena);
    }

    public void EstablecerPersonaje(DatosPersonaje datos)
    {
        datosPersonaje = datos;
    }

    public DatosPersonaje ObtenerDatosPersonaje()
    {
        return datosPersonaje;
    }
}
