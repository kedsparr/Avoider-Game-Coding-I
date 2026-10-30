
using UnityEngine;
using UnityEngine.InputSystem;
public class AD : MonoBehaviour
{
 
   private float moveStatus;
   public float moveSpeed;
    private Vector2 movement;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (moveStatus > float.Epsilon)
        {
            transform.position += new Vector3(movement.x, movement.y, 0) * moveSpeed * Time.deltaTime;
        }
    }
    private void OnAD (InputValue input)
    {
        moveStatus = input.Get<float>(); 
       
    }
}
