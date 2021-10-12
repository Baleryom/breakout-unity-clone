using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed=5f;
    void Update()
    {
        float z = transform.position.z;
        z +=  Input.GetAxis("Horizontal") * Speed * Time.deltaTime;
        transform.position = new Vector3(transform.position.x, transform.position.y, z);
    }
}
