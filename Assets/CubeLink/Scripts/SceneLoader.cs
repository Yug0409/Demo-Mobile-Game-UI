using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string sceneToLoad;

    public void LoadScene()
    {
        StartCoroutine(LoadSceneWithDelay());
    }

    private System.Collections.IEnumerator LoadSceneWithDelay()
    {
        yield return new WaitForSeconds(1f); // 1 second delay
        SceneManager.LoadScene(sceneToLoad);
    }
}
