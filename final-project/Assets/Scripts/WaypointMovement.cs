using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointMovement : MonoBehaviour
{
    Vector3 movePosition = new Vector3(-75f, 1.7f, -75f);
    public float speed = 5f;

    void Start()
    {

    }

    void Update()
    {
        if (transform.position != movePosition)
        {
            Vector3 newPos = Vector3.MoveTowards(transform.position, movePosition, speed * Time.deltaTime);
            transform.position = newPos;
        }
    }
}
