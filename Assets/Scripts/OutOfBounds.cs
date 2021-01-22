using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public new GameObject gameObject;   // Hamster
    public Vector2 vector2;             // Position we want to reset Hamster

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Resets position
        gameObject.transform.position = vector2;

        // Resets momentum
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }
}
