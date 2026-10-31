using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;

    public float forcePower;
    public float moveSpeed;

    private float jumpStatus;
    private float moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
       
        rb.linearVelocity = new Vector2(
            moveInput * moveSpeed,
            rb.linearVelocity.y );

        if (jumpStatus > float.Epsilon)
        {
            rb.AddForce(Vector2.up * forcePower, ForceMode2D.Impulse);
            jumpStatus = 0;
        }
    }

    public void OnMove(InputValue input)
    {
        moveInput = input.Get<float>();
    }
}
   