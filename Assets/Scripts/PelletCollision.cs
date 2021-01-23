using UnityEngine;

public class PelletCollision : MonoBehaviour
{
    public GameObject gameScore;

    void OnTriggerEnter2D(Collider2D co)
    {
        Destroy(gameObject);
    }
}
