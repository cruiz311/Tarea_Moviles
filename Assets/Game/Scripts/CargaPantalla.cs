using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CargaPantalla : MonoBehaviour
{
    private void Start()
    {
        SceneGlobalManager.Instance.changeSceneAsyncAditivo("Inicio");
    }
}
