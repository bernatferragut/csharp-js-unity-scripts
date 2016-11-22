// This script has been inspired by Matthew Hallberg

using UnityEngine;
using Syste.Collections;

public class WalkController : MonoBehaviour
{
    private bool walking = true;
    private vector3 startingPoint;

    void Start()
    {
        startingPoint = transform.position;
    }

    void Update()
    {
        if (walking)
        {
            transform.position = transform.position + Camera.main.transform.forward * .5f * Time.deltaTime;
        }

        if (transform.position < -10f)
        {
            Ray ray = Camera.main.ViewportPointToRay ( new vector3(.5f, .5f, 0));
            RayCastHit hit;
        }
        if (Physics.Raycast (ray, out hit))
        {
            if (hit.collider.name.Contains("plane"))
            {
                walking = false;
            } 
            else 
            {
                walking = true;x
            }
        }

    }

}