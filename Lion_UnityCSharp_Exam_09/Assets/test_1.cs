using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_1 : MonoBehaviour
{
    float speed = 5;

    void Update()
    {
        //Move();    
        if (transform.position.x < 10)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }
}
