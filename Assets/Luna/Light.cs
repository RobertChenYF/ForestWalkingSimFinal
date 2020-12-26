using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light : MonoBehaviour
{

    public float speed = 0.5f;
    public Vector3 pointA;
    public Vector3 pointB;

    void Update()
    {
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.eulerAngles = Vector3.Lerp(pointA, pointB, time);

    }
}
