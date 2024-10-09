using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    // Public variable to adjust movement speed
    public float moveSpeed = 5f;

    // Reference to the player's Rigidbody2D component
    private Rigidbody2D rb;

    // Movement input
    private Vector2 movementInput;

    void Start()
    {
        // Get the Rigidbody2D component attached to this game object
        rb = GetComponent<Rigidbody2D>();

        // Ensure Rigidbody2D is set to "Interpolate" for smoother movement
        rb.interpolation = RigidbodyInterpolation2D.Interpolate;
    }

    void Update()
    {
        // Get player input from keyboard
        float moveX = Input.GetAxisRaw("Horizontal");  // Use GetAxisRaw for more immediate stop
        float moveY = Input.GetAxisRaw("Vertical");

        // Calculate movement vector based on input
        movementInput = new Vector2(moveX, moveY).normalized * moveSpeed;
    }

    void FixedUpdate()
    {
        // If there's no input, stop movement
        if (movementInput == Vector2.zero)
        {
            rb.velocity = Vector2.zero;  // Stop any velocity to prevent sliding
        }
        else
        {
            // Apply movement to the player using Rigidbody2D
            rb.MovePosition(rb.position + movementInput * Time.fixedDeltaTime);
        }
    }
}
