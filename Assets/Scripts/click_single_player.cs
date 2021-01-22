using UnityEngine;
using UnityEngine.SceneManagement;

public class click_single_player : MonoBehaviour
{
    public GameObject gameObject;
    private bool clicked = false;
    private int frames = 0;
    private Color color;

    // Loads Single Player
    void OnMouseDown()
    {
        clicked = true;
        color = gameObject.GetComponent<Renderer>().material.color;
    }

    // Fades to black
    void Update()
    {
        if (clicked)
        {
            color.a += 0.001f;
            gameObject.GetComponent<Renderer>().material.color = color;

            frames++;
            if (frames >= 1000)
                SceneManager.LoadScene("Playground");
        }
    }
}