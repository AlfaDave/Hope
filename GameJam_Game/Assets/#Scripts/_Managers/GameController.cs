using System;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public bool PlayerSave { get; set; }
    public bool Player_Sound { get; set; }
    #region Default Buildings
    public int Room_Radio { get; set; }
    public int Room_Expedition { get; set; }
    public int Room_UndergroundGarden { get; set; }
    public int Room_Training { get; set; }
    #endregion
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
    public int Stairs_2_Clicks_Unlock { get; set; }
    public int Stairs_3_Clicks_Unlock { get; set; }
    /// <summary>
    /// Rooms are ordered in layers with left and right number 1 room is closest to the stairs
    /// </summary>
    public bool UnderGarden_Lvl1_L1 { get; set; }
    public bool Radio_Lvl1_L2 { get; set; }
    public bool Expedition_Lvl1_R1 { get; set; }
    public bool Training_Lvl1_R2 { get; set; }
    public bool Workshop_Lvl2_L1 { get; set; }
    public bool Workshop_Lvl2_L2 { get; set; }
    public bool Generator_Lvl2_R1 { get; set; }
    public bool Generator_Lvl2_R2 { get; set; }
    public bool Research_Lvl3_L1 { get; set; }
    public bool Research_Lvl3_L2 { get; set; }
    public bool LivingSpace_Lvl3_R1 { get; set; }
    public bool LivingSpace_Lvl3_R2 { get; set; }
    /// <summary>
    /// room Upgrade levels only 0 rock 1 first type of room 2 second type of room 3 third type of room
    /// </summary>
    public int UnderGarden_Upg_Lvl1_L1 { get; set; }
    public int Radio_Upg_Lvl1_L2 { get; set; }
    public int Expedition_Upg_Lvl1_R1 { get; set; }
    public int Training_Upg_Lvl1_R2 { get; set; }
    public int Workshop_Upg_Lvl2_L1 { get; set; }
    public int Workshop_Upg_Lvl2_L2 { get; set; }
    public int Generator_Upg_Lvl2_R1 { get; set; }
    public int Generator_Upg_Lvl2_R2 { get; set; }
    public int Research_Upg_Lvl3_L1 { get; set; }
    public int Research_Upg_Lvl3_L2 { get; set; }
    public int LivingSpace_Upg_Lvl3_R1 { get; set; }
    public int LivingSpace_Upg_Lvl3_R2 { get; set; }
    public bool Bedroom_Lvl1_L { get; set; }
    public bool Bedroom_Lvl1_R { get; set; }
    public bool Bedroom_Lvl2_L { get; set; }
    public bool Bedroom_Lvl2_R { get; set; }
    public bool Bedroom_Lvl3_L { get; set; }
    public bool Bedroom_Lvl3_R { get; set; }
    public int Bedroom_Upg_Lvl1_L { get; set; }
    public int Bedroom_Upg_Lvl1_R { get; set; }
    public int Bedroom_Upg_Lvl2_L { get; set; }
    public int Bedroom_Upg_Lvl2_R { get; set; }
    public int Bedroom_Upg_Lvl3_L { get; set; }
    public int Bedroom_Upg_Lvl3_R { get; set; }
    public int Bedroom_Lvl1_L_Clik_Unlock { get; set; }
    public int Bedroom_Lvl1_R_Clik_Unlock { get; set; }
    public int Bedroom_Lvl2_L_Clik_Unlock { get; set; }
    public int Bedroom_Lvl2_R_Clik_Unlock { get; set; }
    public int Bedroom_Lvl3_L_Clik_Unlock { get; set; }
    public int Bedroom_Lvl3_R_Clik_Unlock { get; set; }
    public bool Wall_L { get; set; }
    public bool Wall_R { get; set; }
    public int Wall_L_Clik_Unlock { get; set; }
    public int Wall_R_Clik_Unlock { get; set; }
    public int Wall_L_Upg { get; set; }
    public int Wall_R_Upg { get; set; }
    #endregion
    #region Main Game Stats
    public int Player_Turns { get; set; }
    public int Player_Tasks { get; set; }
    public int Player_People { get; set; }
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
    public string levelToLoad;
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
