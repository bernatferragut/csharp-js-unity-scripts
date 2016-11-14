
// Finding an object script
// ***************************************

using UnityEngine;
using System.Collections;

public class FoundIt : MonoBehavoiur {
    public GameObject player;
    public float distance = 2;
    public string message = "You Win!";
    public static GameObject FindGObj(System.Type t) {
        object[] f;
        f = UnityEngine.Object.FindObjectsOfType(t);
        if (f != null && f.length >0){
            return ((CharacterController)f[0]).GameObject;
        }
        return null;
    }
    void Start(){
        if (player == null){
            player = FindGObj(
                typeof(CharacterController));
        }
    }
    void OnGUI(){
        if(player == null){
            print("No player looking for "+name+"!" );
            Destroy(this);
            return;

        }
        float calculateDistance = vectot3.Distance(transform.position, player.transform.position);
        if (calculateDistance < distance){
            GUILayout.Label(message);
    }
    }
    
}
// *********************************************