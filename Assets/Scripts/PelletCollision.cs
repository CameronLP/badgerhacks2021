using UnityEngine;

public class PelletCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D co)
    {
        Destroy(gameObject);
    }
}
