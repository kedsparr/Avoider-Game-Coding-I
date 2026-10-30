using UnityEngine;
using UnityEngine.InputSystem;

public class Power : MonoBehaviour
{
    private Rigidbody2D rb;
    public float forcePower;
    public ForceMode2D forceMode;
    private float jumpStatus;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (jumpStatus > float.Epsilon)
        {
            rb.AddForce(Vector2.up * forcePower * Time.fixedDeltaTime, ForceMode2D.Impulse);
        }
        else
        {
            //do nothing

        }
    }
    public void OnPower(InputValue input)
    {
        jumpStatus = input.Get<float>();

        Debug.Log("Force input: " + jumpStatus);
    }
   
  

}
