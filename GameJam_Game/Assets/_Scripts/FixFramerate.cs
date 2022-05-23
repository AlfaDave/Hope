using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixFramerate : MonoBehaviour {
    private Camera cam;
	// Use this for initialization
	void Awake() {
        //QualitySettings.vSyncCount = 0; Application.targetFrameRate = 240;
    }

    void Start()
    {
        cam = GetComponent<Camera>();
        ScreenScale();
    }
    private void Update()
    {
        //cam.transform.position = new Vector3(0, 0, -500);
    } 
    private void TesterScreenScale()
    {
        /*float normalAspect = 16 / 9f;

        myCam.fieldOfView = myDesiredHorizontalFov * normalAspect / ((float)myCam.pixelWidth / myCam.pixelHeight);*/
    }
    private void ScreenScale()
    {
        // set the desired aspect ratio (the values in this example are
        // hard-coded for 16:9, but you could make them into public
        // variables instead so you can set them at design time)
        float targetaspect = 16.0f / 9.0f;

        // determine the game window's current aspect ratio
        float windowaspect = (float)Screen.width / (float)Screen.height;

        // current viewport height should be scaled by this amount
        float scaleheight = windowaspect / targetaspect;

        // obtain camera component so we can modify its viewport
        

        // if scaled height is less than current height, add letterbox
        if (scaleheight < 1.0f)
        {
            Rect rect = cam.rect;

            rect.width = 1.0f;
            rect.height = scaleheight;
            rect.x = 0;
            rect.y = (1.0f - scaleheight) / 2.0f;

            cam.rect = rect;
        }
        else // add pillarbox
        {
            float scalewidth = 1.0f / scaleheight;

            Rect rect = cam.rect;

            rect.width = scalewidth;
            rect.height = 1.0f;
            rect.x = (1.0f - scalewidth) / 2.0f;
            rect.y = 0;

            cam.rect = rect;
        }
    }
}
