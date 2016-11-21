// Creating Objects using References
using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public interface GeneralAnimationScript : MonoBehaviour
{
    void Start(){}
    //We create a variable that can handle any object
    public GameObject objectToCreate;

    void Update()
    {   //Reference creator
        // Object.Instantiate(objectToCreate, new vector3(2,4,6), Quaternion.identity);
        for (i=0,i<100, i++)
        {
            GameObject newSeagull = (GameObject)Object.Instantiate(objectToCreate, new vector3(i, 4, 6), Quaternion.identity); // this qauternion means no rotation
            Renderer objectRenderer = newSeagull.GetComponentInChildren<Renderer>();
            objectRenderer.material.color = Color.white * Random.value;
        }
    }
    void Update(){}
}