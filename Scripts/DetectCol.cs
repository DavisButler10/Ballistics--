using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCol : MonoBehaviour
{
    Target target;

    private void Update()
    {
        target = GameObject.FindObjectOfType<Target>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Dart")
        {
            target.hit = true;
        }
    }
}




