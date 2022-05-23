using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveGame : MonoBehaviour
{ /// <summary>
  /// could create multiple save slots 1-however many with usernames
  /// To add a new variable to save and load from you will need to add the variable in your current script as a get set or a public/ internal varible
  /// you will also need to add a reference to the your script & gameObject where your varible is located it is also very easy to reference varibles in this
  /// save script as its a static.
  /// you will need to add your varible to the Save_Slot() function.
  /// you will need to add your varible to the Load_Slot() function.
  /// you will need to add your varible with a different name variation to the public class GameData the reason it needs a different name is for readability.
  /// </summary>

    private GameObject gameCont;
    private GameController gCont;
    #region Variables
    private bool saveHasBeenCreated = false;
    #region Save Details
    [SerializeField] internal string username = "Player";
    private string saveFolder = "Save";
    private string savePath_1 = "Career_1";
    private string savePathCareer_1 = "SavedCareer_1.dat";
    private string tempPath;
    [SerializeField] internal enum WhichSaveSpot { Save_1 }
    [SerializeField] internal WhichSaveSpot whichSaveSpot;
    #endregion

    #endregion
    [SerializeField] internal string nextSceneToLoad;

    public static SaveGame gameSave;
    #region Initializing items
    void OnEnable()
    {
        DataPath();
        Load();
    }
    void Awake()
    {
        LocateGameController();
        if (gameSave == null)
        {
            DontDestroyOnLoad(gameObject);
            gameSave = this;
        }
        else if (gameSave != this)
        {
            Destroy(gameObject);
        }
    }
    #endregion
    private void LocateGameController()
    {
        gameCont = GameObject.Find("GameController"); // < finding the gameobject only use Find to find initial reference do not use find regularly its
                                                        // super heavy cpu usage and will kill framerate if its put in update or fixed update for example.
        gCont = gameCont.GetComponent<GameController>(); // < linking the script by using the gameobject reference found on line above
    }
    #region Save Controller
    
    public void CallDataPath()
    {
        DataPath();
    }
    private void DataPath()
    {

        if (!Directory.Exists(Application.persistentDataPath + "/" + saveFolder + "/" + username))
        {
            //
            #region save path
            if (!Directory.Exists(Application.persistentDataPath + "/" + saveFolder + "/" + username + "/" + savePath_1))
            {
                Directory.CreateDirectory(Application.persistentDataPath + "/" + saveFolder + "/" + username + "/" + savePath_1);// Save Slot 1 Folder
                File.Create(Application.persistentDataPath + "/" + saveFolder + "/" + username + "/" + savePath_1 + "/" + savePathCareer_1).Dispose();// 
                Save();
                //Save Slot 1 File
                //Save_Slot(1);
            }
            #endregion
        }
    }
    
    #region Reset Save Files
    public void ResetSaveSlot_1()
    {
        File.Delete(Application.persistentDataPath + "/" + saveFolder + "/" + username + "/" + savePath_1 + "/" + savePathCareer_1);
        File.Create(Application.persistentDataPath + "/" + saveFolder + "/" + username + "/" + savePath_1 + "/" + savePathCareer_1);
        Save();
    }
    #endregion
    #endregion
    #region load and save tasks ADD VARIABLES TO SAVE AND LOAD IN HERE!!!! IN the load and save player data
    private void DeleteSave()
    {
        /*File.Delete(Application.persistentDataPath + "/" + SaveFolder + "/" + Username + "/" + UsernameForSave + "/" + CurrentSaveLocation);// edit each version update
        PlayerPrefs.DeleteAll();
        PlayerPrefs.SetFloat("MasterVolume", 1f);
        PlayerPrefs.SetFloat("MusicVolume", 1f);
        PlayerPrefs.SetFloat("SFXVolume", 1f);
        PlayerPrefs.Save();
        SceneManager.LoadScene("Intro");*/
    }
    private void Save()
    {
        switch (whichSaveSpot)
        {
            case WhichSaveSpot.Save_1:
                Save_Slot(1);
                break;
        }
    }
    private void Load()
    {
        whichSaveSpot = WhichSaveSpot.Save_1;
        switch (whichSaveSpot)
        {
            case WhichSaveSpot.Save_1:
                Load_Slot(1);
                break;
        }
    }

    #region Save Slots
    private void Save_Slot(int slot)
    {
        //Debug.Log("Save being called");
        BinaryFormatter bf = new BinaryFormatter();
        switch (slot)
        {
            case 1:
                tempPath = savePath_1 + "/" + savePathCareer_1;
                break;
            case 2:
                // tempPath = SavePath_2 + "/" + SavePathCareer_2
                break;
        }
        FileStream file_Career = File.OpenWrite(Application.persistentDataPath + "/" + saveFolder + "/" + username + "/" + tempPath);
        GameData data = new GameData();
        // data here
        #region Save player data
        //data. Saved data Variable = Variable instance location to copy from;
        //data.example = exampleVariable;
        // ADD NEW VARIABLES UNDER HERE IN THE STYLE ON THE LINE ABOVE
        data.player_Sound = gCont.Player_Sound;
        #region Vault Heath Items
        data.vault_Health = gCont.Vault_Health;
        data.wall_Left_Upgrade = gCont.Wall_Left_Upgrade;
        data.wall_Left_Health = gCont.Wall_Left_Health;
        data.wall_Right_Upgrade = gCont.Wall_Right_Upgrade;
        data.wall_Right_Health = gCont.Wall_Right_Health;
        #endregion
        #region Vault Room Upgrades
        data.stairs_1 = gCont.Stairs_1;
        data.stairs_2 = gCont.Stairs_2;
        data.stairs_3 = gCont.Stairs_3;

        /// <summary>
        /// Rooms are ordered in layers with left and right number 1 room is closest to the stairs
        /// </summary>
        data.room_Top_Left_1 = gCont.Room_Top_Left_1;
        data.room_Top_Left_2 = gCont.Room_Top_Left_2;
        data.room_Top_Right_1 = gCont.Room_Top_Right_1;
        data.room_Top_Right_2 = gCont.Room_Top_Right_2;
        data.room_Mid_Left_1 = gCont.Room_Mid_Left_1;
        data.room_Mid_Left_2 = gCont.Room_Mid_Left_2;
        data.room_Mid_Right_1 = gCont.Room_Mid_Right_1;
        data.room_Mid_Right_2 = gCont.Room_Mid_Right_2;
        data.room_Bottom_left_1 = gCont.Room_Bottom_Left_1;
        data.room_Bottom_left_2 = gCont.Room_Bottom_Left_2;
        data.room_Bottom_Right_1 = gCont.Room_Bottom_Right_1;
        data.room_Bottom_Right_2 = gCont.Room_Bottom_Right_2;
        /// <summary>
        /// room Upgrade levels only 0 rock 1 first type of room 2 second type of room 3 third type of room
        /// </summary>
        data.roomUpgrade_Top_Left_1 = gCont.RoomUpgrade_Top_Left_1;
        data.roomUpgrade_Top_Left_2 = gCont.RoomUpgrade_Top_Left_2;
        data.roomUpgrade_Top_Right_1 = gCont.RoomUpgrade_Top_Right_1;
        data.roomUpgrade_Top_Right_2 = gCont.RoomUpgrade_Top_Right_2;
        data.roomUpgrade_Mid_Left_1 = gCont.RoomUpgrade_Mid_Left_1;
        data.roomUpgrade_Mid_Left_2 = gCont.RoomUpgrade_Mid_Left_2;
        data.roomUpgrade_Mid_Right_1 = gCont.RoomUpgrade_Mid_Right_1;
        data.roomUpgrade_Mid_Right_2 = gCont.RoomUpgrade_Mid_Right_2;
        data.roomUpgrade_Bottom_Left_1 = gCont.RoomUpgrade_Bottom_Left_1;
        data.roomUpgrade_Bottom_Left_2 = gCont.RoomUpgrade_Bottom_Left_2;
        data.roomUpgrade_Bottom_Right_1 = gCont.RoomUpgrade_Bottom_Right_1;
        data.roomUpgrade_Bottom_Right_2 = gCont.RoomUpgrade_Bottom_Right_2;
        data.bedroom_1 = gCont.Bedroom_1;
        data.bedroom_2 = gCont.Bedroom_2;
        data.bedroom_3 = gCont.Bedroom_3;
        data.bedroom_4 = gCont.Bedroom_4;
        data.bedroom_5 = gCont.Bedroom_5;
        data.bedroom_6 = gCont.Bedroom_6;
        data.bedroom_1_Occupants = gCont.Bedroom_1_Occupants;
        data.bedroom_2_Occupants = gCont.Bedroom_2_Occupants;
        data.bedroom_3_Occupants = gCont.Bedroom_3_Occupants;
        data.bedroom_4_Occupants = gCont.Bedroom_4_Occupants;
        data.bedroom_5_Occupants = gCont.Bedroom_5_Occupants;
        data.bedroom_6_Occupants = gCont.Bedroom_6_Occupants;
        #endregion
        #region Main Game Stats
        data.player_Turns = gCont.Player_Turns;
        data.player_Tasks = gCont.Player_Tasks;
        data.player_Civilians = gCont.Player_Civilians;
        data.player_Science = gCont.Player_Science;
        #endregion
        #region Main Game Resources
        data.player_Food = gCont.Player_Food;
        data.player_Metal = gCont.Player_Metal;
        data.player_Wood = gCont.Player_Wood;
        data.player_Tech = gCont.Player_Tech;
        data.player_Seeds = gCont.Player_Seeds;
        #endregion

    #endregion
    bf.Serialize(file_Career, data);
        file_Career.Close();
    }
    #endregion

    #region Load Slots
    private void Load_Slot(int slot)
    {
        switch (slot)
        {
            case 1:
                tempPath = savePath_1 + "/" + savePathCareer_1;
                break;
        }
        if (File.Exists(Application.persistentDataPath + "/" + saveFolder + "/" + username + "/" + tempPath)) // edit each version update
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file_Career = File.OpenRead(Application.persistentDataPath + "/" + saveFolder + "/" + username + "/" + tempPath);// edit each version update
            GameData data = (GameData)bf.Deserialize(file_Career);
            file_Career.Close();
            #region Load player data
            //Saved Data to load = data.Variable in this file to load the date too;
            //exampleVariable = data.example;
            // ADD NEW VARIABLES UNDER HERE IN THE STYLE ON THE LINE ABOVE
            gCont.Player_Sound = data.player_Sound;
            #region Vault Heath Items
            gCont.Vault_Health = data.vault_Health;
            gCont.Wall_Left_Upgrade = data.wall_Left_Upgrade;
            gCont.Wall_Left_Health = data.wall_Left_Health;
            gCont.Wall_Right_Upgrade = data.wall_Right_Upgrade;
            gCont.Wall_Right_Health = data.wall_Right_Health;
            #endregion
            #region Vault Room Upgrades
            gCont.Stairs_1 = data.stairs_1;
            gCont.Stairs_2 = data.stairs_2;
            gCont.Stairs_3 = data.stairs_3;

            /// <summary>
            /// Rooms are ordered in layers with left and right number 1 room is closest to the stairs
            /// </summary>
            gCont.Room_Top_Left_1 = data.room_Top_Left_1;
            gCont.Room_Top_Left_2 = data.room_Top_Left_2;
            gCont.Room_Top_Right_1 = data.room_Top_Right_1;
            gCont.Room_Top_Right_2 = data.room_Top_Right_2;
            gCont.Room_Mid_Left_1 = data.room_Mid_Left_1;
            gCont.Room_Mid_Left_2 = data.room_Mid_Left_2;
            gCont.Room_Mid_Right_1 = data.room_Mid_Right_1;
            gCont.Room_Mid_Right_2 = data.room_Mid_Right_2;
            gCont.Room_Bottom_Left_1 = data.room_Bottom_left_1;
            gCont.Room_Bottom_Left_2 = data.room_Bottom_left_2;
            gCont.Room_Bottom_Right_1 = data.room_Bottom_Right_1;
            gCont.Room_Bottom_Right_2 = data.room_Bottom_Right_2;
            /// <summary>
            /// room Upgrade levels only 0 rock 1 first type of room 2 second type of room 3 third type of room
            /// </summary>
            gCont.RoomUpgrade_Top_Left_1 = data.roomUpgrade_Top_Left_1;
            gCont.RoomUpgrade_Top_Left_2 = data.roomUpgrade_Top_Left_2;
            gCont.RoomUpgrade_Top_Right_1 = data.roomUpgrade_Top_Right_1;
            gCont.RoomUpgrade_Top_Right_2 = data.roomUpgrade_Top_Right_2;
            gCont.RoomUpgrade_Mid_Left_1 = data.roomUpgrade_Mid_Left_1;
            gCont.RoomUpgrade_Mid_Left_2 = data.roomUpgrade_Mid_Left_2;
            gCont.RoomUpgrade_Mid_Right_1 = data.roomUpgrade_Mid_Right_1;
            gCont.RoomUpgrade_Mid_Right_2 = data.roomUpgrade_Mid_Right_2;
            gCont.RoomUpgrade_Bottom_Left_1 = data.roomUpgrade_Bottom_Left_1;
            gCont.RoomUpgrade_Bottom_Left_2 = data.roomUpgrade_Bottom_Left_2;
            gCont.RoomUpgrade_Bottom_Right_1 = data.roomUpgrade_Bottom_Right_1;
            gCont.RoomUpgrade_Bottom_Right_2 = data.roomUpgrade_Bottom_Right_2;
            gCont.Bedroom_1 = data.bedroom_1;
            gCont.Bedroom_2 = data.bedroom_2;
            gCont.Bedroom_3 = data.bedroom_3;
            gCont.Bedroom_4 = data.bedroom_4;
            gCont.Bedroom_5 = data.bedroom_5;
            gCont.Bedroom_6 = data.bedroom_6;
            gCont.Bedroom_1_Occupants = data.bedroom_1_Occupants;
            gCont.Bedroom_2_Occupants = data.bedroom_2_Occupants;
            gCont.Bedroom_3_Occupants = data.bedroom_3_Occupants;
            gCont.Bedroom_4_Occupants = data.bedroom_4_Occupants;
            gCont.Bedroom_5_Occupants = data.bedroom_5_Occupants;
            gCont.Bedroom_6_Occupants = data.bedroom_6_Occupants;
            #endregion
            #region Main Game Stats
            gCont.Player_Turns = data.player_Turns;
            gCont.Player_Tasks = data.player_Tasks;
            gCont.Player_Civilians = data.player_Civilians;
            gCont.Player_Science = data.player_Science;
            #endregion
            #region Main Game Resources
            gCont.Player_Food = data.player_Food;
            gCont.Player_Metal = data.player_Metal;
            gCont.Player_Wood = data.player_Wood;
            gCont.Player_Tech = data.player_Tech;
            gCont.Player_Seeds = data.player_Seeds;
            #endregion

            #endregion
        }
    }
    #endregion
    public void Default()
    {/*
        // setting values
        #region Score
        score = 0;
        #endregion
        
        // saving the above set values
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/" + SaveFolder + "/" + usernameForSave + "/" + CurrentSaveLocation);// edit each version update

        GameData data = new GameData();
        
        data.score = gCont.Score;

        bf.Serialize(file, data);
        file.Close();*/
    }

    public void OnApplicationQuit()
    {
        SavingGame();
        Application.Quit();
    }
    public void LoadLevel(string level)
    {
        nextSceneToLoad = level;
        SceneManager.LoadScene(level);
    }
    public void LoadLevelAsync(string level)
    {
        nextSceneToLoad = level;
        SceneManager.LoadScene("LoadingScene");
    }
    public void SavingGame()
    {
        Save();
    }
    public void LoadingGame()
    {
        Load();
    }
    #endregion
    
}
[Serializable]
public class GameData
{
    #region Game Player items
    public bool player_Sound;
    public int vault_Health;
    public int wall_Left_Upgrade;
    public int wall_Left_Health;
    public int wall_Right_Health;
    public int wall_Right_Upgrade;
    #endregion
    #region Vault Room Upgrades
    public bool stairs_1;
    public bool stairs_2;
    public bool stairs_3;

