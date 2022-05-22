using System;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public bool Player_Sound { get; set; }
    public int Player_Score { get; set; }
    [SerializeField] internal GameObject example;
    private int setToZero = 0;
    public static GameController gameC;

    private void Awake()
    {
        if (gameC == null)
        {
            DontDestroyOnLoad(gameObject);
            gameC = this;
        }
        else if (gameC != this)
        {
            Destroy(gameObject);
        }
        SetDefaults();
    }
    private void SetDefaults()
    {
        if (Player_Score == 0) { Player_Score = setToZero; }
    }
    private void Start()
    {
        Application.targetFrameRate = 60;
    }
    private void Update()// does an update every frame your computers max cpu process speed can cope with very unreliable for physics.
    {
        
    }
    private void FixedUpdate()// does an update every frame dependant on the frame rate we have chosen to run at.
    {
        
    }
    private void PlayGame()
    {
        // example of playing sound
        SoundManager.soundManager.OneSound_MenuButton();
    }
    private void PlayerInput()// this is an example for keyboard player input please do not use this directly
    {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {  }
        if (Input.GetKeyDown(KeyCode.Keypad1)) {  }
        if (Input.GetKeyDown(KeyCode.Alpha2)) {  }
        if (Input.GetKeyDown(KeyCode.Keypad2)) {  }
        if (Input.GetKeyDown(KeyCode.Alpha3)) {  }
        if (Input.GetKeyDown(KeyCode.Keypad3)) {  }
        if (Input.GetKeyDown(KeyCode.Y)) {  }
        if (Input.GetKeyDown(KeyCode.N)) {  }
    }
    #region Make text write out on a text game object
    public void WriteOut(string text, GameObject obj)
    {
        obj.GetComponent<Text>().text = text;
    }
    public void WriteToConsole(string text)
    {
        Console.WriteLine(text);
    }
    #endregion
    public void DebugLog(string text)
    {
        Debug.Log(text);
    }
    public void DebugError(string text)
    {
        Debug.LogError(text);
    }
    #region Locate game objects
    public GameObject LocateGameObjectByName(string name)
    {
        GameObject i = GameObject.Find(name);
        return i;
        // to get a specific component on the game object add the value returned
        // Example
        //          GameObject returnedObject = GameController.gameC.LocateGameObjectByName("GameController");
        //          returnedObject.GetComponent<*Script* or *text*>();
    }
    #endregion
}
