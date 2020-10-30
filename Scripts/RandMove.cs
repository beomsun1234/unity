using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandMove : MonoBehaviour
{
    Vector3 cube;
    public float moveSpeed;
    public float maxValue;
    public float minValue;
    public Vector3 default_direction;

    void Start()
    {
        cube = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        cube.x += moveSpeed * Time.deltaTime;
        transform.position = cube;
        if(transform.position.x > maxValue || transform.position.x < minValue)
        {
            moveSpeed *= -1;
        }
    }

 
}
