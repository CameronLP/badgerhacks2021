using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ClickSinglePlayer : MonoBehaviour
{
    public new GameObject gameObject;

    private bool clicked = false;
    private int frames = 0;
    private Color color;

    public InputActionAsset playerControls;
    private InputAction s;

    private void Awake()
    {
        var gameplayActionMap = playerControls.FindActionMap("Player");

        s = gameplayActionMap.FindAction("Select");
        s.performed += ctx => Selected();
    }

    // Whenever a mouse is clicked, this will trigger
    void Selected()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

        if (hit)
        {
            switch (hit.transform.name.ToString())
            {
                case "menu_single_player":
                    clicked = true;
                    color = gameObject.GetComponent<Renderer>().material.color;
                    break;
                case "menu_multiplayer":
                    clicked = true;
                    color = gameObject.GetComponent<Renderer>().material.color;
                    break;
                case "menu_settings":
                    clicked = true;
                    color = gameObject.GetComponent<Renderer>().material.color;
                    break;
            }
        }
    }

    // Fades to black
    void FixedUpdate()
    {
        if (clicked)
        {
            color.a += 0.01f;
            gameObject.GetComponent<Renderer>().material.color = color;

            frames++;
            if (frames >= 100)
                SceneManager.LoadScene("Playground");
        }
    }
}
