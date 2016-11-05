// Being Touched script
// ***************************************

using UnityEngine;
using System.Collections;

// Put this on something that touches the player
public class BeingTouched : MonoBehavoiur {
    public void DoTouch( GameObject go ){
        Fall f = go.GetComponent<Fall>();
            if(f != null){
                go.transform.position = new Vector3(0, f.lowestAllowed, 0);
            }
    }
}
// *********************************************