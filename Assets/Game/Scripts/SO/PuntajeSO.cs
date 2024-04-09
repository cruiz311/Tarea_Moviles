using UnityEngine;

[CreateAssetMenu(fileName = "NuevoPuntaje", menuName = "ScriptableObjects/Puntaje")]
public class PuntajeSO : ScriptableObject
{
    public int puntaje;
    public int puntajeMax;

    public void ActualizarPuntaje(int puntajeObtenido)
    {
        if (puntajeObtenido > puntajeMax)
        {
            puntajeMax = puntajeObtenido;
            puntaje = 0;
        }
    }
}
