using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Intro : MonoBehaviour {
    private bool gameStarted = false;
    private float countdown = 7.5f;
    public AudioClip theme;
    AudioSource audioSource;
    private bool loadCalled = false;
    
    void Start () {
        audioSource = GetComponent<AudioSource>();
        //AudioController.PlayMusicPlaylist("SplashIntro");
    }
    private void FixedUpdate()
    {
        if (!loadCalled)
        {
            countdown -= Time.fixedDeltaTime;
            if (countdown <= 0)
            {
                SaveGame.gameSave.LoadLevel("Main");
                //SceneManager.LoadScene("SignIn");
            }
        }
    }    
}
