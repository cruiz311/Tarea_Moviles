using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChngeScene:MonoBehaviour
{

    public void ChangeSceneManual(string text)
    {
        SceneManager.LoadScene(text);
    }
}
