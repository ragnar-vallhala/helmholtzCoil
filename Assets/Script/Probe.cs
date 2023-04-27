using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Probe : MonoBehaviour
{
    int step = 0;
    double field = 0;
    double dist=0;

 

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
        Vector3 r2 = coil2.transform.position - transform.position;
        Vector3 r = (r1 - r2)/2;
        dist =  this.transform.position.z - r.magnitude;
        double magField1 = Mathf.PI * 2 * coil1.getCurrent() * coil1.getRadius() * coil1.getRadius() / Mathf.Pow((r1.sqrMagnitude+ coil1.getRadius() * coil1.getRadius()),1.5f);
        double magField2 = Mathf.PI * 2 * coil2.getCurrent() * coil2.getRadius() * coil2.getRadius() / Mathf.Pow((r2.sqrMagnitude + coil2.getRadius() * coil2.getRadius()), 1.5f);
        field = magField1 + magField2;
        Debug.Log(field);
    }

    public double GetField()
    {
        return field;
    }
    public double GetDist()
    {
        return dist;
    }
}
