using UnityEngine;

public class HamsterAnimation : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite sprite;

    private bool facingRight = false;

    void FixedUpdate()
    {
        if (Input.GetKey("d"))
        {
            if (facingRight)
            {
                spriteRenderer.flipX = false;
            }

            facingRight = false;
        }

        if (Input.GetKey("a"))
        {
            if (!facingRight)
            {
                spriteRenderer.flipX = true;
            }

            facingRight = true;
        }
    }
}
