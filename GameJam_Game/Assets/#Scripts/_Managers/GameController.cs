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
    public int Wall_L_Health { get; set; }
    public int Wall_R_Health { get; set; }
    #endregion
    #region Main Game Stats
    public int Player_Turns { get; set; }
    public int Player_Tasks { get; set; }
    public int Player_People { get; set; }
    public int Player_Capacity { get; set; }
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
    #region Values for Tooltips
    #region Expedition
    public int value_Expedition_Tasks, value_Expedition_Metal, value_Expedition_Wood, value_Expedition_Tech, value_Expedition_Seeds, value_Expedition_Science;
    #endregion
    #region Training
    public int value_Training_Tasks, value_Training_Metal, value_Training_Wood, value_Training_Tech, value_Training_Seeds, value_Training_Science;
    #endregion
    #region Garden
    public int value_Garden_Tasks, value_Garden_Metal, value_Garden_Wood, value_Garden_Tech, value_Garden_Seeds, value_Garden_Science;
    #endregion
    #region Radio
    public int value_Radio_Tasks, value_Radio_Metal, value_Radio_Wood, value_Radio_Tech, value_Radio_Seeds, value_Radio_Science;
    #endregion
    #region Generator 1
    public int value_Generator_1_Tasks, value_Generator_1_Metal, value_Generator_1_Wood, value_Generator_1_Tech, value_Generator_1_Seeds, value_Generator_1_Science;
    #endregion
    #region Generator 2
    public int value_Generator_2_Tasks, value_Generator_2_Metal, value_Generator_2_Wood, value_Generator_2_Tech, value_Generator_2_Seeds, value_Generator_2_Science;
    #endregion
    #region Workshop 1
    public int value_Workshop_1_Tasks, value_Workshop_1_Metal, value_Workshop_1_Wood, value_Workshop_1_Tech, value_Workshop_1_Seeds, value_Workshop_1_Science;
    #endregion
    #region Workshop 2
    public int value_Workshop_2_Tasks, value_Workshop_2_Metal, value_Workshop_2_Wood, value_Workshop_2_Tech, value_Workshop_2_Seeds, value_Workshop_2_Science;
    #endregion
    #region LivingSpace 1
    public int value_LivingSpace_1_Tasks, value_LivingSpace_1_Metal, value_LivingSpace_1_Wood, value_LivingSpace_1_Tech, value_LivingSpace_1_Seeds, value_LivingSpace_1_Science;
    #endregion
    #region LivingSpace 2
    public int value_LivingSpace_2_Tasks, value_LivingSpace_2_Metal, value_LivingSpace_2_Wood, value_LivingSpace_2_Tech, value_LivingSpace_2_Seeds, value_LivingSpace_2_Science;
    #endregion
    #region Research 1
    public int value_Research_1_Tasks, value_Research_1_Metal, value_Research_1_Wood, value_Research_1_Tech, value_Research_1_Seeds, value_Research_1_Science;
    #endregion
    #region Research 2
    public int value_Research_2_Tasks, value_Research_2_Metal, value_Research_2_Wood, value_Research_2_Tech, value_Research_2_Seeds, value_Research_2_Science;
    #endregion
    #region Wall
    public int value_Wall_Tasks, value_Wall_Metal, value_Wall_Wood, value_Wall_Tech, value_Wall_Seeds, value_Wall_Science;
    #endregion
    #region Stairs_2
    public int value_Stairs_2_Tasks, value_Stairs_2_Metal, value_Stairs_2_Wood, value_Stairs_2_Tech, value_Stairs_2_Seeds, value_Stairs_2_Science;
    #endregion
    #region Stairs_3
    public int value_Stairs_3_Tasks, value_Stairs_3_Metal, value_Stairs_3_Wood, value_Stairs_3_Tech, value_Stairs_3_Seeds, value_Stairs_3_Science;
    #endregion
    #region Bedroom_Lvl1_L
    public int value_Bedroom_Lvl1_L_Tasks, value_Bedroom_Lvl1_L_Metal, value_Bedroom_Lvl1_L_Wood, value_Bedroom_Lvl1_L_Tech, value_Bedroom_Lvl1_L_Seeds, value_Bedroom_Lvl1_L_Science;
    #endregion
    #region Bedroom_Lvl1_R
    public int value_Bedroom_Lvl1_R_Tasks, value_Bedroom_Lvl1_R_Metal, value_Bedroom_Lvl1_R_Wood, value_Bedroom_Lvl1_R_Tech, value_Bedroom_Lvl1_R_Seeds, value_Bedroom_Lvl1_R_Science;
    #endregion
    #region Bedroom_Lvl2_L
    public int value_Bedroom_Lvl2_L_Tasks, value_Bedroom_Lvl2_L_Metal, value_Bedroom_Lvl2_L_Wood, value_Bedroom_Lvl2_L_Tech, value_Bedroom_Lvl2_L_Seeds, value_Bedroom_Lvl2_L_Science;
    #endregion
    #region Bedroom_Lvl2_R
    public int value_Bedroom_Lvl2_R_Tasks, value_Bedroom_Lvl2_R_Metal, value_Bedroom_Lvl2_R_Wood, value_Bedroom_Lvl2_R_Tech, value_Bedroom_Lvl2_R_Seeds, value_Bedroom_Lvl2_R_Science;
    #endregion
    #region Bedroom_Lvl3_L
    public int value_Bedroom_Lvl3_L_Tasks, value_Bedroom_Lvl3_L_Metal, value_Bedroom_Lvl3_L_Wood, value_Bedroom_Lvl3_L_Tech, value_Bedroom_Lvl3_L_Seeds, value_Bedroom_Lvl3_L_Science;
    #endregion
    #region Bedroom_Lvl3_R
    public int value_Bedroom_Lvl3_R_Tasks, value_Bedroom_Lvl3_R_Metal, value_Bedroom_Lvl3_R_Wood, value_Bedroom_Lvl3_R_Tech, value_Bedroom_Lvl3_R_Seeds, value_Bedroom_Lvl3_R_Science;
    #endregion
    #endregion
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