    /// <summary>
    /// Rooms are ordered in layers with left and right number 1 room is closest to the stairs
    /// </summary>
    public bool room_Top_Left_1;
    public bool room_Top_Left_2;
    public bool room_Top_Right_1;
    public bool room_Top_Right_2;
    public bool room_Mid_Left_1;
    public bool room_Mid_Left_2;
    public bool room_Mid_Right_1;
    public bool room_Mid_Right_2;
    public bool room_Bottom_left_1;
    public bool room_Bottom_left_2;
    public bool room_Bottom_Right_1;
    public bool room_Bottom_Right_2;
    /// <summary>
    /// room Upgrade levels only 0 rock 1 first type of room 2 second type of room 3 third type of room
    /// </summary>
    public int roomUpgrade_Top_Left_1;
    public int roomUpgrade_Top_Left_2;
    public int roomUpgrade_Top_Right_1;
    public int roomUpgrade_Top_Right_2;
    public int roomUpgrade_Mid_Left_1;
    public int roomUpgrade_Mid_Left_2;
    public int roomUpgrade_Mid_Right_1;
    public int roomUpgrade_Mid_Right_2;
    public int roomUpgrade_Bottom_Left_1;
    public int roomUpgrade_Bottom_Left_2;
    public int roomUpgrade_Bottom_Right_1;
    public int roomUpgrade_Bottom_Right_2;
    public bool bedroom_1;
    public bool bedroom_2;
    public bool bedroom_3;
    public bool bedroom_4;
    public bool bedroom_5;
    public bool bedroom_6;
    public int bedroom_1_Occupants;
    public int bedroom_2_Occupants;
    public int bedroom_3_Occupants;
    public int bedroom_4_Occupants;
    public int bedroom_5_Occupants;
    public int bedroom_6_Occupants;
    #endregion
    #region Main Game Stats
    public int player_Turns;
    public int player_Tasks;
    public int player_Civilians;
    public int player_Science;
    #endregion
    #region Main Game Resources
    public int player_Food;
    public int player_Metal;
    public int player_Wood;
    public int player_Tech;
    public int player_Seeds;
    #endregion
}
