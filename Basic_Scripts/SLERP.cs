using UnityEngine;
using System.Collections;

public class RotateStuff : MonoBehaviour
{
    public GameObject myObject;

    //initialization
    void Start(){}

    //update
    void Update()
    {
    Quaternion startRotation = Quaternion.Euler(50f, 30f, 0f);
    Quaternion endRotation = Quaternion.Euler(0f,100f, 0f);
    myObject.transform.rotation = Quaternion.Slerp(startRotation, endRotation, Time.time / 100);
    }
}