using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDefs : MonoBehaviour
{
    private GameObject gameCont;
    private GameController gCont;
    private GameObject gameSave;
    private SaveGame gSave;
    private void Start()
    {
        gameCont = GameObject.Find("GameController");
        gCont = gameCont.GetComponent<GameController>();
        gameSave = GameObject.Find("GameSave");
        gSave = gameCont.GetComponent<SaveGame>();
        if (!gCont.PlayerSave)
        {
            SetDefaults();
            gSave.SavingGame();
        }
        else { gSave.LoadingGame(); }
    }
    private void SetDefaults()
    {
        gCont.PlayerSave = true; // sets the save file to true so the game doesnt load defaults
        gCont.Vault_Health = 1000;
        gCont.Wall_Left_Health = 250;
        gCont.Wall_Right_Health = 250;
        gCont.Wall_Left_Upgrade = 0;
        gCont.Wall_Right_Upgrade = 0;
        #region vault stairs
        gCont.Stairs_1 = true;
        gCont.Stairs_2 = false;
        gCont.Stairs_3 = false;
        #endregion
        #region vault room unlocks
        gCont.Room_Top_Left_1 = false;
        gCont.Room_Top_Left_2 = false;
        gCont.Room_Top_Right_1 = false;
        gCont.Room_Top_Right_2 = false;
        gCont.Room_Mid_Left_1 = false;
        gCont.Room_Mid_Left_2 = false;
        gCont.Room_Mid_Right_1 = false;
        gCont.Room_Mid_Right_2 = false;
        gCont.Room_Bot_Left_1 = false;
        gCont.Room_Bot_Left_2 = false;
        gCont.Room_Bot_Right_1 = false;
        gCont.Room_Bot_Right_2 = false;
        #endregion
        #region vault room Upgrade Levels
        gCont.RoomUpgrade_Top_Left_1 = 0;
        gCont.RoomUpgrade_Top_Left_2 = 0;
        gCont.RoomUpgrade_Top_Right_1 = 0;
        gCont.RoomUpgrade_Top_Right_2 = 0;
        gCont.RoomUpgrade_Mid_Left_1 = 0;
        gCont.RoomUpgrade_Mid_Left_2 = 0;
        gCont.RoomUpgrade_Mid_Right_1 = 0;
        gCont.RoomUpgrade_Mid_Right_2 = 0;
        gCont.RoomUpgrade_Bot_Left_1 = 0;
        gCont.RoomUpgrade_Bot_Left_2 = 0;
        gCont.RoomUpgrade_Bot_Right_1 = 0;
        gCont.RoomUpgrade_Bot_Right_2 = 0;
        #endregion
        #region vault bedrooms unlocked
        gCont.Bedroom_1 = false;
        gCont.Bedroom_2 = false;
        gCont.Bedroom_3 = false;
        gCont.Bedroom_4 = false;
        gCont.Bedroom_5 = false;
        gCont.Bedroom_6 = false;
        #endregion
        #region vault bedroom occupants
        gCont.Bedroom_1_Occupants = 0;
        gCont.Bedroom_2_Occupants = 0;
        gCont.Bedroom_3_Occupants = 0;
        gCont.Bedroom_4_Occupants = 0;
        gCont.Bedroom_5_Occupants = 0;
        gCont.Bedroom_6_Occupants = 0;
        #endregion
        #region Player Main Stats
        gCont.Player_Turns = 0;
        gCont.Player_Tasks = 0;
        gCont.Player_Civilians = 0;
        gCont.Player_Science = 0;
        #endregion
        #region Player Game Resources
        gCont.Player_Food = 0;
        gCont.Player_Metal = 0;
        gCont.Player_Wood = 0;
        gCont.Player_Tech = 0;
        gCont.Player_Seeds = 0;
        #endregion
    }
}
