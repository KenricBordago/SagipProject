using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void OnPlayButtonClicked()
    {
        // Load the Loading Screen scene
        SceneManager.LoadScene("LoadingScreen");
    }
}