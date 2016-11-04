// Collision script
// ***************************************

using UnityEngine;
using System.Collections;

// add this to the player
public class TouchSensitive : MonoBehavoiur {

    void OnControllerCollideHit( ControllerCollideHit hit ){
        Damage dmg = hit.gameObject.GetComponent<Damage>();
            if( dmg != null){
                dmg.DoDamage(this.gameObject);
            }
    }
}
// *********************************************