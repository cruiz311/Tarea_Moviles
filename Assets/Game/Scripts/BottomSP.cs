using UnityEngine;
using UnityEngine.SceneManagement;

public class BottomSP : MonoBehaviour
{
    public DatosPersonaje datosPersonaje;

    public void OnClickButtom()
    {
        GameManager.Instance.EstablecerPersonaje(datosPersonaje);
        SceneManager.LoadScene("Game");
    }
}
