using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public Transform target;
    public float smoothValue;
    public float yOffset = 0f;
    public float xOffset = 0f;
    public float xVelocity = 0.0f;
    public float yVelocity = 0.0f;


    void LateUpdate()
    {
        float newX = Mathf.SmoothDamp(transform.position.x , target.position.x + xOffset, ref xVelocity, smoothValue);
        float newY = Mathf.SmoothDamp(transform.position.y + yOffset, target.position.y + yOffset, ref yVelocity, smoothValue);

        transform.position = new Vector3(newX, newY, 0);
    }

}
