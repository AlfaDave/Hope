using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoRoutineController : MonoBehaviour
{
    public static CoRoutineController manager;
    private LocalCoRoutines localCoRoutines;
    private bool isPaused = false;
    public bool testingTriggerStateChange;
    private bool flip;// for testing also
    private void Awake()
    {
        if (manager == null)
        {
            manager = this;
        }
    }
    private void Update()// for testing purposes
    {
        if (testingTriggerStateChange)
        {
            if (flip)
            {
                flip = false;
                OnSuspend();
                //Debug.Log("testing flip to suspend");
            }
            else
            {
                flip = true;
                OnResume();
                //Debug.Log("testing flip to resume");
            }
            testingTriggerStateChange = false;
        }
    }
    void OnApplicationPause(bool pauseStatus)
    {
        isPaused = pauseStatus;
    }
    void OnSuspend()
    {
        localCoRoutines = GameObject.FindWithTag("LocalCoRoutines").GetComponent<LocalCoRoutines>();
        localCoRoutines.OnSuspend();
    }
    private void OnResume()
    {
        localCoRoutines = GameObject.FindWithTag("LocalCoRoutines").GetComponent<LocalCoRoutines>();
        localCoRoutines.OnResume();
    }
}
