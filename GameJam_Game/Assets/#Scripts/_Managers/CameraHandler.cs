using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    private Vector3 camFollowPosition;
    public CameraFollower camFollow;
    public Transform point1, point2, point3, point4;
    private float zoom = 396f;
    private float zoomChangeAmount =160;
    private bool centered = true;
    private float moveAmount = 600f;
    private float edgeSize = 25f;
    private bool edgeScrolling = true;

    private void Start()
    {
        //camFollow.Setup(() => point1.transform.position, () => zoom);
        camFollow.Setup(() => camFollowPosition, () => zoom);

        camFollow.SetGetCameraFollowPositionFunc(()=>point1.transform.position);
        camFollow.SetCamFollowPos(new Vector3(0, 0,-10));
        camFollow.SetCamZoom(zoom);
    }
    private void Update()
    {
        UserInput();
        //Debug.Log(zoom);
    }
    private void UserInput()
    {
        ManualMovement();
        CentreView();
        MouseEdgeScrolling();
        ControlZoom();
    }
    private void ManualMovement()
    {
        if (Input.GetKey(KeyCode.W)) { centered = false; SetCameraPosition(2, true, moveAmount); }
        //SetCamEdges(1, 2, true, moveAmount); }
        if (Input.GetKey(KeyCode.S)) { centered = false; SetCameraPosition(2, false, moveAmount); }
        //SetCamEdges(1, 2, false, moveAmount);}
        if (Input.GetKey(KeyCode.A)) { centered = false; SetCameraPosition(1, false, moveAmount); }
        //SetCamEdges(1, 1, false, moveAmount); }
        if (Input.GetKey(KeyCode.D)) { centered = false; SetCameraPosition(1, true, moveAmount); }
        //SetCamEdges(1, 1, true, moveAmount); }

        if (Input.GetKey(KeyCode.UpArrow)) { centered = false; SetCameraPosition(2, true, moveAmount); }
        //SetCamEdges(1, 2, true, moveAmount); }
        if (Input.GetKey(KeyCode.DownArrow)) { centered = false; SetCameraPosition(2, false, moveAmount); }
        //SetCamEdges(1, 2, false, moveAmount); }
        if (Input.GetKey(KeyCode.LeftArrow)) { centered = false; SetCameraPosition(1, false, moveAmount); }
        //SetCamEdges(1, 1, false, moveAmount); }
        if (Input.GetKey(KeyCode.RightArrow)) { centered = false; SetCameraPosition(1, true, moveAmount); }
        //SetCamEdges(1, 1, true, moveAmount); }
    }
    private void CentreView()
    {
        if (Input.GetKey(KeyCode.Home)) { Center(); }
    }
    private void MouseEdgeScrolling()
    {
        if (edgeScrolling)
        {

            if (Input.mousePosition.x > Screen.width - edgeSize)// move right on hitting right edge 
            {
                centered = false; SetCameraPosition(1, true, moveAmount);
            }
            if (Input.mousePosition.x < edgeSize)// move left ""
            {
                centered = false; SetCameraPosition(1, false, moveAmount);
            }
            if (Input.mousePosition.y > Screen.height - edgeSize)// move up""
            {
                centered = false; SetCameraPosition(2, true, moveAmount);
            }
            if (Input.mousePosition.y < edgeSize)// move down""
            {
                centered = false; SetCameraPosition(2, false, moveAmount);
            }
        }
    }
    private void Center()
    {
        if (!centered)
        {
            centered = true;
            camFollowPosition.y = 0;
            camFollowPosition.x = 0;
        }
    }
    private void ControlZoom()
    {
        if (Input.GetKey(KeyCode.Plus)) { zoom -= zoomChangeAmount * Time.deltaTime; }
        if (Input.GetKey(KeyCode.Equals)) { zoom -= zoomChangeAmount * Time.deltaTime; }
        if (Input.GetKey(KeyCode.KeypadPlus)) { zoom -= zoomChangeAmount * Time.deltaTime; }
        if (Input.mouseScrollDelta.y > 0) { zoom -= zoomChangeAmount * Time.deltaTime * 12f; }

        if (Input.GetKey(KeyCode.Minus)) { zoom += zoomChangeAmount * Time.deltaTime; }
        if (Input.GetKey(KeyCode.Underscore)) { zoom += zoomChangeAmount * Time.deltaTime; }
        if (Input.GetKey(KeyCode.KeypadMinus)) { zoom += zoomChangeAmount * Time.deltaTime; }
        if (Input.mouseScrollDelta.y < 0) { zoom += zoomChangeAmount * Time.deltaTime * 12f; }
        zoom = Mathf.Clamp(zoom, 250f, 730f);
        camFollow.SetCamZoom(zoom);
    }
    private void SetCameraPosition(int axis, bool polarity, float moveAmount)
    {
        if (axis == 1) {// x axis
            if (polarity)// positive
            {
                camFollowPosition.x += moveAmount * Time.deltaTime;
            }
            else
            {
                camFollowPosition.x -= moveAmount * Time.deltaTime;
            }
        }
        else if (axis == 2){ // y axis
            if (polarity)// negative
            {
                camFollowPosition.y += moveAmount * Time.deltaTime;
            }
            else
            {
                camFollowPosition.y -= moveAmount * Time.deltaTime;
            }
        }
        else if (axis == 3) { // z axis
            if (polarity)// negative
            {
                camFollowPosition.z += moveAmount * Time.deltaTime;
            }
            else
            {
                camFollowPosition.z -= moveAmount * Time.deltaTime;
            }
        }
        camFollow.SetCamFollowPos(camFollowPosition);
    }
}
