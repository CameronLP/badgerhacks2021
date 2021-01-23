using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UpdateTime : MonoBehaviour
{
    public Text time;

    public float timeRemaining;         // Time remaining

    public GameObject fade_menu;        // Fade Menu

    private bool completed = false;
    private int frames = 0;
    private Color color;

    public GameObject GameOver;         // Game Over

    public void Start()
    {
        timeRemaining = 5;
        completed = false;
    }

    void FixedUpdate()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else
        {
            completed = true;
        }

        string timeLeft = Math.Round(timeRemaining, 1).ToString();
        if (!timeLeft.Contains("."))
            timeLeft += ".0";

        time.text = timeLeft;

        if (completed)
        {
            if (frames <= 100)
            {
                color.a += 0.01f;
                fade_menu.GetComponent<Renderer>().material.color = color;
            }

            if (frames > 100 && frames <= 200)
            {
                color.a -= 0.01f;
                fade_menu.GetComponent<Renderer>().material.color = color;
            }

            frames++;

            if (frames == 100)
            {
                Instantiate(GameOver, new Vector3(0, 0, 0), Quaternion.identity);
            }
        }
    }
}
