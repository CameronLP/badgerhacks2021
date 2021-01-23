using UnityEngine;
using UnityEngine.InputSystem;

public class HamsterAnimation : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite sprite;

    private bool facingRight = false;

    private bool left;
    private bool right;

    public InputActionAsset playerControls;
    private InputAction l;
    private InputAction r;

    private void Awake()
    {
        var gameplayActionMap = playerControls.FindActionMap("Player");

        l = gameplayActionMap.FindAction("Left");
        l.performed += ctx => Left();
        l.canceled += ctc => LeftCancelled();

        r = gameplayActionMap.FindAction("Right");
        r.started += ctx => Right();
        r.canceled += ctc => RightCancelled();
    }

    void Left()
    {
        left = true;
    }

    void LeftCancelled()
    {
        left = false;
    }

    void Right()
    {
        right = true;
    }

    void RightCancelled()
    {
        right = false;
    }

    void FixedUpdate()
    {
        if (left)
        {
            if (!facingRight)
            {
                spriteRenderer.flipX = true;
            }

            facingRight = true;
        }

        if (right)
        {
            if (facingRight)
            {
                spriteRenderer.flipX = false;
            }

            facingRight = false;
        }
    }
}
