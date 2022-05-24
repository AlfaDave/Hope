using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class _Manager_Intro : MonoBehaviour
{
    //private bool gameStarted = false;
    private float countdown = 7.5f;
    public AudioClip theme;
    AudioSource audioSource;
    private bool loadCalled = false;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(theme, 0.5f);
    }
    private void FixedUpdate()
    {
        if (!loadCalled)
        {
            countdown -= Time.fixedDeltaTime;
            if (countdown <= 0)
            {
                SceneManager.LoadScene("Main");
                //SceneManager.LoadScene("SignIn");
            }
        }
    }
}
