using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    private Func<Vector3> func_GetCamFollowPos;

    public void Set(Func<Vector3> func_GetCamFollowPos)
    {
        this.func_GetCamFollowPos = func_GetCamFollowPos;
    }

    public void SetGetCameraFollowPositionFunc(Func<Vector3> func_GetCamFollowPos)
    {
        this.func_GetCamFollowPos = func_GetCamFollowPos;
    }
    void Update()
    {
        Vector3 camFollowPos = func_GetCamFollowPos();
        camFollowPos.z = transform.position.z;

        Vector3 cameraMoveDir = (camFollowPos - transform.position).normalized;
        float distance = Vector3.Distance(camFollowPos, transform.position);
        float camMoveSpeed = 2f;

        if ( distance > 0)
        {
            Vector3 newCamPos = transform.position = transform.position + cameraMoveDir * distance * camMoveSpeed * Time.deltaTime; // this moves the camera to the destination

            float distanceAfterMove = Vector3.Distance(newCamPos, camFollowPos); // these 3 lines stop the camera from moving too far if framerates drop below desired frame rate of 60fps
            if (distanceAfterMove > distance) { newCamPos = camFollowPos; }
            transform.position = newCamPos;
        }
    }
}
