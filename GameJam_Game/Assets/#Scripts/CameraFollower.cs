using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    public bool isOnCamera = true;
    private Camera myCam;
    private Func<Vector3> GetCamFollowPosFunc;
    private Func<float> GetCamZoomFunc;


    
    
    public void Setup(Func<Vector3> GetCamFollowPosFunc, Func<float> GetCamZoomFunc) {
        this.GetCamFollowPosFunc = GetCamFollowPosFunc;
        this.GetCamZoomFunc = GetCamZoomFunc;
    }
    private void Start() {
        if (!isOnCamera) { myCam = GameObject.Find("Main Camera").GetComponent<Camera>(); }
        else { myCam = transform.GetComponent<Camera>(); }
    }
    public void SetCamFollowPos(Vector3 camFollowPos) {
        SetGetCameraFollowPositionFunc(() => camFollowPos);
    }
    public void SetGetCameraFollowPositionFunc(Func<Vector3> GetCamFollowPosFunc){
        this.GetCamFollowPosFunc = GetCamFollowPosFunc;
    }
    public void SetCamFollow(Vector3 camPos)
    {
        SetGetCameraFollowPositionFunc(() => camPos);
    }
    public void SetCamZoom(float camZoom) {
        SetGetCamZoomFunc(()=> camZoom);
    }
    public void SetGetCamZoomFunc(Func<float> GetCamZoomFunc) {
        this.GetCamZoomFunc = GetCamZoomFunc;
    }
    void Update()
    {
        HandleMovement();
        HandleZoom();
    }
    private void HandleMovement()
    {
        Vector3 camFollowPos = GetCamFollowPosFunc();
        camFollowPos.z = transform.position.z;

        Vector3 cameraMoveDir = (camFollowPos - transform.position).normalized;
        float distance = Vector3.Distance(camFollowPos, transform.position);
        float camMoveSpeed = 2f;

        if (distance > 0)
        {
            Vector3 newCamPos = transform.position = transform.position + cameraMoveDir * distance * camMoveSpeed * Time.deltaTime; // this moves the camera to the destination

            float distanceAfterMove = Vector3.Distance(newCamPos, camFollowPos); // these 3 lines stop the camera from moving too far if framerates drop below desired frame rate of 60fps
            if (distanceAfterMove > distance) { newCamPos = camFollowPos; }
            transform.position = newCamPos;
        }
    }
    private void HandleZoom()
    {
        float camZoom = GetCamZoomFunc();
        float camZoomDif = camZoom - myCam.orthographicSize;
        float camZoomSpeed = 10f;

        myCam.orthographicSize += camZoomDif * camZoomSpeed * Time.deltaTime;
        if (camZoomDif > 0)
        {
            if (myCam.orthographicSize > camZoom) {
                myCam.orthographicSize = camZoom;
            }
            else {
                if (myCam.orthographicSize < camZoom) {
                    myCam.orthographicSize = camZoom; }
            }
        }

    }
}
