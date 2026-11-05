using UnityEngine;
using UnityEngine.InputSystem;

public class Power : MonoBehaviour
{
    private Rigidbody2D rb;
    public float forcePower;

    public float dropPower;
    public ForceMode2D forceMode;

    public ForceMode2D fM;
    private float jumpStatus;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (jumpStatus > float.Epsilon)
        {
            rb.AddForce(Vector2.up * forcePower * Time.fixedDeltaTime, forceMode);
        }
        else if (jumpStatus < -float.Epsilon)
        {
            rb.gravityScale = 0.5f;
            rb.AddForce(Vector2.down * dropPower  * Time.fixedDeltaTime, fM);
        }
    }

    public void OnPower(InputValue input)
    {
        jumpStatus = input.Get<float>();
    }
}