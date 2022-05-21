using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByArrowKey : MonoBehaviour
{
    private float speed =500, mouseSpeed = 300;
    private bool centered = true;
    void Update()
    {
        MoveTargetByKeys();
        //MoveTargetToMouse();
    }
    private void MoveTargetByKeys()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            centered = false;
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            centered = false;
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            centered = false;
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            centered = false;
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            centered = false;
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            centered = false;
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
            centered = false;
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            centered = false;
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Home))
        {
            if (!centered)
            {
                centered = true;
                transform.position = new Vector3(0, 0, 200);
            }
        }
    }
    private void MoveTargetToMouse()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = Camera.main.transform.position.z + Camera.main.nearClipPlane;
        transform.position = mousePosition;
    }
}
