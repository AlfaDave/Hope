using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _Manager_Intro : MonoBehaviour
{
    private float timer = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0){ SaveGame.gameSave.LoadLevel("Main"); }
    }
}