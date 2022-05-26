using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetDefs : MonoBehaviour
{
    [SerializeField] internal GameController gCont;
    [SerializeField] internal SaveGame gSave;
    private void Start()
    {
        gCont = GameObject.Find("GameController").GetComponent<GameController>();
        gSave = GameObject.Find("GameSave").GetComponent<SaveGame>();
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
        #region Default Buildings
        gCont.Room_Radio = 1;
        gCont.Room_Training = 1;
        gCont.Room_Expedition = 1;
        gCont.Room_UndergroundGarden = 1;
        #endregion
        #region vault stairs
        gCont.Stairs_1 = true;
        gCont.Stairs_2 = false;
        gCont.Stairs_3 = false;
        #endregion
        #region vault Stairs Clicks to unlock
        gCont.Stairs_2_Clicks_Unlock = 0;
        gCont.Stairs_3_Clicks_Unlock = 0;
        #endregion
        #region vault room unlocks
        gCont.UnderGarden_Lvl1_L1 = false;
        gCont.Radio_Lvl1_L2 = false;
        gCont.Expedition_Lvl1_R1 = false;
        gCont.Training_Lvl1_R2 = false;
        gCont.Workshop_Lvl2_L1 = false;
        gCont.Workshop_Lvl2_L2 = false;
        gCont.Generator_Lvl2_R1 = false;
        gCont.Generator_Lvl2_R2 = false;
        gCont.Research_Lvl3_L1 = false;
        gCont.Research_Lvl3_L2 = false;
        gCont.LivingSpace_Lvl3_R1 = false;
        gCont.LivingSpace_Lvl3_R2 = false;
        #endregion
        #region vault room Upgrade Levels
        gCont.UnderGarden_Upg_Lvl1_L1 = 0;
        gCont.Radio_Upg_Lvl1_L2 = 0;
        gCont.Expedition_Upg_Lvl1_R1 = 0;
        gCont.Training_Upg_Lvl1_R2 = 0;
        gCont.Workshop_Upg_Lvl2_L1 = 0;
        gCont.Workshop_Upg_Lvl2_L2 = 0;
        gCont.Generator_Upg_Lvl2_R1 = 0;
        gCont.Generator_Upg_Lvl2_R2 = 0;
        gCont.Research_Upg_Lvl3_L1 = 0;
        gCont.Research_Upg_Lvl3_L2 = 0;
        gCont.LivingSpace_Upg_Lvl3_R1 = 0;
        gCont.LivingSpace_Upg_Lvl3_R2 = 0;
        #endregion
        #region vault bedrooms unlocked
        gCont.Bedroom_Lvl1_L = false;
        gCont.Bedroom_Lvl1_R = false;
        gCont.Bedroom_Lvl2_L = false;
        gCont.Bedroom_Lvl2_R = false;
        gCont.Bedroom_Lvl3_L = false;
        gCont.Bedroom_Lvl3_R = false;
        #endregion
        #region vault bedroom occupants
        gCont.Bedroom_Upg_Lvl1_L = 0;
        gCont.Bedroom_Upg_Lvl1_R = 0;
        gCont.Bedroom_Upg_Lvl2_L = 0;
        gCont.Bedroom_Upg_Lvl2_R = 0;
        gCont.Bedroom_Upg_Lvl3_L = 0;
        gCont.Bedroom_Upg_Lvl3_R = 0;
        #endregion
        #region vault bedroom Clicks to unlock
        gCont.Bedroom_Lvl1_L_Clik_Unlock = 0;
        gCont.Bedroom_Lvl1_R_Clik_Unlock = 0;
        gCont.Bedroom_Lvl2_L_Clik_Unlock = 0;
        gCont.Bedroom_Lvl2_R_Clik_Unlock = 0;
        gCont.Bedroom_Lvl3_L_Clik_Unlock = 0;
        gCont.Bedroom_Lvl3_R_Clik_Unlock = 0;
        #endregion
        #region Player Main Stats
        gCont.Player_Turns = 0;
        gCont.Player_Tasks = 0;
        gCont.Player_People = 0;
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
