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

    public bool SinglePlayer;
    public bool P2;

    private void Awake()
    {
        var gameplayActionMap = playerControls.FindActionMap("Player");

        // Multiplayer
        if (!P2 || SinglePlayer)
        {
            l = gameplayActionMap.FindAction("Left");
            l.performed += ctx => Left();
            l.canceled += ctc => LeftCancelled();

            r = gameplayActionMap.FindAction("Right");
            r.started += ctx => Right();
            r.canceled += ctc => RightCancelled();
        }

        if (P2 || SinglePlayer)
        {
            l = gameplayActionMap.FindAction("LeftP2");
            l.performed += ctx => Left();
            l.canceled += ctc => LeftCancelled();

            r = gameplayActionMap.FindAction("RightP2");
            r.started += ctx => Right();
            r.canceled += ctc => RightCancelled();
        }
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
