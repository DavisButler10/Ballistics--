using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameObject oldTarget;
    Aim aim;
    public bool hit;
    Vector3 location;
    Vector3 newLocation;
    
    void Start()
    {
        hit = false;
    }

    void Update()
    {
        aim = GameObject.FindObjectOfType<Aim>();
        //Debug.Log(hit);
        if (hit)
        {
            
            hit = false;

            float[] vectorArray = {0f, 0f, 0f};
            
            for(int i = 0; i < 3; i++)
            {
                int j = Random.Range(0, 2);
                if(j == 0)
                {
                    vectorArray[i] = Random.Range(-0.8f, -1f);
                }
                else
                {
                    vectorArray[i] = Random.Range(0.8f, 1f);
                }
            }
            Debug.Log(vectorArray[0]);
            Debug.Log(vectorArray[1]);
            Debug.Log(vectorArray[2]);
            Vector3 vector = new Vector3(vectorArray[0], vectorArray[1], vectorArray[2]);
            Debug.Log(vector);
            location = oldTarget.transform.position + vector * 6f;
            newLocation = new Vector3(location.x, -1.3f, location.z);
            oldTarget.transform.position = newLocation;
            aim.Reset();
        }
    }
}
