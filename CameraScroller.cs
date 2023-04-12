using UnityEngine;

public class CameraScroller : MonoBehaviour
{

    [SerializedField]
    private float ScrollSpeedScalar = 1f;
    [SerializedField]
    private Vector2 ScrollDirection = Vector2.right;

    private Camera cam;

    private void Start(){
        cam = Camera.main;
    }

    private void Update(){
        //Pan the camera along the ScrollDirection axis
        cam.transform.position += ScrollDirection * ScrollSpeedScalar;
    }

}