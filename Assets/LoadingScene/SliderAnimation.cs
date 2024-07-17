using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SliderAnimation : MonoBehaviour
{
    public float animationDuration = 5f; // Total animation duration in seconds
    public string nextSceneName; // Name of the scene to load after animation

    private Slider slider;
    private float timer = 0f;
    private bool isAnimationComplete = false;

    void Start()
    {
        slider = GetComponent<Slider>();
        slider.value = 0f; // Start with slider at 0
    }

    void Update()
    {
        if (!isAnimationComplete)
        {
            timer += Time.deltaTime;

            // Calculate current scale value based on time
            float currentScaleX = Mathf.Lerp(0f, 5f, timer / animationDuration);

            // Update slider value based on current scale
            slider.value = currentScaleX;

            // If animation is complete, stop updating
            if (timer >= animationDuration)
            {
                isAnimationComplete = true;
                LoadNextScene();
            }
        }
    }

    void LoadNextScene()
    {
        // Load the next scene by name
        SceneManager.LoadScene(nextSceneName);
    }
}