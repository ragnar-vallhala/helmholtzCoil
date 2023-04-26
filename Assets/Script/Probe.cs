using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Probe : MonoBehaviour
{
    [SerializeField] private int step = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            step = - 1;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            step = 1;
        }
        else
        {
            step = 0;
        }
        Vector3 vec = new Vector3(0, 0, transform.position.z + step);
        transform.position = vec;
    }
}
