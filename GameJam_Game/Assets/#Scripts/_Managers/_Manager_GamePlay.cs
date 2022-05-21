using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Manager_GamePlay : MonoBehaviour
{
    public CameraFollower camfollow;
    public Transform point1, point2, point3, point4;
    void Start()
    {
        camfollow.Set(() => point1.transform.position);

        camfollow.SetGetCameraFollowPositionFunc(()=>point1.transform.position);


    }
}
