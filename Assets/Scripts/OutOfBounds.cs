using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public Vector2 vector2;             // Position we want to reset Hamster

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Resets position
        collision.gameObject.transform.position = vector2;

        // Resets momentum
        collision.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
    }
}
