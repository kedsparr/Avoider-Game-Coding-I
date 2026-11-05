using JetBrains.Annotations;
using UnityEngine;

public class StartPosition : MonoBehaviour
{
    public float Positionx;
    public float Positiony;

    private float timer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(Positionx, Positiony);
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
       
    }
}
