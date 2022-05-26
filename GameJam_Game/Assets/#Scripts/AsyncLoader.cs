using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsyncLoader : MonoBehaviour
{
    private string nextSceneToLoad;
    public static AsyncLoader asyncLoad;
    private void Awake()
    {
        if (asyncLoad == null)
        {
            DontDestroyOnLoad(gameObject);
            asyncLoad = this;
        }
        else if (asyncLoad != this)
        {
            Destroy(gameObject);
        }
    }
    public void LoadAsync(string scene)
    {
        nextSceneToLoad = scene;
        StartCoroutine(LoadYourAsyncScene());
    }
    IEnumerator LoadYourAsyncScene()
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(nextSceneToLoad);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
}
