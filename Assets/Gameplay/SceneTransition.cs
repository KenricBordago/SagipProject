using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    // This method will be called when the button is clicked
    public void LoadSecondScene()
    {
        SceneManager.LoadScene("SecondScene");
    }
}
