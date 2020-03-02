using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    public float myTimeScale = 1.0f;
    public GameObject target;
    public float launchForce = 10f;

    Rigidbody rb;

    void Start()
    {
        Time.timeScale = myTimeScale;
        rb = GetComponent<Rigidbody>();

        FiringSolution fs = new FiringSolution();
        Nullable<Vector3> aimVector = fs.Calculate(transform.position, target.transform.position, launchForce, Physics.gravity);

        if (aimVector.HasValue)
        {
            rb.AddForce(aimVector.Value.normalized * launchForce , ForceMode.VelocityChange);
        }
    }

    public void Reset()
    {
        rb.velocity = Vector3.zero;
        FiringSolution fs = new FiringSolution();
        Nullable<Vector3> aimVector = fs.Calculate(transform.position, target.transform.position, launchForce, Physics.gravity);

        if (aimVector.HasValue)
        {
            rb.AddForce(aimVector.Value.normalized * launchForce , ForceMode.VelocityChange);
        }
    }
}
