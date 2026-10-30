using JetBrains.Annotations;
using UnityEngine;

public class StartPosition : MonoBehaviour
{
    public float Positionx;
    public float Positiony;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.position = new Vector3(Positionx, Positiony);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
