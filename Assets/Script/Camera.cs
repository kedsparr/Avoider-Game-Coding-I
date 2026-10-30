using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x + 8.77f, player.position.y + 4.45f, transform.position.z);
    }
}
