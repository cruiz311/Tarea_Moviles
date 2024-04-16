using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SceneGlobalManager : MonoBehaviour
{
    private static SceneGlobalManager _instance;
    public static SceneGlobalManager Instance { get { return _instance; } }

    private void Awake()
    {   
        if (_instance != null && _instance != this)
        {
            Destroy(gameObject);
            return;
        }
        _instance = this;

        DontDestroyOnLoad(gameObject);
    }
    public void changeSceneAsyncAditivo(string sceneName)
    {
        StartCoroutine(changeSceneAsyncCorutina(sceneName));
    }

    private IEnumerator changeSceneAsyncCorutina(string sceneName)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    public void changeSceneAsync(string sceneName)
    {
        SceneManager.UnloadSceneAsync(sceneName);
    }

    public void changeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
