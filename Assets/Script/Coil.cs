using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Coil : MonoBehaviour
{
    
    [SerializeField] private float current = 2.0f;
    [SerializeField] private float radius = 20.0f;


    void Update()
    {
        if (transform.position.x != 0 || transform.position.y != 0)
        {
            Vector3 newPos = new Vector3(0, 0, transform.position.z);
            transform.position = newPos;

        }
    }

    public float getCurrent()
    {
        return current;
    }

    public float getRadius()
    {
        return radius;
    }
}
