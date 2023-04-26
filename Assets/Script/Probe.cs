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

        Coil[] obj = GameObject.FindObjectsOfType<Coil>();
        Coil coil1 = obj[0];
        Coil coil2 = obj[1];

        Vector3 r1 = coil1.transform.position - transform.position;

        double i1 = coil1.getCurrent();

        double magField1 = 3.14 * 2 * coil1.getCurrent() * coil1.getRadius() * coil1.getRadius() / Mathf.Pow((r1.sqrMagnitude+ coil1.getCurrent() * coil1.getRadius()),1.5f);

        Debug.Log(magField1);
    }
}
