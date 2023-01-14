using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenuControlsComponent : MonoBehaviour
{
    private bool isFullScreen;

    private void Start()
    {
        isFullScreen = false;
    }

    public void FullScreenToggle()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }
}
