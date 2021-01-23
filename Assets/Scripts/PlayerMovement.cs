using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float movementForce = 1000f;
    public float jumpForce = 10000f;

    private bool left;
    private bool right;
    private bool jump;

    public InputActionAsset playerControls;
    private InputAction l;
    private InputAction r;
    private InputAction j;

    private void Awake()
    {
        var gameplayActionMap = playerControls.FindActionMap("Player");

        l = gameplayActionMap.FindAction("Left");
        l.performed += ctx => Left();
        l.canceled += ctc => LeftCancelled();

        r = gameplayActionMap.FindAction("Right");
        r.started += ctx => Right();
        r.canceled += ctc => RightCancelled();

        j = gameplayActionMap.FindAction("Jump");
        j.performed += ctx => Jump();
        j.canceled += ctc => JumpCancelled();

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

    void Jump()
    {
        jump = true;
    }

    void JumpCancelled()
    {
        jump = false;
    }

    void FixedUpdate()
    {
        if (left)
        {
            Vector2 vForce = new Vector2(-movementForce * Time.deltaTime, 0);
            rb.AddForce(vForce);
        }

        if (right)
        {
            Vector2 vForce = new Vector2(movementForce * Time.deltaTime, 0);
            rb.AddForce(vForce);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (jump)
        {
            Vector2 vForce = new Vector2(0, jumpForce * Time.deltaTime);
            rb.AddForce(vForce);
        }
    }
}
