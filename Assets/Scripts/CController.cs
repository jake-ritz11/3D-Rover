using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CController : MonoBehaviour
{

    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private void LateUpdate()
    {
        Vector3 desiredPostion = target.position + offset;
        Vector3 smoothPostion = Vector3.Lerp(transform.position, desiredPostion, smoothSpeed);
        transform.position = smoothPostion;
    }

}
