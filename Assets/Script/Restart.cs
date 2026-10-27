using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.InputSystem;

public class Restart : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void OnTriggerEnter2D(Collider2D other)
    {
        gameObject.SetActive(false);
        //if(other.CompareTag("Treat")){Debug.Log}
    }
private void OnMove (InputValue input)
    {
        rb.linearVelocity = input.Get<Vector2>() * moveSpeed;    }
}

