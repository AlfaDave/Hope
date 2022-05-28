using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour
{
    private Vector3 camFollowPosition;
    public CameraFollower camFollow;
    [SerializeField] internal GameObject display_Zoom_Amount;
    private GameObject zoom_1X, zoom_2X, zoom_3X;
    //private float zoom = 1100f;
    //private float zoomChangeAmount =160;
    private bool centered = true;
    private float moveAmount = 10;//moveAmount = 600f;
    private float edgeSize = 20f;
    private bool edgeScrolling = true;
    private Vector3 homeLocation = new Vector3(2875, 537, -10);
    private bool zoomBlocked = false;
    private float zoomTimer;
    private int zoomLevel;

    private int currentOrthoZoom;
    private int zoomLevelOrthoSetting_1 = 630, zoomLevelOrthoSetting_2 = 845, zoomLevelOrthoSetting_3 = 1100;
    private int camArea_1_MaxY = 1185, camArea_1_MinY = 15, camArea_1_MaxX = 5655, camArea_1_MinX = 148;//camArea_1_MinY = 145
    private int camArea_2_MaxY = 970, camArea_2_MinY = 150, camArea_2_MaxX = 5215, camArea_2_MinX = 581;//camArea_2_MinY = 380
    private int camArea_3_MaxY = 749, camArea_3_MinY = 300, camArea_3_MaxX = 4810, camArea_3_MinX = 1018;//camArea_3_MinY = 623<previous boundary

    private void Start()
    {

        camFollowPosition.y = homeLocation.y;
        camFollowPosition.x = homeLocation.x;
        zoomLevel = 2;
        currentOrthoZoom = zoomLevelOrthoSetting_2;
        //camFollow.Setup(() => point1.transform.position, () => zoom);
        camFollow.Setup(() => camFollowPosition, () => currentOrthoZoom);
        camFollow.SetCamFollowPos(homeLocation);
        camFollow.SetCamZoom(currentOrthoZoom);
        LinkZoomItems();
    }
    private void Update()
    {
        UserInput();
        //Debug.Log(zoom);
        ZoomTimer();
    }
    private void UserInput()
    {
        ManualMovement();
        CentreView();
        MouseEdgeScrolling();
        ControlZoom();
    }
    private void LinkZoomItems()
    {
        zoom_1X = display_Zoom_Amount.transform.GetChild(0).gameObject;
        zoom_2X = display_Zoom_Amount.transform.GetChild(1).gameObject;
        zoom_3X = display_Zoom_Amount.transform.GetChild(2).gameObject;
        CheckZoomIcon();
    }
    private void ZoomTimer() { if (zoomBlocked) { zoomTimer -= Time.deltaTime; if (zoomTimer <= 0) { zoomBlocked = false; } } }
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
            //zoom = Mathf.Clamp(zoom, 515f, 1100f);
        }
    }
    public void ClickZoom()
    {
        CameraZoomStep(true); zoomBlocked = true;
    }
    private void ControlZoom()
    {
        if (!zoomBlocked) {
            if (Input.GetKeyUp(KeyCode.Plus)) { CameraZoomStep(true); zoomBlocked = true; }
            if (Input.GetKeyUp(KeyCode.Equals)) { CameraZoomStep(true); zoomBlocked = true; }
            if (Input.GetKeyUp(KeyCode.KeypadPlus)) { CameraZoomStep(true); zoomBlocked = true; }

            if (Input.GetKeyUp(KeyCode.Minus)) { CameraZoomStep(false); zoomBlocked = true; }
            if (Input.GetKeyUp(KeyCode.Underscore)) { CameraZoomStep(false); zoomBlocked = true; }
            if (Input.GetKeyUp(KeyCode.KeypadMinus)) { CameraZoomStep(false); zoomBlocked = true; }
        }
    }
    private void CheckZoomIcon()
    {
        if (zoomLevel == 1) { zoom_1X.SetActive(false); zoom_2X.SetActive(true); zoom_3X.SetActive(false); }
        else if (zoomLevel == 2) { zoom_1X.SetActive(false); zoom_2X.SetActive(false); zoom_3X.SetActive(true); }
        else if (zoomLevel == 3) { zoom_1X.SetActive(true); zoom_2X.SetActive(false); zoom_3X.SetActive(false); }
    }
    private void CameraZoomStep(bool positive)
    {
        if (!positive) {
            if (zoomLevel == 1) { zoom_1X.SetActive(false); zoom_2X.SetActive(true); zoom_3X.SetActive(false); zoomTimer = 0.75f; zoomLevel = 2; currentOrthoZoom = zoomLevelOrthoSetting_2; camFollow.SetCamZoom(currentOrthoZoom); }//SetCameraPosition(1, true, 0); }
            else if (zoomLevel == 2) { zoom_1X.SetActive(false); zoom_2X.SetActive(false); zoom_3X.SetActive(true); zoomTimer = 0.75f; zoomLevel = 3; currentOrthoZoom = zoomLevelOrthoSetting_3; camFollow.SetCamZoom(currentOrthoZoom); }//SetCameraPosition(1, true, 0); }
            else if (zoomLevel == 3) { zoom_1X.SetActive(true); zoom_2X.SetActive(false); zoom_3X.SetActive(false); zoomTimer = 0.75f; zoomLevel = 1; currentOrthoZoom = zoomLevelOrthoSetting_1; camFollow.SetCamZoom(currentOrthoZoom); }//SetCameraPosition(1, true, 0); }
        }
        else
        {
            if (zoomLevel == 1) { zoom_1X.SetActive(false); zoom_2X.SetActive(false); zoom_3X.SetActive(true); zoomTimer = 0.75f; zoomLevel = 3; currentOrthoZoom = zoomLevelOrthoSetting_3; camFollow.SetCamZoom(currentOrthoZoom); }// SetCameraPosition(1, true, 0); }
            else if (zoomLevel == 2) { zoom_1X.SetActive(true); zoom_2X.SetActive(false); zoom_3X.SetActive(false); zoomTimer = 0.75f; zoomLevel = 1; currentOrthoZoom = zoomLevelOrthoSetting_1; camFollow.SetCamZoom(currentOrthoZoom); }// SetCameraPosition(1, true, 0); }
            else if (zoomLevel == 3) { zoom_1X.SetActive(false); zoom_2X.SetActive(true); zoom_3X.SetActive(false); zoomTimer = 0.75f; zoomLevel = 2; currentOrthoZoom = zoomLevelOrthoSetting_2; camFollow.SetCamZoom(currentOrthoZoom); }// SetCameraPosition(1, true, 0); }
        }
    }
    private void SetCameraPosition(int axis, bool polarity, float moveAmount)
    {
        if (axis == 1) {// x axis
            if (polarity)// positive
            {
                camFollowPosition.x += moveAmount;// * Time.deltaTime;
                if (zoomLevel == 1) { if (camFollowPosition.x >= camArea_1_MaxX) { camFollowPosition.x = camArea_1_MaxX; } }
                else if (zoomLevel == 2) { if (camFollowPosition.x >= camArea_2_MaxX) { camFollowPosition.x = camArea_2_MaxX; } }
                else if (zoomLevel == 3) { if (camFollowPosition.x >= camArea_3_MaxX) { camFollowPosition.x = camArea_3_MaxX; } }
            }
            else
            {
                camFollowPosition.x -= moveAmount;// * Time.deltaTime;
                if (zoomLevel == 1) { if (camFollowPosition.x <= camArea_1_MinX) { camFollowPosition.x = camArea_1_MinX; } }
                else if (zoomLevel == 2) { if (camFollowPosition.x <= camArea_2_MinX) { camFollowPosition.x = camArea_2_MinX; } }
                else if (zoomLevel == 3) { if (camFollowPosition.x <= camArea_3_MinX) { camFollowPosition.x = camArea_3_MinX; } }
            }
        }
        else if (axis == 2){ // y axis
            if (polarity)// negative
            {
                camFollowPosition.y += moveAmount;// * Time.deltaTime;
                if (zoomLevel == 1) { if (camFollowPosition.y >= camArea_1_MaxY) { camFollowPosition.y = camArea_1_MaxY; } }
                else if (zoomLevel == 2) { if (camFollowPosition.y >= camArea_2_MaxY) { camFollowPosition.y = camArea_2_MaxY; } }
                else if (zoomLevel == 3) { if (camFollowPosition.y >= camArea_3_MaxY) { camFollowPosition.y = camArea_3_MaxY; } }
            }
            else
            {
                camFollowPosition.y -= moveAmount;// * Time.deltaTime;
                if (zoomLevel == 1) { if (camFollowPosition.y <= camArea_1_MinY) { camFollowPosition.y = camArea_1_MinY; } }
                else if (zoomLevel == 2) { if (camFollowPosition.y <= camArea_2_MinY) { camFollowPosition.y = camArea_2_MinY; } }
                else if (zoomLevel == 3) { if (camFollowPosition.y <= camArea_3_MinY) { camFollowPosition.y = camArea_3_MinY; } }
            }
        }
        else if (axis == 3) { // z axis
            if (polarity)// negative
            {
                camFollowPosition.z += moveAmount;// * Time.deltaTime;
            }
            else
            {
                camFollowPosition.z -= moveAmount;// * Time.deltaTime;
            }
        }
        camFollow.SetCamFollowPos(camFollowPosition);
    }
}
