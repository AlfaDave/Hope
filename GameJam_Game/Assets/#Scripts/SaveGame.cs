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
    private int exampleVariable;
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
    #region load and save tasks
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
        #region player data
        //data. Saved data Variable = Variable instance location to copy from;
        data.example = exampleVariable;
        // ADD NEW VARIABLES UNDER HERE IN THE STYLE ON THE LINE ABOVE
        data.player_Score = gCont.Player_Score;

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
            #region player
            //Saved Data to load = data.Variable in this file to load the date too;
            exampleVariable = data.example;
            // ADD NEW VARIABLES UNDER HERE IN THE STYLE ON THE LINE ABOVE
            gCont.Player_Score = data.player_Score;

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
    public int example;
    
    public int player_Score;
    #endregion
}
