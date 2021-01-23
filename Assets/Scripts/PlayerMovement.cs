using System;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    public float movementForce = 1000f;
    public float jumpForce = 12000f;

    private bool left;
    private bool right;
    private bool jump;

    public InputActionAsset playerControls;
    private InputAction l;
    private InputAction r;
    private InputAction j;

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

            j = gameplayActionMap.FindAction("Jump");
            j.performed += ctx => Jump();
            j.canceled += ctc => JumpCancelled();
        }

        if (P2 || SinglePlayer)
        {
            l = gameplayActionMap.FindAction("LeftP2");
            l.performed += ctx => Left();
            l.canceled += ctc => LeftCancelled();

            r = gameplayActionMap.FindAction("RightP2");
            r.started += ctx => Right();
            r.canceled += ctc => RightCancelled();

            j = gameplayActionMap.FindAction("JumpP2");
            j.performed += ctx => Jump();
            j.canceled += ctc => JumpCancelled();
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
        //Keep this for reference:
        //if ((jump) && (Math.Abs(collision.GetContact(0).normal[0]) < 0.99))
        //{
        //    Vector2 vForce = new Vector2(0, jumpForce * Time.deltaTime);
        //    rb.AddForce(vForce);
        //}

        if (jump && (left || right))
        {
            Vector2 vForce1 = new Vector2(0, jumpForce * Time.deltaTime);
            Vector2 vForce2 = new Vector2(collision.GetContact(0).normal[0], collision.GetContact(0).normal[1]);
            Vector2 vForce = Vector2.Scale(vForce1, vForce2);
            rb.AddForce(vForce);
        }

        if (jump && !left && !right)
        {
            Vector2 vForce1 = new Vector2(jumpForce * Time.deltaTime, jumpForce * Time.deltaTime);
            Vector2 vForce2 = new Vector2(collision.GetContact(0).normal[0], collision.GetContact(0).normal[1]);
            Vector2 vForce = Vector2.Scale(vForce1, vForce2);
            rb.AddForce(vForce);
        }
    }
}
