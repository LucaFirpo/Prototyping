using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Distanza = 10;
    
    public Vector3 partenza;

    private void Start()
    {
        partenza = this.transform.position;
    }

    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position = new Vector3(partenza.x + Distanza, partenza.y, partenza.z);
        }
        else if(Input.GetKey(KeyCode.A))
        {
            this.transform.position = new Vector3(partenza.x - Distanza, partenza.y, partenza.z);
        }
        else
        {
            this.transform.position = partenza;
        }
    }
}
