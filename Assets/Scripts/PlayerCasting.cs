using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCasting : MonoBehaviour
{

    public static float distFromTarget;
    public float toTarget;


    private void Start()
    {
        
    }

    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
        {
            Debug.DrawRay(transform.position, transform.forward * 100, Color.green);
            toTarget = hit.distance;
            distFromTarget = hit.distance;
        }

        if (hit.collider != null)
        {
            Debug.Log(hit.collider.gameObject.name);
            CheckGameObject(hit.collider.gameObject);
        }

        
    }

    private void CheckGameObject(GameObject gameObject)
    {
        if (gameObject.tag == "body_Target")
        {
            
        }
        

        else if (gameObject.tag == "head_Target")
        {
            
        }

        else
        {
            
        }
    }

}
