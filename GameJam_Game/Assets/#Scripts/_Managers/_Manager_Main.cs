using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class _Manager_Main : MonoBehaviour
{
    private SoundManager SM;
    private SaveGame GS;
    private GameObject soundButtonText;
    public GameObject credits;
    private string soundOn = "Sound ON", soundOff = "Sound OFF";
    private bool creditsToggle;
    void Start()
    {
        GS = GameObject.Find("GameSave").GetComponent<SaveGame>();
        SM = GameObject.Find("SoundManager").GetComponent<SoundManager>();
        //GameObject credits = GameObject.Find("CreditsMaster");
        credits.transform.GetChild(0).gameObject.SetActive(false);
        //soundButtonText = soundButton.transform.GetChild(0).gameObject;
        //if (GameController.gameC.Player_Sound) { soundButtonText.GetComponent<Text>().text = soundOn; }
        //else { soundButtonText.GetComponent<Text>().text = soundOff; }
        //GS.LoadingGame();
    }
    public void ToggleSound()
    {
        SM.OneSound_MenuButton();
        if (GameController.gameC.Player_Sound) { GameController.gameC.Player_Sound = false; soundButtonText.GetComponent<Text>().text = soundOff; }// adjust the sound in what ever sound system we use
        else { GameController.gameC.Player_Sound = true; soundButtonText.GetComponent<Text>().text = soundOn; }// also adjust for this too
    }
    public void ToggleCredits() {
        SM.OneSound_MenuButton(); if (creditsToggle) { creditsToggle = false; credits.transform.GetChild(0).gameObject.SetActive(false); }
        else if (!creditsToggle) { creditsToggle = true; credits.transform.GetChild(0).gameObject.SetActive(true); } }

    public void LoadGameplay() { SM.OneSound_MenuButton(); SaveGame.gameSave.LoadLevel("Async_Load_MainGame"); }
    public void Quit()
    {
        Application.Quit();
    }
}
