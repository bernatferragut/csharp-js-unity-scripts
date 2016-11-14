//which part of unity are we using
using UnityEngine;
using System.Collections;

//class creation
public class ExampleBehaviourScript : MonoBehaviour;
{
    void Update(){
        if(Input.GetKeyDown(KeyCode.R)){
            GetComponent<Renderer>().material.color = Color.red;
        }
        if(Input.GetKeyDown(KeyCode.B)){
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if(Input.GetKeyDown(KeyCode.G)){
            GetComponent<Renderer>().material.color = Color.green;
        }
    }
}

