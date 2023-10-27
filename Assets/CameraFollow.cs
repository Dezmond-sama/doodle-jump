using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float speed = .15f;
    private Vector3 currentVelocity;

    private void LateUpdate()
    {
        if (target.position.y > transform.position.y)
        {
            Vector3 pos = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = Vector3.SmoothDamp(transform.position, pos, ref currentVelocity, speed * Time.deltaTime);// Vector3.Lerp(transform.position, pos, speed * Time.deltaTime);
        }
    }
}
