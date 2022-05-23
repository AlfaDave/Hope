using System;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public bool PlayerSave { get; set; }
    public bool Player_Sound { get; set; }
    #region Vault Heath Items
    public int Vault_Health { get; set; }
    public int Wall_Left_Upgrade { get; set; }
    public int Wall_Left_Health { get; set; }
    public int Wall_Right_Upgrade { get; set; }
    public int Wall_Right_Health { get; set; }
    #endregion
    #region Vault Room Upgrades
    public bool Stairs_1 { get; set; }
    public bool Stairs_2 { get; set; }
    public bool Stairs_3 { get; set; }

    /// <summary>
    /// Rooms are ordered in layers with left and right number 1 room is closest to the stairs
    /// </summary>
    public bool Room_Top_Left_1 { get; set; }
    public bool Room_Top_Left_2 { get; set; }
    public bool Room_Top_Right_1 { get; set; }
    public bool Room_Top_Right_2 { get; set; }
    public bool Room_Mid_Left_1 { get; set; }
    public bool Room_Mid_Left_2 { get; set; }
    public bool Room_Mid_Right_1 { get; set; }
    public bool Room_Mid_Right_2 { get; set; }
    public bool Room_Bot_Left_1 { get; set; }
    public bool Room_Bot_Left_2 { get; set; }
    public bool Room_Bot_Right_1 { get; set; }
    public bool Room_Bot_Right_2 { get; set; }
    /// <summary>
    /// room Upgrade levels only 0 rock 1 first type of room 2 second type of room 3 third type of room
    /// </summary>
    public int RoomUpgrade_Top_Left_1 { get; set; }
    public int RoomUpgrade_Top_Left_2 { get; set; }
    public int RoomUpgrade_Top_Right_1 { get; set; }
    public int RoomUpgrade_Top_Right_2 { get; set; }
    public int RoomUpgrade_Mid_Left_1 { get; set; }
    public int RoomUpgrade_Mid_Left_2 { get; set; }
    public int RoomUpgrade_Mid_Right_1 { get; set; }
    public int RoomUpgrade_Mid_Right_2 { get; set; }
    public int RoomUpgrade_Bot_Left_1 { get; set; }
    public int RoomUpgrade_Bot_Left_2 { get; set; }
    public int RoomUpgrade_Bot_Right_1 { get; set; }
    public int RoomUpgrade_Bot_Right_2 { get; set; }
    public bool Bedroom_1 { get; set; }
    public bool Bedroom_2 { get; set; }
    public bool Bedroom_3 { get; set; }
    public bool Bedroom_4 { get; set; }
    public bool Bedroom_5 { get; set; }
    public bool Bedroom_6 { get; set; }
    public int Bedroom_1_Occupants { get; set; }
    public int Bedroom_2_Occupants { get; set; }
    public int Bedroom_3_Occupants { get; set; }
    public int Bedroom_4_Occupants { get; set; }
    public int Bedroom_5_Occupants { get; set; }
    public int Bedroom_6_Occupants { get; set; }
    #endregion
    #region Main Game Stats
    public int Player_Turns { get; set; }
    public int Player_Tasks { get; set; }
    public int Player_Civilians { get; set; }
    public int Player_Science { get; set; }
    #endregion
    #region Main Game Resources
    public int Player_Food { get; set; }
    public int Player_Metal { get; set; }
    public int Player_Wood { get; set; }
    public int Player_Tech { get; set; }
    public int Player_Seeds { get; set; }
    #endregion
    #region Game Mechanics
    
    #endregion
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
        if (Player_Turns == 0) { Player_Turns = setToZero; }
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
