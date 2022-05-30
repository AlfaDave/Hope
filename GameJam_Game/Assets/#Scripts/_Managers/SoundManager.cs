using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager soundManager;
    private float volumeSFX=0.5f, backgroundMusic=0.5f;
    public AudioClip backingMusic, sfxMenuButton,sfxCollect, sfxEndTurn,sfxDeny,sfxBuilding; 

    void Awake()
    {
        if (soundManager == null)
        {
            DontDestroyOnLoad(gameObject);
            soundManager = this;
        }
        else if (soundManager != this)
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        //BackgroundMusic();
        //OneSound_MenuButton();
        SetBGMusicVolume();// setting bg music volume to 0.3f
    }
    public void BackgroundMusic()
    {
        GameObject soundGameObject_BackgroundMusic = new GameObject("BackgroundSound_Music");
        MusicBackground(soundGameObject_BackgroundMusic, backingMusic);
    }
    public void OneSound_MenuButton()
    {
        GameObject soundGameObject_MenuBut = new GameObject("OneShotSound_MenuButton");
        SFXPlayOnce(soundGameObject_MenuBut, sfxMenuButton);
    }
    public void OneSound_Collect()
    {
        GameObject soundGameObject_ClickCollect = new GameObject("OneShotSound_ClickCollect");
        SFXPlayOnce(soundGameObject_ClickCollect, sfxCollect);
    }
    public void OneSound_Deny()
    {
        GameObject soundGameObject_ClickDeny = new GameObject("OneShotSound_ClickDeny");
        SFXPlayOnce(soundGameObject_ClickDeny, sfxDeny);
    }
    public void OneSound_Building()
    {
        GameObject soundGameObject_ClickBuilding = new GameObject("OneShotSound_ClickBuilding");
        SFXPlayOnce(soundGameObject_ClickBuilding, sfxBuilding); 
    }
    public void OneSound_EndTurn()
    {
        GameObject soundGameObject_ClickEndTurn = new GameObject("OneShotSound_ClickEndTurn");
        SFXPlayOnce(soundGameObject_ClickEndTurn, sfxEndTurn); 
    }
    private void SFXPlayOnce(GameObject instance, AudioClip audioToPlay)
    {
        AudioSource audioSource = instance.AddComponent<AudioSource>();
        SetParentToSFX(instance);
        audioSource.PlayOneShot(audioToPlay, volumeSFX);
    }
    private void MusicPlayOnce(GameObject instance, AudioClip audioToPlay)
    {
        AudioSource audioSource = instance.AddComponent<AudioSource>();
        SetParentToMusic(instance);
        audioSource.PlayOneShot(audioToPlay, volumeSFX);
    }
    private void MusicBackground(GameObject instance, AudioClip audioToPlay)
    {
        AudioSource audioSource = instance.AddComponent<AudioSource>();
        SetParentToBackgroundMusic(instance);
        audioSource.PlayOneShot(audioToPlay, backgroundMusic);

        instance.GetComponent<AudioSource>().clip = audioToPlay;
        instance.GetComponent<AudioSource>().loop = true;
    }
    private void SetParentToSFX(GameObject gameObject)
    {
        gameObject.transform.parent = this.gameObject.transform.GetChild(2);
    }
    private void SetParentToMusic(GameObject gameObject)
    {
        gameObject.transform.parent = this.gameObject.transform.GetChild(1);
    }
    private void SetParentToBackgroundMusic(GameObject gameObject)
    {
        gameObject.transform.parent = this.gameObject.transform.GetChild(0);
    }
    public void SetSFXVolume(float volume)
    {
        volumeSFX = volume;
    }
    public void SetMusicVolume(float volume)
    {
        backgroundMusic = volume;
    }
    private void SetBGMusicVolume()
    {
        GameObject BGMusic = GameObject.Find("BackgroundMusicOnLoop");
        AudioSource audioBGMusic = BGMusic.GetComponent<AudioSource>();
        audioBGMusic.volume = 0.3f;
    }
}
