using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    private Vector3 camFollowPosition;
    public CameraFollower camFollow;
    public Transform point1, point2, point3, point4;
    private float zoom = 396f;
    private bool centered = true;
    private float moveAmount = 600f;

    private void Start()
    {
        camFollow.Setup(() => point1.transform.position, () => zoom);
        camFollow.Setup(() => camFollowPosition, () => 80f);

        camFollow.SetGetCameraFollowPositionFunc(()=>point1.transform.position);
        camFollow.SetCamFollowPos(new Vector3(-100, -50,-10));
        camFollow.SetCamZoom(330f);
    }
    private void Update()
    {
        UserInput();
        //Debug.Log(zoom);
    }
    private void UserInput()
    {
        if (Input.GetKey(KeyCode.Equals)) { ZoomIn(); }
        if (Input.GetKey(KeyCode.Plus)) { ZoomIn(); }
        if (Input.GetKey(KeyCode.Minus)) { ZoomOut(); }
        if (Input.GetKey(KeyCode.Underscore)) { ZoomOut(); }

        if (Input.GetKey(KeyCode.W)) { centered = false; SetCameraPosition(2, true, moveAmount); }
        if (Input.GetKey(KeyCode.S)) { centered = false; SetCameraPosition(2, false, moveAmount); }
        if (Input.GetKey(KeyCode.A)) { centered = false; SetCameraPosition(1, false, moveAmount); }
        if (Input.GetKey(KeyCode.D)) { centered = false; SetCameraPosition(1, true, moveAmount); }

        if (Input.GetKey(KeyCode.UpArrow)) { centered = false; SetCameraPosition(2, true, moveAmount); }
        if (Input.GetKey(KeyCode.DownArrow)) { centered = false; SetCameraPosition(2, false, moveAmount); }
        if (Input.GetKey(KeyCode.LeftArrow)) { centered = false; SetCameraPosition(1, false, moveAmount); }
        if (Input.GetKey(KeyCode.RightArrow)) { centered = false; SetCameraPosition(1, true, moveAmount); }
        if (Input.GetKey(KeyCode.Home)) { Center(); }

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
    private void ZoomIn()
    {
        //Debug.Log("calling zoom in");
        zoom -= 1;
        if (zoom <= 250) zoom = 250;
        camFollow.SetCamZoom(zoom);
    }
    private void ZoomOut()
    {
        //Debug.Log("calling zoom out");
        zoom += 1;
        if (zoom >= 730) zoom = 730;
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
