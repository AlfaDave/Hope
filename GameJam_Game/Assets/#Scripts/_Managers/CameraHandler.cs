using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    private Vector3 camFollowPosition;
    public CameraFollower camFollow;
    private float zoom = 1100f;
    private float zoomChangeAmount =160;
    private bool centered = true;
    private float moveAmount = 600f;
    private float edgeSize = 25f;
    private bool edgeScrolling = true;
    private Vector3 homeLocation = new Vector3(2875, 537, -10);

    private void Start()
    {

        camFollowPosition.y = homeLocation.y;
        camFollowPosition.x = homeLocation.x;
        //camFollow.Setup(() => point1.transform.position, () => zoom);
        camFollow.Setup(() => camFollowPosition, () => zoom);
        camFollow.SetCamFollowPos(homeLocation);
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
            camFollowPosition.y = homeLocation.y;
            camFollowPosition.x = homeLocation.x;
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
        zoom = Mathf.Clamp(zoom, 515f, 1100f);
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
