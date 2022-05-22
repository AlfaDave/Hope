using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager soundManager;
    private float volumeSFX=1, backgroundMusic=1;
    public AudioClip backingMusic, sfxMenuButton, sfxElectClick, sfxMetalClick, sfxBuildingMatClick, sfxFoodClick, sfxRemoveRockClick; 

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
        OneSound_MenuButton();
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
    public void OneSound_ClickOnElect()
    {
        GameObject soundGameObject_ClickElect = new GameObject("OneShotSound_ClickElect");
        SFXPlayOnce(soundGameObject_ClickElect, sfxElectClick);
    }
    public void OneSound_ClickOnMetal()
    {
        GameObject soundGameObject_ClickMetal = new GameObject("OneShotSound_ClickMetal");
        SFXPlayOnce(soundGameObject_ClickMetal, sfxMetalClick);
    }
    public void OneSound_ClickOnBuildingMats()
    {
        GameObject soundGameObject_ClickBuildingMats = new GameObject("OneShotSound_ClickBuildingMats");
        SFXPlayOnce(soundGameObject_ClickBuildingMats, sfxBuildingMatClick);
    }
    public void OneSound_ClickOnFood()
    {
        GameObject soundGameObject_ClickFood = new GameObject("OneShotSound_ClickFood");
        SFXPlayOnce(soundGameObject_ClickFood, sfxFoodClick);
    }
    public void OneSound_ClickOnRemovingRock()
    {
        GameObject soundGameObject_ClickRemoveRock = new GameObject("OneShotSound_ClickRemoveRock");
        SFXPlayOnce(soundGameObject_ClickRemoveRock, sfxRemoveRockClick);
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
}
