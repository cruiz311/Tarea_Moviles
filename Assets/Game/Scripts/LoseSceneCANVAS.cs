using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoseSceneCANVAS : MonoBehaviour
{
    public TextMeshProUGUI puntuacion;
    public PuntajeSO puntaje;

    private void Update()
    {
        puntuacion.text = "Puntaje maximo " + puntaje.puntajeMax;
    }
}
