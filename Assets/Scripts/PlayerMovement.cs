using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float movementForce = 1000f;
    public float jumpForce = 10000f;

    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            Vector2 vForce = new Vector2(movementForce * Time.deltaTime, 0);
            rb.AddForce(vForce);
        }

        if (Input.GetKey("a"))
        {
            Vector2 vForce = new Vector2(-movementForce * Time.deltaTime, 0);
            rb.AddForce(vForce);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (Input.GetKey("space"))
        {
            Vector2 vForce = new Vector2(0, jumpForce * Time.deltaTime);
            rb.AddForce(vForce);
        }
    }
}
