using UnityEngine;

public class FadeIn : MonoBehaviour
{
    private int frames = 0;
    private Color color;

    // Loads Single Player
    void Start()
    {
        color = gameObject.GetComponent<Renderer>().material.color;
    }

    // Fades to black
    void FixedUpdate()
    {
        color.a -= 0.01f;
        gameObject.GetComponent<Renderer>().material.color = color;

        frames++;
        if (frames >= 100)
            Destroy(gameObject);
    }
}