using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelEnd : MonoBehaviour
{
    public new GameObject gameObject;   // Hamster

    public GameObject fade_menu;        // Fade Menu

    private bool completed = false;
    private int frames = 0;
    private Color color;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        completed = true;
    }

    // Fades to black
    void FixedUpdate()
    {
        if (completed)
        {
            color.a += 0.01f;
            fade_menu.GetComponent<Renderer>().material.color = color;

            frames++;
            if (frames >= 100)
                SceneManager.LoadScene("SpaceStation");
        }
    }
}
