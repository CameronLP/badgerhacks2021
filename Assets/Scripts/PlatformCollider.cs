using UnityEngine;

public class PlatformCollider : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite defaultSprite;
    public Sprite newSprite;

    //
    // On collision, change sprite
    void OnCollisionEnter2D(Collision2D collision)
    {
        spriteRenderer.sprite = newSprite;
    }

    //
    // After collision, change sprite
    private void OnCollisionExit2D(Collision2D collision)
    {
        spriteRenderer.sprite = defaultSprite;
    }
}
