using UnityEngine;
using UnityEngine.SceneManagement;

public class click_single_player : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    // Loads Single Player
    void OnMouseDown()
    {
        SceneManager.LoadScene("Playground");
    }
}