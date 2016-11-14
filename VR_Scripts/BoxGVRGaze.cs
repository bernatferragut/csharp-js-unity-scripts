
// IGvrGazeResponder from SDK for hover or 'OnGazeEnter'
// On hover: The Box moves backwawrd in space

public class BoxGVRGaze : MonoBehaviour, IGvrGazeResponder {

    public void OnGazeEnter() {
        transform.position += new Vector3 (0f, 0f, 1f);
    }

    public void OnGazeExit() {
        Debug.Log (“Gaze Exit“);
    }

    public void OnGazeTrigger() {
        Debug.Log (“Gaze Trigger“);
    }
}

// Unity Event System Gaze Input for hover selection 
// On hover: The Pink left Box moves up and the blue backwards

public class MoveUp : MonoBehaviour {

    public void MoveItemUp()
    {
        transform.position += new Vector3 (0f, 1f, 0f);
    }
}

