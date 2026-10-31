using UnityEngine;
using UnityEngine.InputSystem;

public class FollowCamera : MonoBehaviour
{
    public Transform player;
    private float powerStatus;
    private float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (powerStatus < float.Epsilon)
        {
            transform.position = new Vector3(player.position.x + 8.77f, player.position.y + 4.55f, transform.position.z);
        }
        if (powerStatus > float.Epsilon && timer > 1f)
        {
            
            transform.position = new Vector3(player.position.x, player.position.y ,transform.position.z);
        }
    }

    public void OnPower (InputValue input)
    {
        powerStatus = input.Get<float>();
    }
}

