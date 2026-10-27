
using UnityEngine;
using UnityEngine.InputSystem;
public class Move : MonoBehaviour
{
   private Rigidbody2D rb;
    private float moveStatus;
    public float moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMove (InputValue input)
    {
        moveStatus = input.Get<float>(); 
        if (moveStatus > float.Epsilon)
        {
            rb.AddForce(Vector2.up * moveSpeed * Time.fixedDeltaTime, ForceMode2D.Impulse);
        }
    }
}
