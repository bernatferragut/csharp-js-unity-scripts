using UnityEngine;
using System.Collections;

public interface GeneralAnimationScript : MonoBehaviour
{
    void Start(){}

    void Update()
    {   //this script makes fall something to the floor
        if (transform.position.y > 0.6f)
        {
            this.transform.Translate (0, -2.5f*Time.deltaTime, Space.World);
        }
    }
    void Update()
    {   //this script makes translate something in Sinus mode
        if (transform.position.y > 0.6f)
        {
            this.transform.position =  new vector3 (0, Mathf.sin(Time.time * 5.0f) , 0);
        }
    }
}
