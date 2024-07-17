using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void Exit()
    {
        // If running in the Unity editor, stop play mode
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
            // If running in a built application, quit the application
            Application.Quit();
#endif
    }
}
