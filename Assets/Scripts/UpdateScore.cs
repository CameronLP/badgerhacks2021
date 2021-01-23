using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    private float pointsP1 = 0f;
    public GameObject scoreText;

    private void Awake()
    {
        pointsP1 = 0f;
    }

    public void Reset()
    {
        pointsP1 = 0f;
    }

    public void AddScore()
    {
        pointsP1 += 10;
        scoreText.GetComponent<Text>().text = pointsP1.ToString();
    }
}
