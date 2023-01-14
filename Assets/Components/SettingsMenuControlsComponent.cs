using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingsMenuControlsComponent : MonoBehaviour
{
    private bool isFullScreen;

    private void Start()
    {
        isFullScreen = true;
    }

    public void FullScreenToggle()
    {
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
    }
}
