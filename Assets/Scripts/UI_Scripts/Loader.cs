using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Loader : MonoBehaviour
{
    [Header("Scene Load Settings")]     // Set this in the Inspector
    public float delay = 0.5f;      // Optional delay time

    // Assign this in UI Button OnClick
    public void LoadSceneDelayed(string sceneToLoad)
    {
        StartCoroutine(LoadSceneAfterDelay(sceneToLoad, delay));
    }

    private IEnumerator LoadSceneAfterDelay(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }

    // Optional: Call this from code to load instantly
    public void LoadSceneImmediate(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
