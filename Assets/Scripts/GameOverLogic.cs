using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverLogic : MonoBehaviour
{
    private GameObject p1;
    private GameObject p1TimeText;
    private GameObject p1ScoreText;
    private GameObject p1FinalScore;

    private GameObject p2;
    private GameObject p2TimeText;
    private GameObject p2ScoreText;
    private GameObject p2FinalScore;

    private string FinalScoreP1;
    private string FinalScoreP2;

    public InputActionAsset playerControls;
    private InputAction enter;

    void Start()
    {
        try
        {
            p1 = GameObject.Find("hamster_ball_p1");
            p2 = GameObject.Find("hamster_ball_p2");

            p1TimeText = GameObject.Find("Time_p1");
            p2TimeText = GameObject.Find("Time_p2");

            p1ScoreText = GameObject.Find("ScoreText_p1");
            p2ScoreText = GameObject.Find("ScoreText_p2");

            p1FinalScore = GameObject.Find("FinalScore_p1");
            p2FinalScore = GameObject.Find("FinalScore_p2");

            // Player 1
            p1.GetComponent<Transform>().position = new Vector3(116, -7, 0);
            FinalScoreP1 = p1ScoreText.GetComponent<Text>().text;
            Destroy(p1TimeText);
            Destroy(p1ScoreText);
            p1FinalScore.GetComponent<Text>().text = "Final Score: " + FinalScoreP1 + "\nPress Enter";
            Debug.Log("Final Score: " + FinalScoreP1);

            // Player 2
            if (p2 != null)
            {
                p2.GetComponent<Transform>().position = new Vector3(116, -3, 0);
                FinalScoreP2 = p2ScoreText.GetComponent<Text>().text;
                Destroy(p2TimeText);
                Destroy(p2ScoreText);
                p2FinalScore.GetComponent<Text>().text = "Final Score: " + FinalScoreP2 + "\nPress Enter";
                Debug.Log("Final Score (Player 2): " + FinalScoreP2);
            }
        }
        catch (Exception) { }

        // Exit
        var gameplayActionMap = playerControls.FindActionMap("Player");

        enter = gameplayActionMap.FindAction("Enter");
        enter.performed += ctx => ExitToMain();
    }

    private void ExitToMain()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
