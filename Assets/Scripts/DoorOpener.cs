using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    public float dist;
    public GameObject display;
    public GameObject text;
    public GameObject LeftDoor;
    public GameObject RightDoor;

    void Update()
    {
        dist = PlayerCasting.distFromTarget;
    }

    void OnMouseOver()
    {
        if (dist <= 3)
        {
            display.SetActive(true);
            text.SetActive(true);
            if (Input.GetButtonDown("Action"))
            {
                this.GetComponent<BoxCollider>().enabled = false;
                display.SetActive(false);
                text.SetActive(false);
                LeftDoor.GetComponent<Animator>().Play("LeftDoor");
                RightDoor.GetComponent<Animator>().Play("RightDoor");
            }
        }
        else
        {
            display.SetActive(false);
            text.SetActive(false);
        }
    }

    private void OnMouseExit()
    {
        display.SetActive(false);
        text.SetActive(false);
    }
}
