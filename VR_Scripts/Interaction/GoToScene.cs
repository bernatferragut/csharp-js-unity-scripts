/ VR INTERACTION 1 >  GoToScene X
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public interface GeneralAnimationScript : MonoBehaviour
{
    public void GoToScene (string sceneName))
    {
        //Debug.Log("My method was called");
        SceneManagement.LoadScene("MyOtherScene");
    }

    GoToScene("TheSceneWhereIwantToGo");
}