using UnityEngine;
using UnityEngine.UI;

public class PlayerScore : MonoBehaviour
{
    private float pointsP1;
    public GameObject scoreObject;
    private Text t;
    public AudioSource audioSource;

    public void Awake()
    {
        pointsP1 = 0f;
        t = scoreObject.GetComponent<Text>();
        t.text = pointsP1.ToString();
    }

    void OnTriggerEnter2D(Collider2D co)
    {
        if (co.tag == "Pellet")
        {
            pointsP1 += 10f;
            audioSource.Play();
            t.text = pointsP1.ToString();
        }
    }
}
