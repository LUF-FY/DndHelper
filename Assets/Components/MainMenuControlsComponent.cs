using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuControlsComponent : MonoBehaviour
{
    public void ButtonStartPressed()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ButtonExitPressed()
    {
        Debug.Log("Exit pressed!");
        Application.Quit();
    }
}
