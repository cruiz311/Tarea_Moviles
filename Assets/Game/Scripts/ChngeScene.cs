using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChngeScene:MonoBehaviour
{
    public SceneGlobalManager SceneGlobalManager;

    private void Start()
    {
        SceneGlobalManager = SceneGlobalManager.Instance;
    }
    public void ChangeSceneManual(string text)
    {
        SceneGlobalManager.changeScene(text);
        GameManager.Instance.Game();
    }
}
