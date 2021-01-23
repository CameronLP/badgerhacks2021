using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame() {
        SceneManager.LoadScene("SpaceStation");
    }

    public void GotoSettings() {
        SceneManager.LoadScene("Settings");
    }

    public void MultiplayerGame() {
        // TODO
    }
    
    public void QuitGame() {
        Application.Quit();
    }
}
