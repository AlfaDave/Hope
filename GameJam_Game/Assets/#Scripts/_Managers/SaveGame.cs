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
  
    private GameController gCont;
    #region Variables
    //private bool saveHasBeenCreated = false;
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
    public bool CheckForSave() { return gCont.PlayerSave; }
    private void LocateGameController()
    {
                                                        // super heavy cpu usage and will kill framerate if its put in update or fixed update for example.
        gCont = GameObject.Find("GameController").GetComponent<GameController>(); // < linking the script by using the gameobject reference 
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
        data.playerSave = gCont.PlayerSave;
        data.player_Sound = gCont.Player_Sound;
        #region Vault Heath Items
        data.vault_Health = gCont.Vault_Health;
        data.wall_L_Health = gCont.Wall_L_Health;
        data.wall_R_Health = gCont.Wall_R_Health;
        #endregion

        #region DefaultBuildings
        data.room_Radio = gCont.Room_Radio;
        data.room_Expedition = gCont.Room_Expedition;
        data.room_UndergroundGarden = gCont.Room_UndergroundGarden;
        data.room_Training = gCont.Room_Training;
        #endregion
        #region Vault Room Upgrades
        data.stairs_1 = gCont.Stairs_1;
        data.stairs_2 = gCont.Stairs_2;
        data.stairs_3 = gCont.Stairs_3;
        data.stairs_2_Clicks_Unlock = gCont.Stairs_2_Clicks_Unlock;
        data.stairs_3_Clicks_Unlock = gCont.Stairs_3_Clicks_Unlock;
        data.wall_L = gCont.Wall_L;
        data.wall_R = gCont.Wall_R;
        data.wall_L_Clicks_Unlock = gCont.Wall_L_Clik_Unlock;
        data.wall_R_Clicks_Unlock = gCont.Wall_R_Clik_Unlock;
        data.wall_L_Upg = gCont.Wall_L_Upg;
        data.wall_R_Upg = gCont.Wall_R_Upg;

        /// <summary>
        /// Rooms are ordered in layers with left and right number 1 room is closest to the stairs
        /// </summary>
        data.underGarden_Lvl1_L1 = gCont.UnderGarden_Lvl1_L1;
        data.radio_Lvl1_L2 = gCont.Radio_Lvl1_L2;
        data.expedition_Lvl1_R1 = gCont.Expedition_Lvl1_R1;
        data.training_Lvl1_R2 = gCont.Training_Lvl1_R2;
        data.workshop_Lvl2_L1 = gCont.Workshop_Lvl2_L1;
        data.workshop_Lvl2_L2 = gCont.Workshop_Lvl2_L2;
        data.generator_Lvl2_R1 = gCont.Generator_Lvl2_R1;
        data.generator_Lvl2_R2 = gCont.Generator_Lvl2_R2;
        data.research_Lvl3_L1 = gCont.Research_Lvl3_L1;
        data.research_Lvl3_L2 = gCont.Research_Lvl3_L2;
        data.livingSpace_Lvl3_R1 = gCont.LivingSpace_Lvl3_R1;
        data.livingSpace_Lvl3_R2 = gCont.LivingSpace_Lvl3_R2;
        /// <summary>
        /// room Upgrade levels only 0 rock 1 first type of room 2 second type of room 3 third type of room
        /// </summary>
        data.underGarden_Upg_Lvl1_L1 = gCont.UnderGarden_Upg_Lvl1_L1;
        data.radio_Upg_Lvl1_L2 = gCont.Radio_Upg_Lvl1_L2;
        data.expedition_Upg_Lvl1_R1 = gCont.Expedition_Upg_Lvl1_R1;
        data.training_Upg_Lvl1_R2 = gCont.Training_Upg_Lvl1_R2;
        data.workshop_Upg_Lvl2_L1 = gCont.Workshop_Upg_Lvl2_L1;
        data.workshop_Upg_Lvl2_L2 = gCont.Workshop_Upg_Lvl2_L2;
        data.generator_Upg_Lvl2_R1 = gCont.Generator_Upg_Lvl2_R1;
        data.generator_Upg_Lvl2_R2 = gCont.Generator_Upg_Lvl2_R2;
        data.research_Upg_Lvl3_L1 = gCont.Research_Upg_Lvl3_L1;
        data.research_Upg_Lvl3_L2 = gCont.Research_Upg_Lvl3_L2;
        data.livingSpace_Upg_Lvl3_R1 = gCont.LivingSpace_Upg_Lvl3_R1;
        data.livingSpace_Upg_Lvl3_R2 = gCont.LivingSpace_Upg_Lvl3_R2;
        data.bedroom_1 = gCont.Bedroom_Lvl1_L;
        data.bedroom_2 = gCont.Bedroom_Lvl1_R;
        data.bedroom_3 = gCont.Bedroom_Lvl2_L;
        data.bedroom_4 = gCont.Bedroom_Lvl2_R;
        data.bedroom_5 = gCont.Bedroom_Lvl3_L;
        data.bedroom_6 = gCont.Bedroom_Lvl3_R;
        data.bedroom_1_Occupants = gCont.Bedroom_Upg_Lvl1_L;
        data.bedroom_2_Occupants = gCont.Bedroom_Upg_Lvl1_R;
        data.bedroom_3_Occupants = gCont.Bedroom_Upg_Lvl2_L;
        data.bedroom_4_Occupants = gCont.Bedroom_Upg_Lvl2_R;
        data.bedroom_5_Occupants = gCont.Bedroom_Upg_Lvl3_L;
        data.bedroom_6_Occupants = gCont.Bedroom_Upg_Lvl3_R;
        data.bedroom_1_Clicks_Unlock = gCont.Bedroom_Lvl1_L_Clik_Unlock;
        data.bedroom_2_Clicks_Unlock = gCont.Bedroom_Lvl1_R_Clik_Unlock;
        data.bedroom_3_Clicks_Unlock = gCont.Bedroom_Lvl2_L_Clik_Unlock;
        data.bedroom_4_Clicks_Unlock = gCont.Bedroom_Lvl2_R_Clik_Unlock;
        data.bedroom_5_Clicks_Unlock = gCont.Bedroom_Lvl3_L_Clik_Unlock;
        data.bedroom_6_Clicks_Unlock = gCont.Bedroom_Lvl3_R_Clik_Unlock;
        #endregion
        #region Main Game Stats
        data.player_Turns = gCont.Player_Turns;
        data.player_Tasks = gCont.Player_Tasks;
        data.player_People = gCont.Player_People;
        data.player_Capacity = gCont.Player_Capacity;
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
            gCont.PlayerSave = data.playerSave;
            gCont.Player_Sound = data.player_Sound;
            #region Vault Heath Items
            gCont.Vault_Health = data.vault_Health;
            #endregion
            #region DefaultBuildings
            gCont.Room_Radio = data.room_Radio;
            gCont.Room_Expedition = data.room_Expedition;
            gCont.Room_UndergroundGarden = data.room_UndergroundGarden;
            gCont.Room_Training = data.room_Training;
            #endregion
            #region Vault Room Upgrades
            gCont.Stairs_1 = data.stairs_1;
            gCont.Stairs_2 = data.stairs_2;
            gCont.Stairs_3 = data.stairs_3;
            gCont.Stairs_2_Clicks_Unlock = data.stairs_2_Clicks_Unlock;
            gCont.Stairs_3_Clicks_Unlock = data.stairs_3_Clicks_Unlock;

            gCont.Wall_L = data.wall_L;
            gCont.Wall_R = data.wall_R;
            gCont.Wall_L_Clik_Unlock = data.wall_L_Clicks_Unlock;
            gCont.Wall_R_Clik_Unlock = data.wall_R_Clicks_Unlock;
            gCont.Wall_L_Upg = data.wall_L_Upg;
            gCont.Wall_R_Upg = data.wall_R_Upg;
            gCont.Wall_L_Health = data.wall_L_Health;
            gCont.Wall_R_Health = data.wall_R_Health;
            /// <summary>
            /// Rooms are ordered in layers with left and right number 1 room is closest to the stairs
            /// </summary>
            gCont.UnderGarden_Lvl1_L1 = data.underGarden_Lvl1_L1;
            gCont.Radio_Lvl1_L2 = data.radio_Lvl1_L2;
            gCont.Expedition_Lvl1_R1 = data.expedition_Lvl1_R1;
            gCont.Training_Lvl1_R2 = data.training_Lvl1_R2;
            gCont.Workshop_Lvl2_L1 = data.workshop_Lvl2_L1;
            gCont.Workshop_Lvl2_L2 = data.workshop_Lvl2_L2;
            gCont.Generator_Lvl2_R1 = data.generator_Lvl2_R1;
            gCont.Generator_Lvl2_R2 = data.generator_Lvl2_R2;
            gCont.Research_Lvl3_L1 = data.research_Lvl3_L1;
            gCont.Research_Lvl3_L2 = data.research_Lvl3_L2;
            gCont.LivingSpace_Lvl3_R1 = data.livingSpace_Lvl3_R1;
            gCont.LivingSpace_Lvl3_R2 = data.livingSpace_Lvl3_R2;
            /// <summary>
            /// room Upgrade levels only 0 rock 1 first type of room 2 second type of room 3 third type of room
            /// </summary>
            gCont.UnderGarden_Upg_Lvl1_L1 = data.underGarden_Upg_Lvl1_L1;
            gCont.Radio_Upg_Lvl1_L2 = data.radio_Upg_Lvl1_L2;
            gCont.Expedition_Upg_Lvl1_R1 = data.expedition_Upg_Lvl1_R1;
            gCont.Training_Upg_Lvl1_R2 = data.training_Upg_Lvl1_R2;
            gCont.Workshop_Upg_Lvl2_L1 = data.workshop_Upg_Lvl2_L1;
            gCont.Workshop_Upg_Lvl2_L2 = data.workshop_Upg_Lvl2_L2;
            gCont.Generator_Upg_Lvl2_R1 = data.generator_Upg_Lvl2_R1;
            gCont.Generator_Upg_Lvl2_R2 = data.generator_Upg_Lvl2_R2;
            gCont.Research_Upg_Lvl3_L1 = data.research_Upg_Lvl3_L1;
            gCont.Research_Upg_Lvl3_L2 = data.research_Upg_Lvl3_L2;
            gCont.LivingSpace_Upg_Lvl3_R1 = data.livingSpace_Upg_Lvl3_R1;
            gCont.LivingSpace_Upg_Lvl3_R2 = data.livingSpace_Upg_Lvl3_R2;
            gCont.Bedroom_Lvl1_L = data.bedroom_1;
            gCont.Bedroom_Lvl1_R = data.bedroom_2;
            gCont.Bedroom_Lvl2_L = data.bedroom_3;
            gCont.Bedroom_Lvl2_R = data.bedroom_4;
            gCont.Bedroom_Lvl3_L = data.bedroom_5;
            gCont.Bedroom_Lvl3_R = data.bedroom_6;
            gCont.Bedroom_Upg_Lvl1_L = data.bedroom_1_Occupants;
            gCont.Bedroom_Upg_Lvl1_R = data.bedroom_2_Occupants;
            gCont.Bedroom_Upg_Lvl2_L = data.bedroom_3_Occupants;
            gCont.Bedroom_Upg_Lvl2_R = data.bedroom_4_Occupants;
            gCont.Bedroom_Upg_Lvl3_L = data.bedroom_5_Occupants;
            gCont.Bedroom_Upg_Lvl3_R = data.bedroom_6_Occupants;
            gCont.Bedroom_Lvl1_L_Clik_Unlock = data.bedroom_1_Clicks_Unlock;
            gCont.Bedroom_Lvl1_R_Clik_Unlock = data.bedroom_2_Clicks_Unlock;
            gCont.Bedroom_Lvl2_L_Clik_Unlock = data.bedroom_3_Clicks_Unlock;
            gCont.Bedroom_Lvl2_R_Clik_Unlock = data.bedroom_4_Clicks_Unlock;
            gCont.Bedroom_Lvl3_L_Clik_Unlock = data.bedroom_5_Clicks_Unlock;
            gCont.Bedroom_Lvl3_R_Clik_Unlock = data.bedroom_6_Clicks_Unlock;
            #endregion
            #region Main Game Stats
            gCont.Player_Turns = data.player_Turns;
            gCont.Player_Tasks = data.player_Tasks;
            gCont.Player_People = data.player_People;
            gCont.Player_Capacity = data.player_Capacity;
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
        //SavingGame();
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
    public bool playerSave;
    public bool player_Sound;
    public int vault_Health;
    #endregion
    #region Default Buildings
    public int room_Radio;
    public int room_Expedition;
    public int room_UndergroundGarden;
    public int room_Training;
    #endregion
    #region Vault Room Upgrades
    public bool stairs_1;
    public bool stairs_2;
    public bool stairs_3;
    public int stairs_2_Clicks_Unlock;
    public int stairs_3_Clicks_Unlock;
    public bool wall_L;
    public bool wall_R;
    public int wall_L_Clicks_Unlock;
    public int wall_R_Clicks_Unlock;
    public int wall_L_Upg;
    public int wall_R_Upg;
    public int wall_L_Health;
    public int wall_R_Health;

    /// <summary>
    /// Rooms are ordered in layers with left and right number 1 room is closest to the stairs
    /// </summary>
    public bool underGarden_Lvl1_L1;
    public bool radio_Lvl1_L2;
    public bool expedition_Lvl1_R1;
    public bool training_Lvl1_R2;
    public bool workshop_Lvl2_L1;
    public bool workshop_Lvl2_L2;
    public bool generator_Lvl2_R1;
    public bool generator_Lvl2_R2;
    public bool research_Lvl3_L1;
    public bool research_Lvl3_L2;
    public bool livingSpace_Lvl3_R1;
    public bool livingSpace_Lvl3_R2;
    /// <summary>
    /// room Upgrade levels only 0 rock 1 first type of room 2 second type of room 3 third type of room
    /// </summary>
    public int underGarden_Upg_Lvl1_L1;
    public int radio_Upg_Lvl1_L2;
    public int expedition_Upg_Lvl1_R1;
    public int training_Upg_Lvl1_R2;
    public int workshop_Upg_Lvl2_L1;
    public int workshop_Upg_Lvl2_L2;
    public int generator_Upg_Lvl2_R1;
    public int generator_Upg_Lvl2_R2;
    public int research_Upg_Lvl3_L1;
    public int research_Upg_Lvl3_L2;
    public int livingSpace_Upg_Lvl3_R1;
    public int livingSpace_Upg_Lvl3_R2;
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
    public int bedroom_1_Clicks_Unlock;
    public int bedroom_2_Clicks_Unlock;
    public int bedroom_3_Clicks_Unlock;
    public int bedroom_4_Clicks_Unlock;
    public int bedroom_5_Clicks_Unlock;
    public int bedroom_6_Clicks_Unlock;
    #endregion
    #region Main Game Stats
    public int player_Turns;
    public int player_Tasks;
    public int player_People;
    public int player_Capacity;
    public int player_Science;
    #endregion
    #region Main Game Resources
    public int player_Food;
    public int player_Metal;
    public int player_Wood;
    public int player_Tech;
    public int player_Seeds;
    #endregion
    #region Gameplay Mechanics
    //public float wait_BetweenPress;
    #endregion
}
