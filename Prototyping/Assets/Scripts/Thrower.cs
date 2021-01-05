using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thrower : MonoBehaviour
{
    public Transform Start;

    public Transform Destination;

    public float Speed;

    private void Update()
    {
        if (transform.position == Destination.position)
            transform.position = Start.position;
    }

    public void Throw()
    {
        transform.position = Vector3.MoveTowards(transform.position, Destination.position, Speed*Time.deltaTime);
    }
}