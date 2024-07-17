using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Function called when the button is clicked
    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}