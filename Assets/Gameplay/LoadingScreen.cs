using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadingScreen : MonoBehaviour
{
    public Slider loadingSlider; // Reference to the slider UI component
    public float loadTime = 10f;  // Time for the slider to fill (in seconds)

    private float elapsedTime = 0f;

    void Start()
    {
        // Initialize slider value to 0
        loadingSlider.value = 0f;
    }

    void Update()
    {
        // Increment elapsed time
        elapsedTime += Time.deltaTime;

        // Calculate the slider value
        loadingSlider.value = Mathf.Clamp01(elapsedTime / loadTime);

        // If the load time is reached, switch to the new scene
        if (elapsedTime >= loadTime)
        {
            SceneManager.LoadScene("FirstScene");
        }
    }
}