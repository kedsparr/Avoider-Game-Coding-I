using System.Runtime.CompilerServices;
using UnityEditor.Build.Reporting;
using UnityEngine;
using UnityEngine.InputSystem;

public class FollowCamera : MonoBehaviour
{
    public float minpos;
    public float maxpos;
    private float TargetY;
    public Transform target;
    void Start()
    {
       
    }
    void LateUpdate()
    {
        TargetY = target.position.y;
        TargetY = Mathf.Clamp(TargetY, minpos, maxpos);
        transform.position = new Vector3( transform.position.x, TargetY, transform.position.z );
    }
}

