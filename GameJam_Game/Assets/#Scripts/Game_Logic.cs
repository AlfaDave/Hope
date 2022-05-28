using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Logic : MonoBehaviour
{
    private GameController GC;
    private SaveGame gSave;
    [SerializeField] internal GameObject display_Res_Progress, display_Res_Items;
    private GameObject display_Res_Turns, display_Res_Tasks, display_Res_People, display_Res_Science;
    private GameObject display_Res_Food, display_Res_Metal, display_Res_Wood, display_Res_Tech, display_Res_Seeds;
    private Text display_Text_Res_Turns_Shadow, display_Text_Res_Tasks_Shadow, display_Text_Res_People_Shadow, display_Text_Res_Capacity_Shadow, display_Text_Res_Science_Shadow;
    private Text display_Text_Res_Food_Shadow, display_Text_Res_Metal_Shadow, display_Text_Res_Wood_Shadow, display_Text_Res_Tech_Shadow, display_Text_Res_Seeds_Shadow;
    private Text display_Text_Res_Turns, display_Text_Res_Tasks, display_Text_Res_People, display_Text_Res_Capacity, display_Text_Res_Science;
    private Text display_Text_Res_Food, display_Text_Res_Metal, display_Text_Res_Wood, display_Text_Res_Tech, display_Text_Res_Seeds;
    [SerializeField] internal GameObject res_Metal, res_Wood, res_Food, res_Tech;
    [SerializeField] internal GameObject hatch, wall_Left, wall_Right, stairs_1, stairs_2, stairs_3;
    [SerializeField] internal GameObject underGarden_Lvl1_L1, radio_Lvl1_L2, expedition_Lvl1_R1, training_Lvl1_R2, workshop_Lvl2_L1, workshop_Lvl2_L2, generator_Lvl2_R1, generator_Lvl2_R2, research_Lvl3_L1, research_Lvl3_L2, livingSpace_Lvl3_R1, livingSpace_Lvl3_R2, bedroom_Lvl1_L, bedroom_Lvl1_R, bedroom_Lvl2_L, bedroom_Lvl2_R, bedroom_Lvl3_L, bedroom_Lvl3_R;
    #region Buttons for gathering
    private Button res_Metal_Button, res_Wood_Button, res_Food_Button, res_Tech_Button;
    #endregion
    #region Buttons for Repair
    private Button hatch_Button, wall_Left_Button, wall_Right_Button;
    #endregion
    #region Buttons for Stairs
    private Button stairs_1_Button, stairs_2_Button, stairs_3_Button;
    #endregion
    #region Buttons for Rooms
    private Button underGarden_Lvl1_L1_Button, radio_Lvl1_L2_Button, expedition_Lvl1_R1_Button, training_Lvl1_R2_Button, workshop_Lvl2_L1_Button, workshop_Lvl2_L2_Button, generator_Lvl2_R1_Button, generator_Lvl2_R2_Button, research_Lvl3_L1_Button, research_Lvl3_L2_Button, livingSpace_Lvl3_R1_Button, livingSpace_Lvl3_R2_Button, bedroom_lvl1_L_Button, bedroom_Lvl1_R_Button, bedroom_Lvl2_L_Button, bedroom_Lvl2_R_Button, bedroom_Lvl3_L_Button, bedroom_Lvl3_R_Button;
    #endregion
    #region Upgrade GameObjects
    #region Bedrooms
    private GameObject bedroom_Lvl1_L_Rock, bedroom_Lvl1_L_Up_1, bedroom_Lvl1_L_Up_2, bedroom_Lvl1_L_Up_3, bedroom_Lvl1_L_Up_4, bedroom_Lvl1_L_Up_5, bedroom_Lvl1_L_Up_6, bedroom_Lvl1_L_Up_7, bedroom_Lvl1_L_Up_8, bedroom_Lvl1_L_Up_9, bedroom_Lvl1_L_Up_10;
    private GameObject bedroom_Lvl2_L_Rock, bedroom_Lvl2_L_Up_1, bedroom_Lvl2_L_Up_2, bedroom_Lvl2_L_Up_3, bedroom_Lvl2_L_Up_4, bedroom_Lvl2_L_Up_5, bedroom_Lvl2_L_Up_6, bedroom_Lvl2_L_Up_7, bedroom_Lvl2_L_Up_8, bedroom_Lvl2_L_Up_9, bedroom_Lvl2_L_Up_10;
    private GameObject bedroom_Lvl3_L_Rock, bedroom_Lvl3_L_Up_1, bedroom_Lvl3_L_Up_2, bedroom_Lvl3_L_Up_3, bedroom_Lvl3_L_Up_4, bedroom_Lvl3_L_Up_5, bedroom_Lvl3_L_Up_6, bedroom_Lvl3_L_Up_7, bedroom_Lvl3_L_Up_8, bedroom_Lvl3_L_Up_9, bedroom_Lvl3_L_Up_10;
    private GameObject bedroom_Lvl1_R_Rock, bedroom_Lvl1_R_Up_1, bedroom_Lvl1_R_Up_2, bedroom_Lvl1_R_Up_3, bedroom_Lvl1_R_Up_4, bedroom_Lvl1_R_Up_5, bedroom_Lvl1_R_Up_6, bedroom_Lvl1_R_Up_7, bedroom_Lvl1_R_Up_8, bedroom_Lvl1_R_Up_9, bedroom_Lvl1_R_Up_10;
    private GameObject bedroom_Lvl2_R_Rock, bedroom_Lvl2_R_Up_1, bedroom_Lvl2_R_Up_2, bedroom_Lvl2_R_Up_3, bedroom_Lvl2_R_Up_4, bedroom_Lvl2_R_Up_5, bedroom_Lvl2_R_Up_6, bedroom_Lvl2_R_Up_7, bedroom_Lvl2_R_Up_8, bedroom_Lvl2_R_Up_9, bedroom_Lvl2_R_Up_10;
    private GameObject bedroom_Lvl3_R_Rock, bedroom_Lvl3_R_Up_1, bedroom_Lvl3_R_Up_2, bedroom_Lvl3_R_Up_3, bedroom_Lvl3_R_Up_4, bedroom_Lvl3_R_Up_5, bedroom_Lvl3_R_Up_6, bedroom_Lvl3_R_Up_7, bedroom_Lvl3_R_Up_8, bedroom_Lvl3_R_Up_9, bedroom_Lvl3_R_Up_10;
    #endregion
    #region Stairs
    private GameObject stairs_1_Locked, stairs_1_Unlocked, stairs_2_Locked, stairs_2_Unlocked, stairs_3_Locked, stairs_3_Unlocked;
    #endregion
    #region Walls
    private GameObject wall_Left_None, wall_Left_Up_1, wall_Left_Up_2, wall_Left_Up_3, wall_Left_Up_4, wall_Left_Up_5, wall_Left_Up_6, wall_Left_Up_7, wall_Left_Up_8, wall_Left_Up_9, wall_Left_Up_10;
    private GameObject wall_Right_None, wall_Right_Up_1, wall_Right_Up_2, wall_Right_Up_3, wall_Right_Up_4, wall_Right_Up_5, wall_Right_Up_6, wall_Right_Up_7, wall_Right_Up_8, wall_Right_Up_9, wall_Right_Up_10;
    #endregion
    #region Main Rooms
    private GameObject underGarden_Lvl1_L1_Def, underGarden_Lvl1_L1_Up_1, underGarden_Lvl1_L1_Up_2, underGarden_Lvl1_L1_Up_3, underGarden_Lvl1_L1_Up_4, underGarden_Lvl1_L1_Up_5;
    private GameObject radio_Lvl1_L2_Def, radio_Lvl1_L2_Up_1, radio_Lvl1_L2_Up_2, radio_Lvl1_L2_Up_3, radio_Lvl1_L2_Up_4, radio_Lvl1_L2_Up_5;
    private GameObject expedition_Lvl1_R1_Def, expedition_Lvl1_R1_Up_1, expedition_Lvl1_R1_Up_2, expedition_Lvl1_R1_Up_3, expedition_Lvl1_R1_Up_4, expedition_Lvl1_R1_Up_5;
    private GameObject training_Lvl1_R2_Def, training_Lvl1_R2_Up_1, training_Lvl1_R2_Up_2, training_Lvl1_R2_Up_3, training_Lvl1_R2_Up_4, training_Lvl1_R2_Up_5;
    private GameObject workshop_Lvl2_L1_Def, workshop_Lvl2_L1_Up_1, workshop_Lvl2_L1_Up_2, workshop_Lvl2_L1_Up_3, workshop_Lvl2_L1_Up_4, workshop_Lvl2_L1_Up_5;
    private GameObject workshop_Lvl2_L2_Def, workshop_Lvl2_L2_Up_1, workshop_Lvl2_L2_Up_2, workshop_Lvl2_L2_Up_3, workshop_Lvl2_L2_Up_4, workshop_Lvl2_L2_Up_5;
    private GameObject generator_Lvl2_R1_Def, generator_Lvl2_R1_Up_1, generator_Lvl2_R1_Up_2, generator_Lvl2_R1_Up_3, generator_Lvl2_R1_Up_4, generator_Lvl2_R1_Up_5;
    private GameObject generator_Lvl2_R2_Def, generator_Lvl2_R2_Up_1, generator_Lvl2_R2_Up_2, generator_Lvl2_R2_Up_3, generator_Lvl2_R2_Up_4, generator_Lvl2_R2_Up_5;
    private GameObject research_Lvl3_L1_Def, research_Lvl3_L1_Up_1, research_Lvl3_L1_Up_2, research_Lvl3_L1_Up_3, research_Lvl3_L1_Up_4, research_Lvl3_L1_Up_5;
    private GameObject research_Lvl3_L2_Def, research_Lvl3_L2_Up_1, research_Lvl3_L2_Up_2, research_Lvl3_L2_Up_3, research_Lvl3_L2_Up_4, research_Lvl3_L2_Up_5;
    private GameObject livingSpace_Lvl3_R1_Def, livingSpace_Lvl3_R1_Up_1, livingSpace_Lvl3_R1_Up_2, livingSpace_Lvl3_R1_Up_3, livingSpace_Lvl3_R1_Up_4, livingSpace_Lvl3_R1_Up_5;
    private GameObject livingSpace_Lvl3_R2_Def, livingSpace_Lvl3_R2_Up_1, livingSpace_Lvl3_R2_Up_2, livingSpace_Lvl3_R2_Up_3, livingSpace_Lvl3_R2_Up_4, livingSpace_Lvl3_R2_Up_5;
    #endregion
    #endregion

    private bool wait_Metal;
    private bool wait_Wood;
    private bool wait_Food;
    private bool wait_Tech;
    private float wait_Button_Defaults = 30;
    private float wait_Button_Metal;
    private float wait_Button_Wood;
    private float wait_Button_Food;
    private float wait_Button_Tech;
    private float tempMetal, tempWood, tempFood, tempTech;
    //private float WaitResearchBonus = 0;
    //private float WaitWorkshopBonus = 0;
    //private float WaitPowerGenBonus = 0;
    //private float WaitLivingSpace = 0;
    private int purchaseValue = 250;
    private void Waiting_Metal()
    {

    }
    private void Waiting_Wood()
    {

    }
    private void Waiting_Food()
    {

    }
    private void Waiting_Tech()
    {

    }
    private void Start()
    {
        
        FindAllStatics();
        gSave.LoadingGame();
        LinkAllItemsInGame(); // these extra functions are just used to logically track the game logic steps
        //
        TurnOffUnwantedItems(); // these extra functions are just used to logically track the game logic steps
        //
        TurnOnAllVitalInitialItems();
        //
        CheckRoomUnlockProgress();
        DiplayUiStats();
        CheatMode();
        DiplayUiStats();
    }
    private void Update()
    {
        if (wait_Metal) { wait_Button_Metal -= Time.deltaTime; Debug.Log("wait button metal "+wait_Button_Metal); if(wait_Button_Metal <= 0) { Unlock_Metal_Button(); } }
        if (wait_Wood) { wait_Button_Wood -= Time.deltaTime; Debug.Log("wait button wood " + wait_Button_Wood); if (wait_Button_Wood <= 0) { Unlock_Wood_Button(); } }
        if (wait_Food) { wait_Button_Food -= Time.deltaTime; Debug.Log("wait button food " + wait_Button_Food); if (wait_Button_Food <= 0) { Unlock_Food_Button(); } }
        if (wait_Tech) { wait_Button_Tech -= Time.deltaTime; Debug.Log("wait button tech " + wait_Button_Tech); if (wait_Button_Tech <= 0) { Unlock_Tech_Button(); } }
    }
    private void FindAllStatics()
    {
        gSave = GameObject.Find("GameSave").GetComponent<SaveGame>();
        GC = GameObject.Find("GameController").GetComponent<GameController>();
    }
    private void SetDefaults()
    {
        if (GC.Player_Capacity < 3) { GC.Player_Capacity = 3; }
        if(GC.Player_People >= GC.Player_Capacity) { GC.Player_People = GC.Player_Capacity; }
    }
    private void LinkAllItemsInGame()/// must be step 1 in game sequence
    {
        
        LinkButtons();
        LinkArtGameObjects();
        LinkUiItems();
    }
    private void TurnOffUnwantedItems()
    {
        TurnAllItemsOff();
    }
    private void TurnOnAllVitalInitialItems()
    {
        SetDefaultBuildingsViewsAndSetThemInCode();
        SetDefaults();
    }
    private void CheatMode()
    {
        GC.Bedroom_Lvl1_L_Clik_Unlock = 9999999;
        GC.Bedroom_Lvl2_L_Clik_Unlock = 9999999;
        GC.Bedroom_Lvl3_L_Clik_Unlock = 9999999;
        GC.Bedroom_Lvl1_R_Clik_Unlock = 9999999;
        GC.Bedroom_Lvl2_R_Clik_Unlock = 9999999;
        GC.Bedroom_Lvl3_R_Clik_Unlock = 9999999;

        GC.Stairs_2_Clicks_Unlock = 9999999;
        GC.Stairs_3_Clicks_Unlock = 9999999;

        GC.Wall_L_Clik_Unlock = 9999999;
        GC.Wall_R_Clik_Unlock = 9999999;

        GC.Player_Metal = 9999999;
        GC.Player_Wood = 9999999;
        GC.Player_Tech = 9999999;
        GC.Player_Food = 9999999;

        GC.Player_People = 9999999;
        GC.Player_Science = 9999999;
        GC.Player_Seeds = 9999999;
        GC.Player_Tasks = 9999999;
        GC.Player_Turns = 9999999;
    }
    private void DiplayUiStats()
    {
        display_Text_Res_Turns.text = GC.Player_Turns.ToString();
        display_Text_Res_Tasks.text = GC.Player_Tasks.ToString();
        display_Text_Res_People.text = GC.Player_People.ToString();
        display_Text_Res_Capacity.text = GC.Player_Capacity.ToString();
        display_Text_Res_Science.text = GC.Player_Science.ToString();
        display_Text_Res_Food.text = GC.Player_Food.ToString();
        display_Text_Res_Metal.text = GC.Player_Metal.ToString();
        display_Text_Res_Wood.text = GC.Player_Wood.ToString();
        display_Text_Res_Tech.text = GC.Player_Tech.ToString();
        display_Text_Res_Seeds.text = GC.Player_Seeds.ToString();

        display_Text_Res_Turns_Shadow.text = GC.Player_Turns.ToString();
        display_Text_Res_Tasks_Shadow.text = GC.Player_Tasks.ToString();
        display_Text_Res_People_Shadow.text = GC.Player_People.ToString();
        display_Text_Res_Capacity_Shadow.text = GC.Player_Capacity.ToString();
        display_Text_Res_Science_Shadow.text = GC.Player_Science.ToString();
        display_Text_Res_Food_Shadow.text = GC.Player_Food.ToString();
        display_Text_Res_Metal_Shadow.text = GC.Player_Metal.ToString();
        display_Text_Res_Wood_Shadow.text = GC.Player_Wood.ToString();
        display_Text_Res_Tech_Shadow.text = GC.Player_Tech.ToString();
        display_Text_Res_Seeds_Shadow.text = GC.Player_Seeds.ToString();
    }
    private void LinkUiItems()
    {
        display_Res_Turns = display_Res_Progress.transform.GetChild(0).GetChild(0).gameObject;
        display_Res_Tasks = display_Res_Progress.transform.GetChild(0).GetChild(1).gameObject;
        display_Res_People = display_Res_Progress.transform.GetChild(0).GetChild(2).gameObject;
        display_Res_Science = display_Res_Progress.transform.GetChild(0).GetChild(3).gameObject;
        display_Res_Seeds = display_Res_Progress.transform.GetChild(0).GetChild(4).gameObject;

        display_Res_Food = display_Res_Items.transform.GetChild(0).GetChild(0).gameObject;
        display_Res_Metal = display_Res_Items.transform.GetChild(0).GetChild(1).gameObject;
        display_Res_Wood = display_Res_Items.transform.GetChild(0).GetChild(2).gameObject;
        display_Res_Tech = display_Res_Items.transform.GetChild(0).GetChild(3).gameObject;

        display_Text_Res_Turns = display_Res_Turns.transform.GetChild(2).GetComponent<Text>();
        display_Text_Res_Tasks = display_Res_Tasks.transform.GetChild(2).GetComponent<Text>();
        display_Text_Res_People = display_Res_People.transform.GetChild(2).GetComponent<Text>();
        display_Text_Res_Capacity = display_Res_People.transform.GetChild(3).GetComponent<Text>();
        display_Text_Res_Science = display_Res_Science.transform.GetChild(2).GetComponent<Text>();
        display_Text_Res_Seeds = display_Res_Seeds.transform.GetChild(2).GetComponent<Text>();

        display_Text_Res_Food = display_Res_Food.transform.GetChild(2).GetComponent<Text>();
        display_Text_Res_Metal = display_Res_Metal.transform.GetChild(2).GetComponent<Text>();
        display_Text_Res_Wood = display_Res_Wood.transform.GetChild(2).GetComponent<Text>();
        display_Text_Res_Tech = display_Res_Tech.transform.GetChild(2).GetComponent<Text>();
        // shadows 
        display_Text_Res_Turns_Shadow = display_Res_Turns.transform.GetChild(2).GetChild(0).GetComponent<Text>();
        display_Text_Res_Tasks_Shadow = display_Res_Tasks.transform.GetChild(2).GetChild(0).GetComponent<Text>();
        display_Text_Res_People_Shadow = display_Res_People.transform.GetChild(2).GetChild(0).GetComponent<Text>();
        display_Text_Res_Capacity_Shadow = display_Res_People.transform.GetChild(3).GetChild(0).GetComponent<Text>();
        display_Text_Res_Science_Shadow = display_Res_Science.transform.GetChild(2).GetChild(0).GetComponent<Text>();
        display_Text_Res_Seeds_Shadow = display_Res_Seeds.transform.GetChild(2).GetChild(0).GetComponent<Text>();

        display_Text_Res_Food_Shadow = display_Res_Food.transform.GetChild(2).GetChild(0).GetComponent<Text>();
        display_Text_Res_Metal_Shadow = display_Res_Metal.transform.GetChild(2).GetChild(0).GetComponent<Text>();
        display_Text_Res_Wood_Shadow = display_Res_Wood.transform.GetChild(2).GetChild(0).GetComponent<Text>();
        display_Text_Res_Tech_Shadow = display_Res_Tech.transform.GetChild(2).GetChild(0).GetComponent<Text>();
    }
    private void LinkButtons()
    {
        res_Metal_Button = res_Metal.GetComponent<Button>();
        res_Wood_Button = res_Wood.GetComponent<Button>();
        res_Food_Button = res_Food.GetComponent<Button>();
        res_Tech_Button = res_Tech.GetComponent<Button>();
        hatch_Button = hatch.transform.GetChild(2).GetComponent<Button>();
        wall_Left_Button = wall_Left.transform.GetChild(1).GetComponent<Button>();
        wall_Right_Button = wall_Right.transform.GetChild(1).GetComponent<Button>();
        //stairs_1_Button = stairs_1.transform.GetChild(0).GetComponent<Button>();
        stairs_2_Button = stairs_2.transform.GetChild(1).GetComponent<Button>();
        stairs_3_Button = stairs_3.transform.GetChild(1).GetComponent<Button>();
        underGarden_Lvl1_L1_Button = underGarden_Lvl1_L1.transform.GetChild(1).GetComponent<Button>();
        radio_Lvl1_L2_Button = radio_Lvl1_L2.transform.GetChild(1).GetComponent<Button>();
        expedition_Lvl1_R1_Button = expedition_Lvl1_R1.transform.GetChild(1).GetComponent<Button>();
        training_Lvl1_R2_Button = training_Lvl1_R2.transform.GetChild(1).GetComponent<Button>();
        workshop_Lvl2_L1_Button = workshop_Lvl2_L1.transform.GetChild(1).GetComponent<Button>();
        workshop_Lvl2_L2_Button = workshop_Lvl2_L2.transform.GetChild(1).GetComponent<Button>();
        generator_Lvl2_R1_Button = generator_Lvl2_R1.transform.GetChild(1).GetComponent<Button>();
        generator_Lvl2_R2_Button = generator_Lvl2_R2.transform.GetChild(1).GetComponent<Button>();
        research_Lvl3_L1_Button = research_Lvl3_L1.transform.GetChild(1).GetComponent<Button>();
        research_Lvl3_L2_Button = research_Lvl3_L2.transform.GetChild(1).GetComponent<Button>();
        livingSpace_Lvl3_R1_Button = livingSpace_Lvl3_R1.transform.GetChild(1).GetComponent<Button>();
        livingSpace_Lvl3_R2_Button = livingSpace_Lvl3_R2.transform.GetChild(1).GetComponent<Button>();
        bedroom_lvl1_L_Button = bedroom_Lvl1_L.transform.GetChild(1).GetComponent<Button>();
        bedroom_Lvl1_R_Button = bedroom_Lvl1_R.transform.GetChild(1).GetComponent<Button>();
        bedroom_Lvl2_L_Button = bedroom_Lvl2_L.transform.GetChild(1).GetComponent<Button>();
        bedroom_Lvl2_R_Button = bedroom_Lvl2_R.transform.GetChild(1).GetComponent<Button>();
        bedroom_Lvl3_L_Button = bedroom_Lvl3_L.transform.GetChild(1).GetComponent<Button>();
        bedroom_Lvl3_R_Button = bedroom_Lvl3_R.transform.GetChild(1).GetComponent<Button>();
    }
    private void LinkArtGameObjects()
    {
        #region Bedrooms + Upgrades
        bedroom_Lvl1_L_Rock = bedroom_Lvl1_L.transform.GetChild(2).gameObject;
        bedroom_Lvl1_L_Up_1 = bedroom_Lvl1_L.transform.GetChild(3).gameObject;
        bedroom_Lvl1_L_Up_2 = bedroom_Lvl1_L.transform.GetChild(4).gameObject;
        bedroom_Lvl1_L_Up_3 = bedroom_Lvl1_L.transform.GetChild(5).gameObject;
        bedroom_Lvl1_L_Up_4 = bedroom_Lvl1_L.transform.GetChild(6).gameObject;
        bedroom_Lvl1_L_Up_5 = bedroom_Lvl1_L.transform.GetChild(7).gameObject;
        bedroom_Lvl1_L_Up_6 = bedroom_Lvl1_L.transform.GetChild(8).gameObject;
        bedroom_Lvl1_L_Up_7 = bedroom_Lvl1_L.transform.GetChild(9).gameObject;
        bedroom_Lvl1_L_Up_8 = bedroom_Lvl1_L.transform.GetChild(10).gameObject;
        bedroom_Lvl1_L_Up_9 = bedroom_Lvl1_L.transform.GetChild(11).gameObject;
        bedroom_Lvl1_L_Up_10 = bedroom_Lvl1_L.transform.GetChild(12).gameObject;

        bedroom_Lvl2_L_Rock = bedroom_Lvl2_L.transform.GetChild(2).gameObject;
        bedroom_Lvl2_L_Up_1 = bedroom_Lvl2_L.transform.GetChild(3).gameObject;
        bedroom_Lvl2_L_Up_2 = bedroom_Lvl2_L.transform.GetChild(4).gameObject;
        bedroom_Lvl2_L_Up_3 = bedroom_Lvl2_L.transform.GetChild(5).gameObject;
        bedroom_Lvl2_L_Up_4 = bedroom_Lvl2_L.transform.GetChild(6).gameObject;
        bedroom_Lvl2_L_Up_5 = bedroom_Lvl2_L.transform.GetChild(7).gameObject;
        bedroom_Lvl2_L_Up_6 = bedroom_Lvl2_L.transform.GetChild(8).gameObject;
        bedroom_Lvl2_L_Up_7 = bedroom_Lvl2_L.transform.GetChild(9).gameObject;
        bedroom_Lvl2_L_Up_8 = bedroom_Lvl2_L.transform.GetChild(10).gameObject;
        bedroom_Lvl2_L_Up_9 = bedroom_Lvl2_L.transform.GetChild(11).gameObject;
        bedroom_Lvl2_L_Up_10 = bedroom_Lvl2_L.transform.GetChild(12).gameObject;

        bedroom_Lvl3_L_Rock = bedroom_Lvl3_L.transform.GetChild(2).gameObject;
        bedroom_Lvl3_L_Up_1 = bedroom_Lvl3_L.transform.GetChild(3).gameObject;
        bedroom_Lvl3_L_Up_2 = bedroom_Lvl3_L.transform.GetChild(4).gameObject;
        bedroom_Lvl3_L_Up_3 = bedroom_Lvl3_L.transform.GetChild(5).gameObject;
        bedroom_Lvl3_L_Up_4 = bedroom_Lvl3_L.transform.GetChild(6).gameObject;
        bedroom_Lvl3_L_Up_5 = bedroom_Lvl3_L.transform.GetChild(7).gameObject;
        bedroom_Lvl3_L_Up_6 = bedroom_Lvl3_L.transform.GetChild(8).gameObject;
        bedroom_Lvl3_L_Up_7 = bedroom_Lvl3_L.transform.GetChild(9).gameObject;
        bedroom_Lvl3_L_Up_8 = bedroom_Lvl3_L.transform.GetChild(10).gameObject;
        bedroom_Lvl3_L_Up_9 = bedroom_Lvl3_L.transform.GetChild(11).gameObject;
        bedroom_Lvl3_L_Up_10 = bedroom_Lvl3_L.transform.GetChild(12).gameObject;

        bedroom_Lvl1_R_Rock = bedroom_Lvl1_R.transform.GetChild(2).gameObject;
        bedroom_Lvl1_R_Up_1 = bedroom_Lvl1_R.transform.GetChild(3).gameObject;
        bedroom_Lvl1_R_Up_2 = bedroom_Lvl1_R.transform.GetChild(4).gameObject;
        bedroom_Lvl1_R_Up_3 = bedroom_Lvl1_R.transform.GetChild(5).gameObject;
        bedroom_Lvl1_R_Up_4 = bedroom_Lvl1_R.transform.GetChild(6).gameObject;
        bedroom_Lvl1_R_Up_5 = bedroom_Lvl1_R.transform.GetChild(7).gameObject;
        bedroom_Lvl1_R_Up_6 = bedroom_Lvl1_R.transform.GetChild(8).gameObject;
        bedroom_Lvl1_R_Up_7 = bedroom_Lvl1_R.transform.GetChild(9).gameObject;
        bedroom_Lvl1_R_Up_8 = bedroom_Lvl1_R.transform.GetChild(10).gameObject;
        bedroom_Lvl1_R_Up_9 = bedroom_Lvl1_R.transform.GetChild(11).gameObject;
        bedroom_Lvl1_R_Up_10 = bedroom_Lvl1_R.transform.GetChild(12).gameObject;

        bedroom_Lvl2_R_Rock = bedroom_Lvl2_R.transform.GetChild(2).gameObject;
        bedroom_Lvl2_R_Up_1 = bedroom_Lvl2_R.transform.GetChild(3).gameObject;
        bedroom_Lvl2_R_Up_2 = bedroom_Lvl2_R.transform.GetChild(4).gameObject;
        bedroom_Lvl2_R_Up_3 = bedroom_Lvl2_R.transform.GetChild(5).gameObject;
        bedroom_Lvl2_R_Up_4 = bedroom_Lvl2_R.transform.GetChild(6).gameObject;
        bedroom_Lvl2_R_Up_5 = bedroom_Lvl2_R.transform.GetChild(7).gameObject;
        bedroom_Lvl2_R_Up_6 = bedroom_Lvl2_R.transform.GetChild(8).gameObject;
        bedroom_Lvl2_R_Up_7 = bedroom_Lvl2_R.transform.GetChild(9).gameObject;
        bedroom_Lvl2_R_Up_8 = bedroom_Lvl2_R.transform.GetChild(10).gameObject;
        bedroom_Lvl2_R_Up_9 = bedroom_Lvl2_R.transform.GetChild(11).gameObject;
        bedroom_Lvl2_R_Up_10 = bedroom_Lvl2_R.transform.GetChild(12).gameObject;

        bedroom_Lvl3_R_Rock = bedroom_Lvl3_R.transform.GetChild(2).gameObject;
        bedroom_Lvl3_R_Up_1 = bedroom_Lvl3_R.transform.GetChild(3).gameObject;
        bedroom_Lvl3_R_Up_2 = bedroom_Lvl3_R.transform.GetChild(4).gameObject;
        bedroom_Lvl3_R_Up_3 = bedroom_Lvl3_R.transform.GetChild(5).gameObject;
        bedroom_Lvl3_R_Up_4 = bedroom_Lvl3_R.transform.GetChild(6).gameObject;
        bedroom_Lvl3_R_Up_5 = bedroom_Lvl3_R.transform.GetChild(7).gameObject;
        bedroom_Lvl3_R_Up_6 = bedroom_Lvl3_R.transform.GetChild(8).gameObject;
        bedroom_Lvl3_R_Up_7 = bedroom_Lvl3_R.transform.GetChild(9).gameObject;
        bedroom_Lvl3_R_Up_8 = bedroom_Lvl3_R.transform.GetChild(10).gameObject;
        bedroom_Lvl3_R_Up_9 = bedroom_Lvl3_R.transform.GetChild(11).gameObject;
        bedroom_Lvl3_R_Up_10 = bedroom_Lvl3_R.transform.GetChild(12).gameObject;
        #endregion
        #region Stairs
        stairs_1_Locked = stairs_1.transform.GetChild(0).gameObject;
        stairs_1_Unlocked = stairs_1.transform.GetChild(1).gameObject;
        stairs_2_Locked = stairs_2.transform.GetChild(1).gameObject;
        stairs_2_Unlocked = stairs_2.transform.GetChild(2).gameObject;
        stairs_3_Locked = stairs_3.transform.GetChild(1).gameObject;
        stairs_3_Unlocked = stairs_3.transform.GetChild(2).gameObject;
        #endregion
        #region Walls
        wall_Left_None = wall_Left.transform.GetChild(2).gameObject;
        wall_Left_Up_1 = wall_Left.transform.GetChild(3).gameObject;
        wall_Left_Up_2 = wall_Left.transform.GetChild(4).gameObject;
        wall_Left_Up_3 = wall_Left.transform.GetChild(5).gameObject;
        wall_Left_Up_4 = wall_Left.transform.GetChild(6).gameObject;
        wall_Left_Up_5 = wall_Left.transform.GetChild(7).gameObject;
        wall_Left_Up_6 = wall_Left.transform.GetChild(8).gameObject;
        wall_Left_Up_7 = wall_Left.transform.GetChild(9).gameObject;
        wall_Left_Up_8 = wall_Left.transform.GetChild(10).gameObject;
        wall_Left_Up_9 = wall_Left.transform.GetChild(11).gameObject;
        wall_Left_Up_10 = wall_Left.transform.GetChild(12).gameObject;
        //
        wall_Right_None = wall_Right.transform.GetChild(2).gameObject;
        wall_Right_Up_1 = wall_Right.transform.GetChild(3).gameObject;
        wall_Right_Up_2 = wall_Right.transform.GetChild(4).gameObject;
        wall_Right_Up_3 = wall_Right.transform.GetChild(5).gameObject;
        wall_Right_Up_4 = wall_Right.transform.GetChild(6).gameObject;
        wall_Right_Up_5 = wall_Right.transform.GetChild(7).gameObject;
        wall_Right_Up_6 = wall_Right.transform.GetChild(8).gameObject;
        wall_Right_Up_7 = wall_Right.transform.GetChild(9).gameObject;
        wall_Right_Up_8 = wall_Right.transform.GetChild(10).gameObject;
        wall_Right_Up_9 = wall_Right.transform.GetChild(11).gameObject;
        wall_Right_Up_10 = wall_Right.transform.GetChild(12).gameObject;
        #endregion
        #region UnderGardenRoom + Upgrades
        underGarden_Lvl1_L1_Def = underGarden_Lvl1_L1.transform.GetChild(2).gameObject;
        underGarden_Lvl1_L1_Up_1 = underGarden_Lvl1_L1.transform.GetChild(3).gameObject;
        underGarden_Lvl1_L1_Up_2 = underGarden_Lvl1_L1.transform.GetChild(4).gameObject;
        underGarden_Lvl1_L1_Up_3 = underGarden_Lvl1_L1.transform.GetChild(5).gameObject;
        underGarden_Lvl1_L1_Up_4 = underGarden_Lvl1_L1.transform.GetChild(6).gameObject;
        underGarden_Lvl1_L1_Up_5 = underGarden_Lvl1_L1.transform.GetChild(7).gameObject;
        #endregion
        #region RadioRoom + Upgrades
        radio_Lvl1_L2_Def = radio_Lvl1_L2.transform.GetChild(2).gameObject;
        radio_Lvl1_L2_Up_1 = radio_Lvl1_L2.transform.GetChild(3).gameObject;
        radio_Lvl1_L2_Up_2 = radio_Lvl1_L2.transform.GetChild(4).gameObject;
        radio_Lvl1_L2_Up_3 = radio_Lvl1_L2.transform.GetChild(5).gameObject;
        radio_Lvl1_L2_Up_4 = radio_Lvl1_L2.transform.GetChild(6).gameObject;
        radio_Lvl1_L2_Up_5 = radio_Lvl1_L2.transform.GetChild(7).gameObject;
        #endregion
        #region ExpeditionRoom + Upgrades
        expedition_Lvl1_R1_Def = expedition_Lvl1_R1.transform.GetChild(2).gameObject;
        expedition_Lvl1_R1_Up_1 = expedition_Lvl1_R1.transform.GetChild(3).gameObject;
        expedition_Lvl1_R1_Up_2 = expedition_Lvl1_R1.transform.GetChild(4).gameObject;
        expedition_Lvl1_R1_Up_3 = expedition_Lvl1_R1.transform.GetChild(5).gameObject;
        expedition_Lvl1_R1_Up_4 = expedition_Lvl1_R1.transform.GetChild(6).gameObject;
        expedition_Lvl1_R1_Up_5 = expedition_Lvl1_R1.transform.GetChild(7).gameObject;
        #endregion
        #region TrainingRoom + Upgrades
        training_Lvl1_R2_Def = training_Lvl1_R2.transform.GetChild(2).gameObject;
        training_Lvl1_R2_Up_1 = training_Lvl1_R2.transform.GetChild(3).gameObject;
        training_Lvl1_R2_Up_2 = training_Lvl1_R2.transform.GetChild(4).gameObject;
        training_Lvl1_R2_Up_3 = training_Lvl1_R2.transform.GetChild(5).gameObject;
        training_Lvl1_R2_Up_4 = training_Lvl1_R2.transform.GetChild(6).gameObject;
        training_Lvl1_R2_Up_5 = training_Lvl1_R2.transform.GetChild(7).gameObject;
        #endregion
        #region Workshop1Room + Upgrades
        workshop_Lvl2_L1_Def = workshop_Lvl2_L1.transform.GetChild(2).gameObject;
        workshop_Lvl2_L1_Up_1 = workshop_Lvl2_L1.transform.GetChild(3).gameObject;
        workshop_Lvl2_L1_Up_2 = workshop_Lvl2_L1.transform.GetChild(4).gameObject;
        workshop_Lvl2_L1_Up_3 = workshop_Lvl2_L1.transform.GetChild(5).gameObject;
        workshop_Lvl2_L1_Up_4 = workshop_Lvl2_L1.transform.GetChild(6).gameObject;
        workshop_Lvl2_L1_Up_5 = workshop_Lvl2_L1.transform.GetChild(7).gameObject;
        #endregion
        #region Workshop2Room + Upgrades
        workshop_Lvl2_L2_Def = workshop_Lvl2_L2.transform.GetChild(2).gameObject;
        workshop_Lvl2_L2_Up_1 = workshop_Lvl2_L2.transform.GetChild(3).gameObject;
        workshop_Lvl2_L2_Up_2 = workshop_Lvl2_L2.transform.GetChild(4).gameObject;
        workshop_Lvl2_L2_Up_3 = workshop_Lvl2_L2.transform.GetChild(5).gameObject;
        workshop_Lvl2_L2_Up_4 = workshop_Lvl2_L2.transform.GetChild(6).gameObject;
        workshop_Lvl2_L2_Up_5 = workshop_Lvl2_L2.transform.GetChild(7).gameObject;
        #endregion
        #region Generator1Room + Upgrades
        generator_Lvl2_R1_Def = generator_Lvl2_R1.transform.GetChild(2).gameObject;
        generator_Lvl2_R1_Up_1 = generator_Lvl2_R1.transform.GetChild(3).gameObject;
        generator_Lvl2_R1_Up_2 = generator_Lvl2_R1.transform.GetChild(4).gameObject;
        generator_Lvl2_R1_Up_3 = generator_Lvl2_R1.transform.GetChild(5).gameObject;
        generator_Lvl2_R1_Up_4 = generator_Lvl2_R1.transform.GetChild(6).gameObject;
        generator_Lvl2_R1_Up_5 = generator_Lvl2_R1.transform.GetChild(7).gameObject;
        #endregion
        #region Generator2Room + Upgrades
        generator_Lvl2_R2_Def = generator_Lvl2_R2.transform.GetChild(2).gameObject;
        generator_Lvl2_R2_Up_1 = generator_Lvl2_R2.transform.GetChild(3).gameObject;
        generator_Lvl2_R2_Up_2 = generator_Lvl2_R2.transform.GetChild(4).gameObject;
        generator_Lvl2_R2_Up_3 = generator_Lvl2_R2.transform.GetChild(5).gameObject;
        generator_Lvl2_R2_Up_4 = generator_Lvl2_R2.transform.GetChild(6).gameObject;
        generator_Lvl2_R2_Up_5 = generator_Lvl2_R2.transform.GetChild(7).gameObject;
        #endregion
        #region Research1Room + Upgrades
        research_Lvl3_L1_Def = research_Lvl3_L1.transform.GetChild(2).gameObject;
        research_Lvl3_L1_Up_1 = research_Lvl3_L1.transform.GetChild(3).gameObject;
        research_Lvl3_L1_Up_2 = research_Lvl3_L1.transform.GetChild(4).gameObject;
        research_Lvl3_L1_Up_3 = research_Lvl3_L1.transform.GetChild(5).gameObject;
        research_Lvl3_L1_Up_4 = research_Lvl3_L1.transform.GetChild(6).gameObject;
        research_Lvl3_L1_Up_5 = research_Lvl3_L1.transform.GetChild(7).gameObject;
        #endregion
        #region Research2Room + Upgrades
        research_Lvl3_L2_Def = research_Lvl3_L2.transform.GetChild(2).gameObject;
        research_Lvl3_L2_Up_1 = research_Lvl3_L2.transform.GetChild(3).gameObject;
        research_Lvl3_L2_Up_2 = research_Lvl3_L2.transform.GetChild(4).gameObject;
        research_Lvl3_L2_Up_3 = research_Lvl3_L2.transform.GetChild(5).gameObject;
        research_Lvl3_L2_Up_4 = research_Lvl3_L2.transform.GetChild(6).gameObject;
        research_Lvl3_L2_Up_5 = research_Lvl3_L2.transform.GetChild(7).gameObject;
        #endregion
        #region LivingSpace1Room + Upgrades
        livingSpace_Lvl3_R1_Def = livingSpace_Lvl3_R1.transform.GetChild(2).gameObject;
        livingSpace_Lvl3_R1_Up_1 = livingSpace_Lvl3_R1.transform.GetChild(3).gameObject;
        livingSpace_Lvl3_R1_Up_2 = livingSpace_Lvl3_R1.transform.GetChild(4).gameObject;
        livingSpace_Lvl3_R1_Up_3 = livingSpace_Lvl3_R1.transform.GetChild(5).gameObject;
        livingSpace_Lvl3_R1_Up_4 = livingSpace_Lvl3_R1.transform.GetChild(6).gameObject;
        livingSpace_Lvl3_R1_Up_5 = livingSpace_Lvl3_R1.transform.GetChild(7).gameObject;
        #endregion
        #region LivingSpace2Room + Upgrades
        livingSpace_Lvl3_R2_Def = livingSpace_Lvl3_R2.transform.GetChild(2).gameObject;
        livingSpace_Lvl3_R2_Up_1 = livingSpace_Lvl3_R2.transform.GetChild(3).gameObject;
        livingSpace_Lvl3_R2_Up_2 = livingSpace_Lvl3_R2.transform.GetChild(4).gameObject;
        livingSpace_Lvl3_R2_Up_3 = livingSpace_Lvl3_R2.transform.GetChild(5).gameObject;
        livingSpace_Lvl3_R2_Up_4 = livingSpace_Lvl3_R2.transform.GetChild(6).gameObject;
        livingSpace_Lvl3_R2_Up_5 = livingSpace_Lvl3_R2.transform.GetChild(7).gameObject;
        #endregion
    }
    private void SetAllButtonsDeactive()
    {
        res_Metal_Button.interactable = false;
        res_Wood_Button.interactable = false;
        res_Food_Button.interactable = false;
        res_Tech_Button.interactable = false;
        hatch_Button.interactable = false;
        wall_Left_Button.interactable = false;
        wall_Right_Button.interactable = false;
        stairs_1_Button.interactable = false;
        stairs_2_Button.interactable = false;
        stairs_3_Button.interactable = false;
        underGarden_Lvl1_L1_Button.interactable = false;
        radio_Lvl1_L2_Button.interactable = false;
        expedition_Lvl1_R1_Button.interactable = false;
        training_Lvl1_R2_Button.interactable = false;
        workshop_Lvl2_L1_Button.interactable = false;
        workshop_Lvl2_L2_Button.interactable = false;
        generator_Lvl2_R1_Button.interactable = false;
        generator_Lvl2_R2_Button.interactable = false;
        research_Lvl3_L1_Button.interactable = false;
        research_Lvl3_L2_Button.interactable = false;
        livingSpace_Lvl3_R1_Button.interactable = false;
        livingSpace_Lvl3_R2_Button.interactable = false;
        bedroom_lvl1_L_Button.interactable = false;
        bedroom_Lvl1_R_Button.interactable = false;
        bedroom_Lvl2_L_Button.interactable = false;
        bedroom_Lvl2_R_Button.interactable = false;
        bedroom_Lvl3_L_Button.interactable = false;
        bedroom_Lvl3_R_Button.interactable = false;
    }
    private void SetAllButtonsActive()
    {
        res_Metal_Button.interactable = false;
        res_Wood_Button.interactable = false;
        res_Food_Button.interactable = false;
        res_Tech_Button.interactable = false;
        hatch_Button.interactable = false;
        wall_Left_Button.interactable = false;
        wall_Right_Button.interactable = false;
        stairs_1_Button.interactable = false;
        stairs_2_Button.interactable = false;
        stairs_3_Button.interactable = false;
        underGarden_Lvl1_L1_Button.interactable = false;
        radio_Lvl1_L2_Button.interactable = false;
        expedition_Lvl1_R1_Button.interactable = false;
        training_Lvl1_R2_Button.interactable = false;
        workshop_Lvl2_L1_Button.interactable = false;
        workshop_Lvl2_L2_Button.interactable = false;
        generator_Lvl2_R1_Button.interactable = false;
        generator_Lvl2_R2_Button.interactable = false;
        research_Lvl3_L1_Button.interactable = false;
        research_Lvl3_L2_Button.interactable = false;
        livingSpace_Lvl3_R1_Button.interactable = false;
        livingSpace_Lvl3_R2_Button.interactable = false;
        bedroom_lvl1_L_Button.interactable = false;
        bedroom_Lvl1_R_Button.interactable = false;
        bedroom_Lvl2_L_Button.interactable = false;
        bedroom_Lvl2_R_Button.interactable = false;
        bedroom_Lvl3_L_Button.interactable = false;
        bedroom_Lvl3_R_Button.interactable = false;
    }
    private void SetDefaultBuildingsViewsAndSetThemInCode()
    {
        #region Upgrade GameObjects
        #region Bedrooms
        #region Bedroom Level 1 Left
        GC.Bedroom_Lvl1_L = false;
        GC.Bedroom_Upg_Lvl1_L = 0;
        GC.Bedroom_Lvl1_L_Clik_Unlock = 0;
        bedroom_Lvl1_L_Rock.SetActive(true);
        bedroom_Lvl1_L_Up_1.SetActive(false);
        bedroom_Lvl1_L_Up_2.SetActive(false);
        bedroom_Lvl1_L_Up_3.SetActive(false);
        bedroom_Lvl1_L_Up_4.SetActive(false);
        bedroom_Lvl1_L_Up_5.SetActive(false);
        bedroom_Lvl1_L_Up_6.SetActive(false);
        bedroom_Lvl1_L_Up_7.SetActive(false);
        bedroom_Lvl1_L_Up_8.SetActive(false);
        bedroom_Lvl1_L_Up_9.SetActive(false);
        bedroom_Lvl1_L_Up_10.SetActive(false);
        #endregion
        //
        #region Bedroom Level 2 Left
        GC.Bedroom_Lvl2_L = false;
        GC.Bedroom_Upg_Lvl2_L = 0;
        GC.Bedroom_Lvl2_L_Clik_Unlock = 0;
        bedroom_Lvl2_L_Rock.SetActive(true);
        bedroom_Lvl2_L_Up_1.SetActive(false);
        bedroom_Lvl2_L_Up_2.SetActive(false);
        bedroom_Lvl2_L_Up_3.SetActive(false);
        bedroom_Lvl2_L_Up_4.SetActive(false);
        bedroom_Lvl2_L_Up_5.SetActive(false);
        bedroom_Lvl2_L_Up_6.SetActive(false);
        bedroom_Lvl2_L_Up_7.SetActive(false);
        bedroom_Lvl2_L_Up_8.SetActive(false);
        bedroom_Lvl2_L_Up_9.SetActive(false);
        bedroom_Lvl2_L_Up_10.SetActive(false);
        #endregion
        //
        #region Bedroom Level 3 Left
        GC.Bedroom_Lvl3_L = false;
        GC.Bedroom_Upg_Lvl3_L = 0;
        GC.Bedroom_Lvl3_L_Clik_Unlock = 0;
        bedroom_Lvl3_L_Rock.SetActive(true);
        bedroom_Lvl3_L_Up_1.SetActive(false);
        bedroom_Lvl3_L_Up_2.SetActive(false);
        bedroom_Lvl3_L_Up_3.SetActive(false);
        bedroom_Lvl3_L_Up_4.SetActive(false);
        bedroom_Lvl3_L_Up_5.SetActive(false);
        bedroom_Lvl3_L_Up_6.SetActive(false);
        bedroom_Lvl3_L_Up_7.SetActive(false);
        bedroom_Lvl3_L_Up_8.SetActive(false);
        bedroom_Lvl3_L_Up_9.SetActive(false);
        bedroom_Lvl3_L_Up_10.SetActive(false);
        #endregion
        //
        #region Bedroom Level 1 Right
        GC.Bedroom_Lvl1_R = false;
        GC.Bedroom_Upg_Lvl1_R = 0;
        GC.Bedroom_Lvl1_R_Clik_Unlock = 0;
        bedroom_Lvl1_R_Rock.SetActive(true);
        bedroom_Lvl1_R_Up_1.SetActive(false);
        bedroom_Lvl1_R_Up_2.SetActive(false);
        bedroom_Lvl1_R_Up_3.SetActive(false);
        bedroom_Lvl1_R_Up_4.SetActive(false);
        bedroom_Lvl1_R_Up_5.SetActive(false);
        bedroom_Lvl1_R_Up_6.SetActive(false);
        bedroom_Lvl1_R_Up_7.SetActive(false);
        bedroom_Lvl1_R_Up_8.SetActive(false);
        bedroom_Lvl1_R_Up_9.SetActive(false);
        bedroom_Lvl1_R_Up_10.SetActive(false);
        #endregion
        //
        #region Bedroom Level 2 Right
        GC.Bedroom_Lvl2_R = false;
        GC.Bedroom_Upg_Lvl2_R = 0;
        GC.Bedroom_Lvl2_R_Clik_Unlock = 0;
        bedroom_Lvl2_R_Rock.SetActive(true);
        bedroom_Lvl2_R_Up_1.SetActive(false);
        bedroom_Lvl2_R_Up_2.SetActive(false);
        bedroom_Lvl2_R_Up_3.SetActive(false);
        bedroom_Lvl2_R_Up_4.SetActive(false);
        bedroom_Lvl2_R_Up_5.SetActive(false);
        bedroom_Lvl2_R_Up_6.SetActive(false);
        bedroom_Lvl2_R_Up_7.SetActive(false);
        bedroom_Lvl2_R_Up_8.SetActive(false);
        bedroom_Lvl2_R_Up_9.SetActive(false);
        bedroom_Lvl2_R_Up_10.SetActive(false);
        #endregion
        //
        #region Bedroom Level 3 Right
        GC.Bedroom_Lvl3_R = false;
        GC.Bedroom_Upg_Lvl3_R = 0;
        GC.Bedroom_Lvl3_R_Clik_Unlock = 0;
        bedroom_Lvl3_R_Rock.SetActive(true);
        bedroom_Lvl3_R_Up_1.SetActive(false);
        bedroom_Lvl3_R_Up_2.SetActive(false);
        bedroom_Lvl3_R_Up_3.SetActive(false);
        bedroom_Lvl3_R_Up_4.SetActive(false);
        bedroom_Lvl3_R_Up_5.SetActive(false);
        bedroom_Lvl3_R_Up_6.SetActive(false);
        bedroom_Lvl3_R_Up_7.SetActive(false);
        bedroom_Lvl3_R_Up_8.SetActive(false);
        bedroom_Lvl3_R_Up_9.SetActive(false);
        bedroom_Lvl3_R_Up_10.SetActive(false);
        #endregion
        #endregion
        #region Stairs
        //
        #region Stairs 1
        GC.Stairs_1 = true;
        stairs_1_Locked.SetActive(false);
        stairs_1_Unlocked.SetActive(true);
        #endregion
        //
        #region Stairs 2
        GC.Stairs_2 = false;
        GC.Stairs_2_Clicks_Unlock = 0;
        stairs_2_Locked.SetActive(true);
        stairs_2_Unlocked.SetActive(false);
        #endregion
        //
        #region Stairs 3
        GC.Stairs_3 = false;
        GC.Stairs_3_Clicks_Unlock = 0;
        stairs_3_Locked.SetActive(true);
        stairs_3_Unlocked.SetActive(false);
        #endregion
        #endregion
        #region Walls
        //
        #region Walls Left
        GC.Wall_L = false;
        GC.Wall_L_Upg = 0;
        GC.Wall_L_Clik_Unlock = 0;
        GC.Wall_L_Health = 0;
        wall_Left_None.SetActive(true);
        wall_Left_Up_1.SetActive(false);
        wall_Left_Up_2.SetActive(false);
        wall_Left_Up_3.SetActive(false);
        wall_Left_Up_4.SetActive(false);
        wall_Left_Up_5.SetActive(false);
        wall_Left_Up_6.SetActive(false);
        wall_Left_Up_7.SetActive(false);
        wall_Left_Up_8.SetActive(false);
        wall_Left_Up_9.SetActive(false);
        wall_Left_Up_10.SetActive(false);
        #endregion
        //
        #region Walls Left
        GC.Wall_R = false;
        GC.Wall_R_Upg = 0;
        GC.Wall_R_Clik_Unlock = 0;
        GC.Wall_R_Health = 0;
        wall_Right_None.SetActive(true);
        wall_Right_Up_1.SetActive(false);
        wall_Right_Up_2.SetActive(false);
        wall_Right_Up_3.SetActive(false);
        wall_Right_Up_4.SetActive(false);
        wall_Right_Up_5.SetActive(false);
        wall_Right_Up_6.SetActive(false);
        wall_Right_Up_7.SetActive(false);
        wall_Right_Up_8.SetActive(false);
        wall_Right_Up_9.SetActive(false);
        wall_Right_Up_10.SetActive(false);
        #endregion
        #endregion
        #region Main Rooms
        //
        #region UnderGarden
        GC.UnderGarden_Lvl1_L1 = true;
        GC.UnderGarden_Upg_Lvl1_L1 = 1;
        underGarden_Lvl1_L1_Def.SetActive(false);
        underGarden_Lvl1_L1_Up_1.SetActive(true);
        underGarden_Lvl1_L1_Up_2.SetActive(false);
        underGarden_Lvl1_L1_Up_3.SetActive(false);
        underGarden_Lvl1_L1_Up_4.SetActive(false);
        underGarden_Lvl1_L1_Up_5.SetActive(false);
        #endregion
        //
        #region Radio
        GC.Radio_Lvl1_L2 = true;
        GC.Radio_Upg_Lvl1_L2 = 1;
        radio_Lvl1_L2_Def.SetActive(false);
        radio_Lvl1_L2_Up_1.SetActive(true);
        radio_Lvl1_L2_Up_2.SetActive(false);
        radio_Lvl1_L2_Up_3.SetActive(false);
        radio_Lvl1_L2_Up_4.SetActive(false);
        radio_Lvl1_L2_Up_5.SetActive(false);
        #endregion
        //
        #region Expedition
        GC.Expedition_Lvl1_R1 = true;
        GC.Expedition_Upg_Lvl1_R1 = 1;
        expedition_Lvl1_R1_Def.SetActive(false);
        expedition_Lvl1_R1_Up_1.SetActive(true);
        expedition_Lvl1_R1_Up_2.SetActive(false);
        expedition_Lvl1_R1_Up_3.SetActive(false);
        expedition_Lvl1_R1_Up_4.SetActive(false);
        expedition_Lvl1_R1_Up_5.SetActive(false);
        #endregion
        //
        #region Training
        GC.Training_Lvl1_R2 = true;
        GC.Training_Upg_Lvl1_R2 = 1;
        training_Lvl1_R2_Def.SetActive(false);
        training_Lvl1_R2_Up_1.SetActive(true);
        training_Lvl1_R2_Up_2.SetActive(false);
        training_Lvl1_R2_Up_3.SetActive(false);
        training_Lvl1_R2_Up_4.SetActive(false);
        training_Lvl1_R2_Up_5.SetActive(false);
        #endregion
        //
        #region Workshop 1
        GC.Workshop_Lvl2_L1 = false;
        GC.Workshop_Upg_Lvl2_L1 = 0;
        workshop_Lvl2_L1_Def.SetActive(true);
        workshop_Lvl2_L1_Up_1.SetActive(false);
        workshop_Lvl2_L1_Up_2.SetActive(false);
        workshop_Lvl2_L1_Up_3.SetActive(false);
        workshop_Lvl2_L1_Up_4.SetActive(false);
        workshop_Lvl2_L1_Up_5.SetActive(false);
        #endregion
        //
        #region Workshop 2
        GC.Workshop_Lvl2_L2 = false;
        GC.Workshop_Upg_Lvl2_L2 = 0;
        workshop_Lvl2_L2_Def.SetActive(true);
        workshop_Lvl2_L2_Up_1.SetActive(false);
        workshop_Lvl2_L2_Up_2.SetActive(false);
        workshop_Lvl2_L2_Up_3.SetActive(false);
        workshop_Lvl2_L2_Up_4.SetActive(false);
        workshop_Lvl2_L2_Up_5.SetActive(false);
        #endregion
        //
        #region Generator 1
        GC.Generator_Lvl2_R1 = false;
        GC.Generator_Upg_Lvl2_R1 = 0;
        generator_Lvl2_R1_Def.SetActive(true);
        generator_Lvl2_R1_Up_1.SetActive(false);
        generator_Lvl2_R1_Up_2.SetActive(false);
        generator_Lvl2_R1_Up_3.SetActive(false);
        generator_Lvl2_R1_Up_4.SetActive(false);
        generator_Lvl2_R1_Up_5.SetActive(false);
        #endregion
        //
        #region Generator 2
        GC.Generator_Lvl2_R2 = false;
        GC.Generator_Upg_Lvl2_R2 = 0;
        generator_Lvl2_R2_Def.SetActive(true);
        generator_Lvl2_R2_Up_1.SetActive(false);
        generator_Lvl2_R2_Up_2.SetActive(false);
        generator_Lvl2_R2_Up_3.SetActive(false);
        generator_Lvl2_R2_Up_4.SetActive(false);
        generator_Lvl2_R2_Up_5.SetActive(false);
        #endregion
        //
        #region Research 1
        GC.Research_Lvl3_L1 = false;
        GC.Research_Upg_Lvl3_L1 = 0;
        research_Lvl3_L1_Def.SetActive(true);
        research_Lvl3_L1_Up_1.SetActive(false);
        research_Lvl3_L1_Up_2.SetActive(false);
        research_Lvl3_L1_Up_3.SetActive(false);
        research_Lvl3_L1_Up_4.SetActive(false);
        research_Lvl3_L1_Up_5.SetActive(false);
        #endregion
        //
        #region Research 2
        GC.Research_Lvl3_L2 = false;
        GC.Research_Upg_Lvl3_L2 = 0;
        research_Lvl3_L2_Def.SetActive(true);
        research_Lvl3_L2_Up_1.SetActive(false);
        research_Lvl3_L2_Up_2.SetActive(false);
        research_Lvl3_L2_Up_3.SetActive(false);
        research_Lvl3_L2_Up_4.SetActive(false);
        research_Lvl3_L2_Up_5.SetActive(false);
        #endregion
        //
        #region LivingSpace 1
        GC.LivingSpace_Lvl3_R1 = false;
        GC.LivingSpace_Upg_Lvl3_R1 = 0;
        livingSpace_Lvl3_R1_Def.SetActive(true);
        livingSpace_Lvl3_R1_Up_1.SetActive(false);
        livingSpace_Lvl3_R1_Up_2.SetActive(false);
        livingSpace_Lvl3_R1_Up_3.SetActive(false);
        livingSpace_Lvl3_R1_Up_4.SetActive(false);
        livingSpace_Lvl3_R1_Up_5.SetActive(false);
        #endregion
        //
        #region LivingSpace 2
        GC.LivingSpace_Lvl3_R2 = false;
        GC.LivingSpace_Upg_Lvl3_R2 = 0;
        livingSpace_Lvl3_R2_Def.SetActive(true);
        livingSpace_Lvl3_R2_Up_1.SetActive(false);
        livingSpace_Lvl3_R2_Up_2.SetActive(false);
        livingSpace_Lvl3_R2_Up_3.SetActive(false);
        livingSpace_Lvl3_R2_Up_4.SetActive(false);
        livingSpace_Lvl3_R2_Up_5.SetActive(false);
        #endregion
        #endregion
        #endregion
    }
    private void TurnAllItemsOff()
    {
        #region Upgrade GameObjects
        #region Bedrooms
        bedroom_Lvl1_L_Rock.SetActive(false);
        bedroom_Lvl1_L_Up_1.SetActive(false);
        bedroom_Lvl1_L_Up_2.SetActive(false);
        bedroom_Lvl1_L_Up_3.SetActive(false);
        bedroom_Lvl1_L_Up_4.SetActive(false);
        bedroom_Lvl1_L_Up_5.SetActive(false);
        bedroom_Lvl1_L_Up_6.SetActive(false);
        bedroom_Lvl1_L_Up_7.SetActive(false);
        bedroom_Lvl1_L_Up_8.SetActive(false);
        bedroom_Lvl1_L_Up_9.SetActive(false);
        bedroom_Lvl1_L_Up_10.SetActive(false);
        bedroom_Lvl2_L_Rock.SetActive(false);
        bedroom_Lvl2_L_Up_1.SetActive(false);
        bedroom_Lvl2_L_Up_2.SetActive(false);
        bedroom_Lvl2_L_Up_3.SetActive(false);
        bedroom_Lvl2_L_Up_4.SetActive(false);
        bedroom_Lvl2_L_Up_5.SetActive(false);
        bedroom_Lvl2_L_Up_6.SetActive(false);
        bedroom_Lvl2_L_Up_7.SetActive(false);
        bedroom_Lvl2_L_Up_8.SetActive(false);
        bedroom_Lvl2_L_Up_9.SetActive(false);
        bedroom_Lvl2_L_Up_10.SetActive(false);
        bedroom_Lvl3_L_Rock.SetActive(false);
        bedroom_Lvl3_L_Up_1.SetActive(false);
        bedroom_Lvl3_L_Up_2.SetActive(false);
        bedroom_Lvl3_L_Up_3.SetActive(false);
        bedroom_Lvl3_L_Up_4.SetActive(false);
        bedroom_Lvl3_L_Up_5.SetActive(false);
        bedroom_Lvl3_L_Up_6.SetActive(false);
        bedroom_Lvl3_L_Up_7.SetActive(false);
        bedroom_Lvl3_L_Up_8.SetActive(false);
        bedroom_Lvl3_L_Up_9.SetActive(false);
        bedroom_Lvl3_L_Up_10.SetActive(false);
        bedroom_Lvl1_R_Rock.SetActive(false);
        bedroom_Lvl1_R_Up_1.SetActive(false);
        bedroom_Lvl1_R_Up_2.SetActive(false);
        bedroom_Lvl1_R_Up_3.SetActive(false);
        bedroom_Lvl1_R_Up_4.SetActive(false);
        bedroom_Lvl1_R_Up_5.SetActive(false);
        bedroom_Lvl1_R_Up_6.SetActive(false);
        bedroom_Lvl1_R_Up_7.SetActive(false);
        bedroom_Lvl1_R_Up_8.SetActive(false);
        bedroom_Lvl1_R_Up_9.SetActive(false);
        bedroom_Lvl1_R_Up_10.SetActive(false);
        bedroom_Lvl2_R_Rock.SetActive(false);
        bedroom_Lvl2_R_Up_1.SetActive(false);
        bedroom_Lvl2_R_Up_2.SetActive(false);
        bedroom_Lvl2_R_Up_3.SetActive(false);
        bedroom_Lvl2_R_Up_4.SetActive(false);
        bedroom_Lvl2_R_Up_5.SetActive(false);
        bedroom_Lvl2_R_Up_6.SetActive(false);
        bedroom_Lvl2_R_Up_7.SetActive(false);
        bedroom_Lvl2_R_Up_8.SetActive(false);
        bedroom_Lvl2_R_Up_9.SetActive(false);
        bedroom_Lvl2_R_Up_10.SetActive(false);
        bedroom_Lvl3_R_Rock.SetActive(false);
        bedroom_Lvl3_R_Up_1.SetActive(false);
        bedroom_Lvl3_R_Up_2.SetActive(false);
        bedroom_Lvl3_R_Up_3.SetActive(false);
        bedroom_Lvl3_R_Up_4.SetActive(false);
        bedroom_Lvl3_R_Up_5.SetActive(false);
        bedroom_Lvl3_R_Up_6.SetActive(false);
        bedroom_Lvl3_R_Up_7.SetActive(false);
        bedroom_Lvl3_R_Up_8.SetActive(false);
        bedroom_Lvl3_R_Up_9.SetActive(false);
        bedroom_Lvl3_R_Up_10.SetActive(false);
        #endregion
        #region Stairs
        stairs_1_Locked.SetActive(false);
        stairs_1_Unlocked.SetActive(false);
        stairs_2_Locked.SetActive(false);
        stairs_2_Unlocked.SetActive(false);
        stairs_3_Locked.SetActive(false);
        stairs_3_Unlocked.SetActive(false);
        #endregion
        #region Walls
        wall_Left_None.SetActive(false);
        wall_Left_Up_1.SetActive(false);
        wall_Left_Up_2.SetActive(false);
        wall_Left_Up_3.SetActive(false);
        wall_Left_Up_4.SetActive(false);
        wall_Left_Up_5.SetActive(false);
        wall_Left_Up_6.SetActive(false);
        wall_Left_Up_7.SetActive(false);
        wall_Left_Up_8.SetActive(false);
        wall_Left_Up_9.SetActive(false);
        wall_Left_Up_10.SetActive(false);
        wall_Right_None.SetActive(false);
        wall_Right_Up_1.SetActive(false);
        wall_Right_Up_2.SetActive(false);
        wall_Right_Up_3.SetActive(false);
        wall_Right_Up_4.SetActive(false);
        wall_Right_Up_5.SetActive(false);
        wall_Right_Up_6.SetActive(false);
        wall_Right_Up_7.SetActive(false);
        wall_Right_Up_8.SetActive(false);
        wall_Right_Up_9.SetActive(false);
        wall_Right_Up_10.SetActive(false);
        #endregion
        #region Main Rooms
        underGarden_Lvl1_L1_Def.SetActive(false);
        underGarden_Lvl1_L1_Up_1.SetActive(false);
        underGarden_Lvl1_L1_Up_2.SetActive(false);
        underGarden_Lvl1_L1_Up_3.SetActive(false);
        underGarden_Lvl1_L1_Up_4.SetActive(false);
        underGarden_Lvl1_L1_Up_5.SetActive(false);
        radio_Lvl1_L2_Def.SetActive(false);
        radio_Lvl1_L2_Up_1.SetActive(false);
        radio_Lvl1_L2_Up_2.SetActive(false);
        radio_Lvl1_L2_Up_3.SetActive(false);
        radio_Lvl1_L2_Up_4.SetActive(false);
        radio_Lvl1_L2_Up_5.SetActive(false);
        expedition_Lvl1_R1_Def.SetActive(false);
        expedition_Lvl1_R1_Up_1.SetActive(false);
        expedition_Lvl1_R1_Up_2.SetActive(false);
        expedition_Lvl1_R1_Up_3.SetActive(false);
        expedition_Lvl1_R1_Up_4.SetActive(false);
        expedition_Lvl1_R1_Up_5.SetActive(false);
        training_Lvl1_R2_Def.SetActive(false);
        training_Lvl1_R2_Up_1.SetActive(false);
        training_Lvl1_R2_Up_2.SetActive(false);
        training_Lvl1_R2_Up_3.SetActive(false);
        training_Lvl1_R2_Up_4.SetActive(false);
        training_Lvl1_R2_Up_5.SetActive(false);
        workshop_Lvl2_L1_Def.SetActive(false);
        workshop_Lvl2_L1_Up_1.SetActive(false);
        workshop_Lvl2_L1_Up_2.SetActive(false);
        workshop_Lvl2_L1_Up_3.SetActive(false);
        workshop_Lvl2_L1_Up_4.SetActive(false);
        workshop_Lvl2_L1_Up_5.SetActive(false);
        workshop_Lvl2_L2_Def.SetActive(false);
        workshop_Lvl2_L2_Up_1.SetActive(false);
        workshop_Lvl2_L2_Up_2.SetActive(false);
        workshop_Lvl2_L2_Up_3.SetActive(false);
        workshop_Lvl2_L2_Up_4.SetActive(false);
        workshop_Lvl2_L2_Up_5.SetActive(false);
        generator_Lvl2_R1_Def.SetActive(false);
        generator_Lvl2_R1_Up_1.SetActive(false);
        generator_Lvl2_R1_Up_2.SetActive(false);
        generator_Lvl2_R1_Up_3.SetActive(false);
        generator_Lvl2_R1_Up_4.SetActive(false);
        generator_Lvl2_R1_Up_5.SetActive(false);
        generator_Lvl2_R2_Def.SetActive(false);
        generator_Lvl2_R2_Up_1.SetActive(false);
        generator_Lvl2_R2_Up_2.SetActive(false);
        generator_Lvl2_R2_Up_3.SetActive(false);
        generator_Lvl2_R2_Up_4.SetActive(false);
        generator_Lvl2_R2_Up_5.SetActive(false);
        research_Lvl3_L1_Def.SetActive(false);
        research_Lvl3_L1_Up_1.SetActive(false);
        research_Lvl3_L1_Up_2.SetActive(false);
        research_Lvl3_L1_Up_3.SetActive(false);
        research_Lvl3_L1_Up_4.SetActive(false);
        research_Lvl3_L1_Up_5.SetActive(false);
        research_Lvl3_L2_Def.SetActive(false);
        research_Lvl3_L2_Up_1.SetActive(false);
        research_Lvl3_L2_Up_2.SetActive(false);
        research_Lvl3_L2_Up_3.SetActive(false);
        research_Lvl3_L2_Up_4.SetActive(false);
        research_Lvl3_L2_Up_5.SetActive(false);
        livingSpace_Lvl3_R1_Def.SetActive(false);
        livingSpace_Lvl3_R1_Up_1.SetActive(false);
        livingSpace_Lvl3_R1_Up_2.SetActive(false);
        livingSpace_Lvl3_R1_Up_3.SetActive(false);
        livingSpace_Lvl3_R1_Up_4.SetActive(false);
        livingSpace_Lvl3_R1_Up_5.SetActive(false);
        livingSpace_Lvl3_R2_Def.SetActive(false);
        livingSpace_Lvl3_R2_Up_1.SetActive(false);
        livingSpace_Lvl3_R2_Up_2.SetActive(false);
        livingSpace_Lvl3_R2_Up_3.SetActive(false);
        livingSpace_Lvl3_R2_Up_4.SetActive(false);
        livingSpace_Lvl3_R2_Up_5.SetActive(false);
        #endregion
        #endregion
    }
    // Calculations for the wait time after pressing a gathering resource
    #region Gathering resources
    public void Gather_Metal()
    {
        GC.Player_Metal += 10;
        Calculate_Wait_Metal();
    }
    public void Gather_Wood()
    {
        GC.Player_Wood += 10;
        Calculate_Wait_Wood();
    }
    public void Gather_Food()
    {
        GC.Player_Food += 10;
        Calculate_Wait_Food();
    }
    public void Gather_Tech()
    {
        GC.Player_Tech += 10;
        Calculate_Wait_Tech();
    }
    private void Get_Layer_1_Building_Bonus(int building)
    {
        if (building == 1)// Generator
        {
            tempMetal = 0;
            switch (GC.Generator_Upg_Lvl2_R1)
            {
                case 0: tempMetal = 1.0f; break;
                case 1: tempMetal = 1.2f; break;
                case 2: tempMetal = 1.4f; break;
                case 3: tempMetal = 1.6f; break;
                case 4: tempMetal = 1.8f; break;
                case 5: tempMetal = 2.0f; break;
            }
        }
        else if (building == 2) // Workshop
        {
            tempWood = 0;
            switch (GC.Workshop_Upg_Lvl2_L1)
            {
                case 0: tempWood = 1.0f; break;
                case 1: tempWood = 1.2f; break;
                case 2: tempWood = 1.4f; break;
                case 3: tempWood = 1.6f; break;
                case 4: tempWood = 1.8f; break;
                case 5: tempWood = 2.0f; break;
            }

        }
        else if (building == 3) // LivingSpace
        {
            tempFood = 0;
            switch (GC.LivingSpace_Upg_Lvl3_R1)
            {
                case 0: tempFood = 1.0f; break;
                case 1: tempFood = 1.2f; break;
                case 2: tempFood = 1.4f; break;
                case 3: tempFood = 1.6f; break;
                case 4: tempFood = 1.8f; break;
                case 5: tempFood = 2.0f; break;
            }

        }
        else if (building == 4) // Research
        {
            tempTech = 0;
            switch (GC.Research_Upg_Lvl3_L1)
            {
                case 0: tempTech = 1.0f; break;
                case 1: tempTech = 1.2f; break;
                case 2: tempTech = 1.4f; break;
                case 3: tempTech = 1.6f; break;
                case 4: tempTech = 1.8f; break;
                case 5: tempTech = 2.0f; break;
            }
        }
    }
    private void Get_Layer_2_Building_Bonus(int building)
    {
        if (building == 1)// Generator
        {
            switch (GC.Generator_Upg_Lvl2_R2)
            {
                case 0: tempMetal = 1.0f; break;
                case 1: tempMetal = 1.2f; break;
                case 2: tempMetal = 1.4f; break;
                case 3: tempMetal = 1.6f; break;
                case 4: tempMetal = 1.8f; break;
                case 5: tempMetal = 2.0f; break;
            }
        }
        else if (building == 2) // Workshop
        {
            switch (GC.Workshop_Upg_Lvl2_L2)
            {
                case 0: tempWood = 1.0f; break;
                case 1: tempWood = 1.2f; break;
                case 2: tempWood = 1.4f; break;
                case 3: tempWood = 1.6f; break;
                case 4: tempWood = 1.8f; break;
                case 5: tempWood = 2.0f; break;
            }

        }
        else if (building == 3) // LivingSpace
        {
            switch (GC.LivingSpace_Upg_Lvl3_R2)
            {
                case 0: tempFood = 1.0f; break;
                case 1: tempFood = 1.2f; break;
                case 2: tempFood = 1.4f; break;
                case 3: tempFood = 1.6f; break;
                case 4: tempFood = 1.8f; break;
                case 5: tempFood = 2.0f; break;
            }

        }
        else if (building == 4) // Research
        {
            switch (GC.Research_Upg_Lvl3_L2)
            {
                case 0: tempTech = 1.0f; break;
                case 1: tempTech = 1.2f; break;
                case 2: tempTech = 1.4f; break;
                case 3: tempTech = 1.6f; break;
                case 4: tempTech = 1.8f; break;
                case 5: tempTech = 2.0f; break;
            }
        }
    } 
    private void Calculate_Wait_Metal()
    {
        float i = wait_Button_Defaults;
        Get_Layer_1_Building_Bonus(1);
        i += tempMetal;
        Debug.Log(i);
        Get_Layer_2_Building_Bonus(1);
        i += tempMetal;
        Debug.Log(i);
        wait_Button_Metal = (wait_Button_Metal -= i);
        Debug.Log(wait_Button_Metal);
        Lock_Metal_Button();
    }
    private void Calculate_Wait_Wood()
    {
        float i = wait_Button_Defaults;
        Get_Layer_1_Building_Bonus(2);
        i += tempWood;
        Debug.Log(i);
        Get_Layer_2_Building_Bonus(2);
        i += tempWood;
        Debug.Log(i);
        wait_Button_Wood = (wait_Button_Wood -= i);
        Debug.Log(wait_Button_Wood);
        Lock_Wood_Button();
    }
    private void Calculate_Wait_Food()
    {
        float i = wait_Button_Defaults;
        Get_Layer_1_Building_Bonus(3);
        i += tempFood;
        Debug.Log(i);
        Get_Layer_2_Building_Bonus(3);
        i += tempFood;
        Debug.Log(i);
        wait_Button_Food = (wait_Button_Food -= i);
        Debug.Log(wait_Button_Food);
        Lock_Food_Button();
    }
    private void Calculate_Wait_Tech()
    {
        float i = wait_Button_Defaults;
        Get_Layer_1_Building_Bonus(4);
        i += tempTech;
        Debug.Log(i);
        Get_Layer_2_Building_Bonus(4);
        i += tempTech;
        Debug.Log(i);
        wait_Button_Tech = (wait_Button_Tech -= i);
        Debug.Log(wait_Button_Tech);
        Lock_Tech_Button();
    }

    private void Unlock_Metal_Button()
    {
        wait_Metal = false;
        Debug.Log("unlock metal button");
        res_Metal_Button.enabled = true;
    }
    private void Lock_Metal_Button()
    {
        wait_Metal = true;
        Debug.Log("lock metal button");
        res_Metal_Button.enabled = false;
    }
    private void Unlock_Wood_Button()
    {
        wait_Wood = false;
        Debug.Log("unlock wood button");
        res_Wood_Button.enabled = true;
    }
    private void Lock_Wood_Button()
    {
        wait_Wood = true;
        Debug.Log("lock wood button");
        res_Wood_Button.enabled = false;
    }
    private void Unlock_Food_Button()
    {
        wait_Food = false;
        Debug.Log("unlock food button");
        res_Food_Button.enabled = true;
    }
    private void Lock_Food_Button()
    {
        wait_Food = true;
        Debug.Log("lock food button");
        res_Food_Button.enabled = false;
    }
    private void Unlock_Tech_Button()
    {
        wait_Tech = false;
        Debug.Log("unlock tech button");
        res_Tech_Button.enabled = true;
    }
    private void Lock_Tech_Button()
    {
        wait_Tech = true;
        Debug.Log("lock tech button");
        res_Tech_Button.enabled = false;
    }
    
    #endregion
    private void LivingSpacesBonus() { }
    private void ResearchBonus() { }
    private void WorkshopBonus() { }
    private void PowerGeneratorBonus() { }
    
    private void CheckRoomUnlockProgress()
    {
        Check_Upgrade_Bedroom_Lvl1_L();
        Check_Upgrade_Bedroom_Lvl2_L();
        Check_Upgrade_Bedroom_Lvl3_L();
        Check_Upgrade_Bedroom_Lvl1_R();
        Check_Upgrade_Bedroom_Lvl2_R();
        Check_Upgrade_Bedroom_Lvl3_R();
        //
        Check_Upgrade_Stairs_2();
        Check_Upgrade_Stairs_3();
        //
        Check_Upgrade_Expedition_Building();
        Check_Upgrade_Training_Building();
        Check_Upgrade_Radio_Building();
        Check_Upgrade_UnderGarden_Building();
        //
        Check_Upgrade_Generator_Building_1();
        Check_Upgrade_Generator_Building_2();
        Check_Upgrade_Workshop_Building_1();
        Check_Upgrade_Workshop_Building_2();
        Check_Upgrade_LivingSpace_Building_1();
        Check_Upgrade_LivingSpace_Building_2();
        Check_Upgrade_Research_Building_1();
        Check_Upgrade_Reserach_Building_2();
        // 
        Check_Save_Wall_L();
        Check_Save_Wall_R();
    }
    #region Need To add visual Unlock images to the check button items
    private void CheckBedroomUnlockProgress()// Need to add visual presentation of unlocks
    {// this checks if these buildings are unlocked via click amounts and on lvl2 & 3 also checks if previous building is unlocked
        if (!GC.Bedroom_Lvl1_L)
        { if (GC.Bedroom_Lvl1_L_Clik_Unlock >= 50) { GC.Bedroom_Lvl1_L = true; bedroom_Lvl1_L_Rock.SetActive(false); bedroom_Lvl1_L_Up_1.SetActive(true); } }
        if (!GC.Bedroom_Lvl1_R)
        { if (GC.Bedroom_Lvl1_R_Clik_Unlock >= 50) { GC.Bedroom_Lvl1_R = true; bedroom_Lvl1_R_Rock.SetActive(false); bedroom_Lvl1_R_Up_1.SetActive(false); } }
        if (!GC.Bedroom_Lvl2_L)
        { if (GC.Bedroom_Lvl2_L_Clik_Unlock >= 250 && GC.Workshop_Lvl2_L2) { GC.Bedroom_Lvl2_L = true; bedroom_Lvl2_L_Rock.SetActive(false); bedroom_Lvl2_L_Up_1.SetActive(false); } }
        if (!GC.Bedroom_Lvl2_R)
        { if (GC.Bedroom_Lvl2_R_Clik_Unlock >= 250 && GC.Generator_Lvl2_R2) { GC.Bedroom_Lvl2_R = true; bedroom_Lvl2_R_Rock.SetActive(false); bedroom_Lvl2_R_Up_1.SetActive(false); } }
        if (!GC.Bedroom_Lvl3_L)
        { if (GC.Bedroom_Lvl3_L_Clik_Unlock >= 1000 && GC.Research_Lvl3_L2) { GC.Bedroom_Lvl3_L = true; bedroom_Lvl3_L_Rock.SetActive(false); bedroom_Lvl3_L_Up_1.SetActive(false); } }
        if (!GC.Bedroom_Lvl3_R)
        { if (GC.Bedroom_Lvl3_R_Clik_Unlock >= 1000 && GC.LivingSpace_Lvl3_R2) { GC.Bedroom_Lvl3_R = true; bedroom_Lvl3_R_Rock.SetActive(false); bedroom_Lvl3_R_Up_1.SetActive(false); } }
    }
    private void CheckStairsUnlockProgress()// no visual unlock needs adding
    {
        if (!GC.Stairs_2)
        { if (GC.Stairs_2_Clicks_Unlock >= 25) { GC.Stairs_2 = true; } }
        if (!GC.Stairs_3)
        { if (GC.Stairs_3_Clicks_Unlock >= 125 && GC.Stairs_2) { GC.Stairs_3 = true; } }
    }
    private void CheckGeneratorUnlockProgress()// no visual unlock needs adding
    {
        if (!GC.Generator_Lvl2_R1)
        {
            if (GC.Stairs_2 && GC.Player_Metal >= 50 && GC.Player_Wood >= 50 && GC.Player_Tech >= 50) { GC.Player_Metal -= 50; GC.Player_Wood -= 50;GC.Player_Tech -= 50; GC.Generator_Lvl2_R1 = true; generator_Lvl2_R1_Def.SetActive(false); generator_Lvl2_R1_Up_1.SetActive(false); }
        }
        if (!GC.Generator_Lvl2_R2)
        {
            if (GC.Generator_Lvl2_R1 && GC.Player_Metal >= 250 && GC.Player_Wood >= 250 && GC.Player_Tech >= 250) { GC.Player_Metal -= 250; GC.Player_Wood -= 250; GC.Player_Tech -= 250; GC.Generator_Lvl2_R2 = true; generator_Lvl2_R2_Def.SetActive(false); generator_Lvl2_R2_Up_1.SetActive(false); }
        }
    }
    private void BuyWorkshopUnlockProgress()// no visual unlock needs adding
    {
        if (!GC.Workshop_Lvl2_L1)
        {
            if (GC.Stairs_2 && GC.Player_Metal >= 50 && GC.Player_Wood >= 50 && GC.Player_Tech >= 50) { GC.Player_Metal -= 50; GC.Player_Wood -= 50; GC.Player_Tech -= 50; GC.Workshop_Lvl2_L1 = true; workshop_Lvl2_L1_Def.SetActive(false); workshop_Lvl2_L1_Up_1.SetActive(false); }
        }
        if (!GC.Workshop_Lvl2_L2)
        {
            if (GC.Workshop_Lvl2_L1 && GC.Player_Metal >= 250 && GC.Player_Wood >= 250 && GC.Player_Tech >= 250) { GC.Player_Metal -= 250; GC.Player_Wood -= 250; GC.Player_Tech -= 250; GC.Workshop_Lvl2_L2 = true; workshop_Lvl2_L2_Def.SetActive(false); workshop_Lvl2_L2_Up_1.SetActive(false); }
        }
    }
    private void BuyLivingSpaceUnlockProgress()// no visual unlock needs adding
    {
        if (!GC.LivingSpace_Lvl3_R1)
        {
            if (GC.Stairs_3 && GC.Player_Metal >= 500 && GC.Player_Wood >= 500 && GC.Player_Tech >= 500) { GC.Player_Metal -= 500; GC.Player_Wood -= 500; GC.Player_Tech -= 500; GC.LivingSpace_Lvl3_R1 = true; livingSpace_Lvl3_R1_Def.SetActive(false); livingSpace_Lvl3_R1_Up_1.SetActive(false); }
        }
        if (!GC.LivingSpace_Lvl3_R2)
        {
            if (GC.LivingSpace_Lvl3_R1 && GC.Player_Metal >= 1000 && GC.Player_Wood >= 1000 && GC.Player_Tech >= 1000) { GC.Player_Metal -= 1000; GC.Player_Wood -= 1000; GC.Player_Tech -= 1000; GC.LivingSpace_Lvl3_R2 = true; livingSpace_Lvl3_R2_Def.SetActive(false); livingSpace_Lvl3_R2_Up_1.SetActive(false); }
        }
    }
    #endregion
    #region Purchase Buildings & Upgrades
    // BEDROOM LVL1 LEFT UNLOCK
    #region Unlock Bedroom Lvl1 L & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Bedroom_Lvl1_L()
    {
        if (!GC.Bedroom_Lvl1_L) { Unlock_Bedroom_Lvl1_L(); }
        else
        {
            switch (GC.Bedroom_Upg_Lvl1_L)
            {
                case 1:
                    Buy_Up_To_2_Bedroom_Lvl1_L();
                    break;
                case 2:
                    Buy_Up_To_3_Bedroom_Lvl1_L();
                    break;
                case 3:
                    Buy_Up_To_4_Bedroom_Lvl1_L();
                    break;
                case 4:
                    Buy_Up_To_5_Bedroom_Lvl1_L();
                    break;
                case 5:
                    Buy_Up_To_6_Bedroom_Lvl1_L();
                    break;
                case 6:
                    Buy_Up_To_7_Bedroom_Lvl1_L();
                    break;
                case 7:
                    Buy_Up_To_8_Bedroom_Lvl1_L();
                    break;
                case 8:
                    Buy_Up_To_9_Bedroom_Lvl1_L();
                    break;
                case 9:
                    Buy_Up_To_10_Bedroom_Lvl1_L();
                    break;
                case 10:
                    // Ui message Max Level
                    break;
            }
        }
    }
    private void Unlock_Bedroom_Lvl1_L()
    {
        if (GC.Bedroom_Lvl1_L_Clik_Unlock >= 50)
        {
            GC.Bedroom_Lvl1_L_Clik_Unlock -= 50;
            GC.Player_Capacity += 1;
            GC.Bedroom_Lvl1_L = true;
            GC.Bedroom_Upg_Lvl1_L = 1;
            bedroom_Lvl1_L_Rock.SetActive(false);
            bedroom_Lvl1_L_Up_1.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_2_Bedroom_Lvl1_L()
    {
        if (GC.Bedroom_Lvl1_L_Clik_Unlock >= 25)
        {
            GC.Bedroom_Lvl1_L_Clik_Unlock -=25;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_L = 2;
            bedroom_Lvl1_L_Up_1.SetActive(false);
            bedroom_Lvl1_L_Up_2.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_3_Bedroom_Lvl1_L()
    {
        if (GC.Bedroom_Lvl1_L_Clik_Unlock >= 50)
        {
            GC.Bedroom_Lvl1_L_Clik_Unlock -=50;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_L = 3;
            bedroom_Lvl1_L_Up_2.SetActive(false);
            bedroom_Lvl1_L_Up_3.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_4_Bedroom_Lvl1_L()
    {
        if (GC.Bedroom_Lvl1_L_Clik_Unlock >= 75)
        {
            GC.Bedroom_Lvl1_L_Clik_Unlock -=75;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_L = 4;
            bedroom_Lvl1_L_Up_3.SetActive(false);
            bedroom_Lvl1_L_Up_4.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_5_Bedroom_Lvl1_L()
    {
        if (GC.Bedroom_Lvl1_L_Clik_Unlock >= 100)
        {
            GC.Bedroom_Lvl1_L_Clik_Unlock -=100;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_L = 5;
            bedroom_Lvl1_L_Up_4.SetActive(false);
            bedroom_Lvl1_L_Up_5.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_6_Bedroom_Lvl1_L()
    {
        if (GC.Bedroom_Lvl1_L_Clik_Unlock >= 125)
        {
            GC.Bedroom_Lvl1_L_Clik_Unlock -=125;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_L = 6;
            bedroom_Lvl1_L_Up_5.SetActive(false);
            bedroom_Lvl1_L_Up_6.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_7_Bedroom_Lvl1_L()
    {
        if (GC.Bedroom_Lvl1_L_Clik_Unlock >= 150)
        {
            GC.Bedroom_Lvl1_L_Clik_Unlock -=150;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_L = 7;
            bedroom_Lvl1_L_Up_6.SetActive(false);
            bedroom_Lvl1_L_Up_7.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_8_Bedroom_Lvl1_L()
    {
        if (GC.Bedroom_Lvl1_L_Clik_Unlock >= 175)
        {
            GC.Bedroom_Lvl1_L_Clik_Unlock -=175;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_L = 8;
            bedroom_Lvl1_L_Up_7.SetActive(false);
            bedroom_Lvl1_L_Up_8.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_9_Bedroom_Lvl1_L()
    {
        if (GC.Bedroom_Lvl1_L_Clik_Unlock >= 200)
        {
            GC.Bedroom_Lvl1_L_Clik_Unlock -=200;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_L = 9;
            bedroom_Lvl1_L_Up_8.SetActive(false);
            bedroom_Lvl1_L_Up_9.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_10_Bedroom_Lvl1_L()
    {
        if (GC.Bedroom_Lvl1_L_Clik_Unlock >= 225)
        {
            GC.Bedroom_Lvl1_L_Clik_Unlock -=225;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_L = 10;
            bedroom_Lvl1_L_Up_9.SetActive(false);
            bedroom_Lvl1_L_Up_10.SetActive(true); DiplayUiStats();
        }
    }
    #endregion
    // BEDROOM LVL1 RIGHT UNLOCK
    #region Unlock Bedroom Lvl1 R & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Bedroom_Lvl1_R()
    {
        if (!GC.Bedroom_Lvl1_R) { Unlock_Bedroom_Lvl1_R(); }
        else
        {
            switch (GC.Bedroom_Upg_Lvl1_R)
            {
                case 1:
                    Buy_Up_To_2_Bedroom_Lvl1_R();
                    break;
                case 2:
                    Buy_Up_To_3_Bedroom_Lvl1_R();
                    break;
                case 3:
                    Buy_Up_To_4_Bedroom_Lvl1_R();
                    break;
                case 4:
                    Buy_Up_To_5_Bedroom_Lvl1_R();
                    break;
                case 5:
                    Buy_Up_To_6_Bedroom_Lvl1_R();
                    break;
                case 6:
                    Buy_Up_To_7_Bedroom_Lvl1_R();
                    break;
                case 7:
                    Buy_Up_To_8_Bedroom_Lvl1_R();
                    break;
                case 8:
                    Buy_Up_To_9_Bedroom_Lvl1_R();
                    break;
                case 9:
                    Buy_Up_To_10_Bedroom_Lvl1_R();
                    break;
                case 10:
                    // message max level
                    break;
            }
        }
    }
    private void Unlock_Bedroom_Lvl1_R()
    {
        if (GC.Bedroom_Lvl1_R_Clik_Unlock >= 50)
        {
            GC.Bedroom_Lvl1_R_Clik_Unlock -=50;
            GC.Player_Capacity += 1;
            GC.Bedroom_Lvl1_R = true;
            GC.Bedroom_Upg_Lvl1_R = 1;
            bedroom_Lvl1_R_Rock.SetActive(false);
            bedroom_Lvl1_R_Up_1.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_2_Bedroom_Lvl1_R()
    {
        if (GC.Bedroom_Lvl1_R_Clik_Unlock >= 25)
        {
            GC.Bedroom_Lvl1_R_Clik_Unlock -=25;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_R = 2;
            bedroom_Lvl1_R_Up_1.SetActive(false);
            bedroom_Lvl1_R_Up_2.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_3_Bedroom_Lvl1_R()
    {
        if (GC.Bedroom_Lvl1_R_Clik_Unlock >= 50)
        {
            GC.Bedroom_Lvl1_R_Clik_Unlock -=50;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_R = 3;
            bedroom_Lvl1_R_Up_2.SetActive(false);
            bedroom_Lvl1_R_Up_3.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_4_Bedroom_Lvl1_R()
    {
        if (GC.Bedroom_Lvl1_R_Clik_Unlock >= 75)
        {
            GC.Bedroom_Lvl1_R_Clik_Unlock -=75;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_R = 4;
            bedroom_Lvl1_R_Up_3.SetActive(false);
            bedroom_Lvl1_R_Up_4.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_5_Bedroom_Lvl1_R()
    {
        if (GC.Bedroom_Lvl1_R_Clik_Unlock >= 100)
        {
            GC.Bedroom_Lvl1_R_Clik_Unlock -=100;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_R = 5;
            bedroom_Lvl1_R_Up_4.SetActive(false);
            bedroom_Lvl1_R_Up_5.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_6_Bedroom_Lvl1_R()
    {
        if (GC.Bedroom_Lvl1_R_Clik_Unlock >= 125)
        {
            GC.Bedroom_Lvl1_R_Clik_Unlock -=125;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_R = 6;
            bedroom_Lvl1_R_Up_5.SetActive(false);
            bedroom_Lvl1_R_Up_6.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_7_Bedroom_Lvl1_R()
    {
        if (GC.Bedroom_Lvl1_R_Clik_Unlock >= 150)
        {
            GC.Bedroom_Lvl1_R_Clik_Unlock -=150;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_R = 7;
            bedroom_Lvl1_R_Up_6.SetActive(false);
            bedroom_Lvl1_R_Up_7.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_8_Bedroom_Lvl1_R()
    {
        if (GC.Bedroom_Lvl1_R_Clik_Unlock >= 175)
        {
            GC.Bedroom_Lvl1_R_Clik_Unlock -=175;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_R = 8;
            bedroom_Lvl1_R_Up_7.SetActive(false);
            bedroom_Lvl1_R_Up_8.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_9_Bedroom_Lvl1_R()
    {
        if (GC.Bedroom_Lvl1_R_Clik_Unlock >= 200)
        {
            GC.Bedroom_Lvl1_R_Clik_Unlock -=200;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_R = 9;
            bedroom_Lvl1_R_Up_8.SetActive(false);
            bedroom_Lvl1_R_Up_9.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_10_Bedroom_Lvl1_R()
    {
        if (GC.Bedroom_Lvl1_R_Clik_Unlock >= 225)
        {
            GC.Bedroom_Lvl1_R_Clik_Unlock -=225;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_R = 10;
            bedroom_Lvl1_R_Up_9.SetActive(false);
            bedroom_Lvl1_R_Up_10.SetActive(true); DiplayUiStats();
        }
    }
    #endregion
    // BEDROOM LVL2 LEFT UNLOCK
    #region Unlock Bedroom Lvl2 L & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Bedroom_Lvl2_L()
    {
        if (!GC.Bedroom_Lvl2_L) { Unlock_Bedroom_Lvl2_L(); }
        else
        {
            switch (GC.Bedroom_Upg_Lvl2_L)
            {
                case 1:
                    Buy_Up_To_2_Bedroom_Lvl2_L();
                    break;
                case 2:
                    Buy_Up_To_3_Bedroom_Lvl2_L();
                    break;
                case 3:
                    Buy_Up_To_4_Bedroom_Lvl2_L();
                    break;
                case 4:
                    Buy_Up_To_5_Bedroom_Lvl2_L();
                    break;
                case 5:
                    Buy_Up_To_6_Bedroom_Lvl2_L();
                    break;
                case 6:
                    Buy_Up_To_7_Bedroom_Lvl2_L();
                    break;
                case 7:
                    Buy_Up_To_8_Bedroom_Lvl2_L();
                    break;
                case 8:
                    Buy_Up_To_9_Bedroom_Lvl2_L();
                    break;
                case 9:
                    Buy_Up_To_10_Bedroom_Lvl2_L();
                    break;
                case 10:
                    // Ui Message max level
                    break;
            }
        }
    }
    private void Unlock_Bedroom_Lvl2_L()
    {
        if (GC.Workshop_Lvl2_L2 && GC.Bedroom_Lvl2_L_Clik_Unlock >= 125)
        {
            GC.Bedroom_Lvl2_L_Clik_Unlock -=125;
            GC.Player_Capacity += 1;
            GC.Bedroom_Lvl2_L = true;
            GC.Bedroom_Upg_Lvl2_L = 1;
            bedroom_Lvl2_L_Rock.SetActive(false);
            bedroom_Lvl2_L_Up_1.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_2_Bedroom_Lvl2_L()
    {
        if (GC.Bedroom_Lvl2_L_Clik_Unlock >= 150)
        {
            GC.Bedroom_Lvl2_L_Clik_Unlock -=150;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_L = 2;
            bedroom_Lvl2_L_Up_1.SetActive(false);
            bedroom_Lvl2_L_Up_2.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_3_Bedroom_Lvl2_L()
    {
        if (GC.Bedroom_Lvl2_L_Clik_Unlock >= 175)
        {
            GC.Bedroom_Lvl2_L_Clik_Unlock -=175;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_L = 3;
            bedroom_Lvl2_L_Up_2.SetActive(false);
            bedroom_Lvl2_L_Up_3.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_4_Bedroom_Lvl2_L()
    {
        if (GC.Bedroom_Lvl2_L_Clik_Unlock >= 200)
        {
            GC.Bedroom_Lvl2_L_Clik_Unlock -=200;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_L = 4;
            bedroom_Lvl2_L_Up_3.SetActive(false);
            bedroom_Lvl2_L_Up_4.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_5_Bedroom_Lvl2_L()
    {
        if (GC.Bedroom_Lvl2_L_Clik_Unlock >= 225)
        {
            GC.Bedroom_Lvl2_L_Clik_Unlock -=225;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_L = 5;
            bedroom_Lvl2_L_Up_4.SetActive(false);
            bedroom_Lvl2_L_Up_5.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_6_Bedroom_Lvl2_L()
    {
        if (GC.Bedroom_Lvl2_L_Clik_Unlock >= 250)
        {
            GC.Bedroom_Lvl2_L_Clik_Unlock -=250;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_L = 6;
            bedroom_Lvl2_L_Up_5.SetActive(false);
            bedroom_Lvl2_L_Up_6.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_7_Bedroom_Lvl2_L()
    {
        if (GC.Bedroom_Lvl2_L_Clik_Unlock >= 275)
        {
            GC.Bedroom_Lvl2_L_Clik_Unlock -=275;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_L = 7;
            bedroom_Lvl2_L_Up_6.SetActive(false);
            bedroom_Lvl2_L_Up_7.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_8_Bedroom_Lvl2_L()
    {
        if (GC.Bedroom_Lvl2_L_Clik_Unlock >= 300)
        {
            GC.Bedroom_Lvl2_L_Clik_Unlock -=300;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_L = 8;
            bedroom_Lvl2_L_Up_7.SetActive(false);
            bedroom_Lvl2_L_Up_8.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_9_Bedroom_Lvl2_L()
    {
        if (GC.Bedroom_Lvl2_L_Clik_Unlock >= 325)
        {
            GC.Bedroom_Lvl2_L_Clik_Unlock -=325;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_L = 9;
            bedroom_Lvl2_L_Up_8.SetActive(false);
            bedroom_Lvl2_L_Up_9.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_10_Bedroom_Lvl2_L()
    {
        if (GC.Bedroom_Lvl2_L_Clik_Unlock >= 350)
        {
            GC.Bedroom_Lvl2_L_Clik_Unlock -=350;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_L = 10;
            bedroom_Lvl2_L_Up_9.SetActive(false);
            bedroom_Lvl2_L_Up_10.SetActive(true); DiplayUiStats();
        }
    }
    #endregion
    // BEDROOM LVL2 RIGHT UNLOCK
    #region Unlock Bedroom Lvl2 R & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Bedroom_Lvl2_R()
    {
        if (!GC.Bedroom_Lvl2_R) { Unlock_Bedroom_Lvl2_R(); }
        else
        {
            switch (GC.Bedroom_Upg_Lvl2_R)
            {
                case 1:
                    Buy_Up_To_2_Bedroom_Lvl2_R();
                    break;
                case 2:
                    Buy_Up_To_3_Bedroom_Lvl2_R();
                    break;
                case 3:
                    Buy_Up_To_4_Bedroom_Lvl2_R();
                    break;
                case 4:
                    Buy_Up_To_5_Bedroom_Lvl2_R();
                    break;
                case 5:
                    Buy_Up_To_6_Bedroom_Lvl2_R();
                    break;
                case 6:
                    Buy_Up_To_7_Bedroom_Lvl2_R();
                    break;
                case 7:
                    Buy_Up_To_8_Bedroom_Lvl2_R();
                    break;
                case 8:
                    Buy_Up_To_9_Bedroom_Lvl2_R();
                    break;
                case 9:
                    Buy_Up_To_10_Bedroom_Lvl2_R();
                    break;
                case 10:
                    // message max level
                    break;
            }
        }
    }
    private void Unlock_Bedroom_Lvl2_R()
    {
        if (GC.Generator_Lvl2_R2 && GC.Bedroom_Lvl2_R_Clik_Unlock >= 125)
        {
            GC.Bedroom_Lvl2_R_Clik_Unlock -=125;
            GC.Player_Capacity += 1;
            GC.Bedroom_Lvl2_R = true;
            GC.Bedroom_Upg_Lvl2_R = 1;
            bedroom_Lvl2_R_Rock.SetActive(false);
            bedroom_Lvl2_R_Up_1.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_2_Bedroom_Lvl2_R()
    {
        if (GC.Bedroom_Lvl2_R_Clik_Unlock >= 150)
        {
            GC.Bedroom_Lvl2_R_Clik_Unlock -=150;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_R = 2;
            bedroom_Lvl2_R_Up_1.SetActive(false);
            bedroom_Lvl2_R_Up_2.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_3_Bedroom_Lvl2_R()
    {
        if (GC.Bedroom_Lvl2_R_Clik_Unlock >= 175)
        {
            GC.Bedroom_Lvl2_R_Clik_Unlock -=175;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_R = 3;
            bedroom_Lvl2_R_Up_2.SetActive(false);
            bedroom_Lvl2_R_Up_3.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_4_Bedroom_Lvl2_R()
    {
        if (GC.Bedroom_Lvl2_R_Clik_Unlock >= 200)
        {
            GC.Bedroom_Lvl2_R_Clik_Unlock -=200;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_R = 4;
            bedroom_Lvl2_R_Up_3.SetActive(false);
            bedroom_Lvl2_R_Up_4.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_5_Bedroom_Lvl2_R()
    {
        if (GC.Bedroom_Lvl2_R_Clik_Unlock >= 225)
        {
            GC.Bedroom_Lvl2_R_Clik_Unlock -=225;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_R = 5;
            bedroom_Lvl2_R_Up_4.SetActive(false);
            bedroom_Lvl2_R_Up_5.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_6_Bedroom_Lvl2_R()
    {
        if (GC.Bedroom_Lvl2_R_Clik_Unlock >= 250)
        {
            GC.Bedroom_Lvl2_R_Clik_Unlock -=250;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_R = 6;
            bedroom_Lvl2_R_Up_5.SetActive(false);
            bedroom_Lvl2_R_Up_6.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_7_Bedroom_Lvl2_R()
    {
        if (GC.Bedroom_Lvl2_R_Clik_Unlock >= 275)
        {
            GC.Bedroom_Lvl2_R_Clik_Unlock -=275;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_R = 7;
            bedroom_Lvl2_R_Up_6.SetActive(false);
            bedroom_Lvl2_R_Up_7.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_8_Bedroom_Lvl2_R()
    {
        if (GC.Bedroom_Lvl2_R_Clik_Unlock >= 300)
        {
            GC.Bedroom_Lvl2_R_Clik_Unlock -=300;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_R = 8;
            bedroom_Lvl2_R_Up_7.SetActive(false);
            bedroom_Lvl2_R_Up_8.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_9_Bedroom_Lvl2_R()
    {
        if (GC.Bedroom_Lvl2_R_Clik_Unlock >= 325)
        {
            GC.Bedroom_Lvl2_R_Clik_Unlock -=325;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_R = 9;
            bedroom_Lvl2_R_Up_8.SetActive(false);
            bedroom_Lvl2_R_Up_9.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_10_Bedroom_Lvl2_R()
    {
        if (GC.Bedroom_Lvl2_R_Clik_Unlock >= 350)
        {
            GC.Bedroom_Lvl2_R_Clik_Unlock -=350;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_R = 10;
            bedroom_Lvl2_R_Up_9.SetActive(false);
            bedroom_Lvl2_R_Up_10.SetActive(true); DiplayUiStats();
        }
    }
    #endregion
    // BEDROOM LVL3 LEFT UNLOCK
    #region Unlock Bedroom Lvl3 L & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Bedroom_Lvl3_L()
    {
        if (!GC.Bedroom_Lvl3_L) { Unlock_Bedroom_Lvl3_L(); }
        else
        {
            switch (GC.Bedroom_Upg_Lvl3_L)
            {
                case 1:
                    Buy_Up_To_2_Bedroom_Lvl3_L();
                    break;
                case 2:
                    Buy_Up_To_3_Bedroom_Lvl3_L();
                    break;
                case 3:
                    Buy_Up_To_4_Bedroom_Lvl3_L();
                    break;
                case 4:
                    Buy_Up_To_5_Bedroom_Lvl3_L();
                    break;
                case 5:
                    Buy_Up_To_6_Bedroom_Lvl3_L();
                    break;
                case 6:
                    Buy_Up_To_7_Bedroom_Lvl3_L();
                    break;
                case 7:
                    Buy_Up_To_8_Bedroom_Lvl3_L();
                    break;
                case 8:
                    Buy_Up_To_9_Bedroom_Lvl3_L();
                    break;
                case 9:
                    Buy_Up_To_10_Bedroom_Lvl3_L();
                    break;
                case 10:
                    // message max level
                    break;
            }
        }
    }
    private void Unlock_Bedroom_Lvl3_L()
    {
        if (GC.Research_Lvl3_L2 && GC.Bedroom_Lvl3_L_Clik_Unlock >= 250)
        {
            GC.Bedroom_Lvl3_L_Clik_Unlock -=250;
            GC.Player_Capacity += 1;
            GC.Bedroom_Lvl3_L = true;
            GC.Bedroom_Upg_Lvl3_L = 1;
            bedroom_Lvl3_L_Rock.SetActive(false);
            bedroom_Lvl3_L_Up_1.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_2_Bedroom_Lvl3_L()
    {
        if (GC.Bedroom_Lvl3_L_Clik_Unlock >= 275)
        {
            GC.Bedroom_Lvl3_L_Clik_Unlock -=275;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_L = 2;
            bedroom_Lvl3_L_Up_1.SetActive(false);
            bedroom_Lvl3_L_Up_2.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_3_Bedroom_Lvl3_L()
    {
        if (GC.Bedroom_Lvl3_L_Clik_Unlock >= 300)
        {
            GC.Bedroom_Lvl3_L_Clik_Unlock -=300;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_L = 3;
            bedroom_Lvl3_L_Up_2.SetActive(false);
            bedroom_Lvl3_L_Up_3.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_4_Bedroom_Lvl3_L()
    {
        if (GC.Bedroom_Lvl3_L_Clik_Unlock >= 325)
        {
            GC.Bedroom_Lvl3_L_Clik_Unlock -=325;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_L = 4;
            bedroom_Lvl3_L_Up_3.SetActive(false);
            bedroom_Lvl3_L_Up_4.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_5_Bedroom_Lvl3_L()
    {
        if (GC.Bedroom_Lvl3_L_Clik_Unlock >= 350)
        {
            GC.Bedroom_Lvl3_L_Clik_Unlock -=350;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_L = 5;
            bedroom_Lvl3_L_Up_4.SetActive(false);
            bedroom_Lvl3_L_Up_5.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_6_Bedroom_Lvl3_L()
    {
        if (GC.Bedroom_Lvl3_L_Clik_Unlock >= 375)
        {
            GC.Bedroom_Lvl3_L_Clik_Unlock -=375;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_L = 6;
            bedroom_Lvl3_L_Up_5.SetActive(false);
            bedroom_Lvl3_L_Up_6.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_7_Bedroom_Lvl3_L()
    {
        if (GC.Bedroom_Lvl3_L_Clik_Unlock >= 400)
        {
            GC.Bedroom_Lvl3_L_Clik_Unlock -=400;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_L = 7;
            bedroom_Lvl3_L_Up_6.SetActive(false);
            bedroom_Lvl3_L_Up_7.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_8_Bedroom_Lvl3_L()
    {
        if (GC.Bedroom_Lvl3_L_Clik_Unlock >= 425)
        {
            GC.Bedroom_Lvl3_L_Clik_Unlock -=425;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_L = 8;
            bedroom_Lvl3_L_Up_7.SetActive(false);
            bedroom_Lvl3_L_Up_8.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_9_Bedroom_Lvl3_L()
    {
        if (GC.Bedroom_Lvl3_L_Clik_Unlock >= 450)
        {
            GC.Bedroom_Lvl3_L_Clik_Unlock -=450;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_L = 9;
            bedroom_Lvl3_L_Up_8.SetActive(false);
            bedroom_Lvl3_L_Up_9.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_10_Bedroom_Lvl3_L()
    {
        if (GC.Bedroom_Lvl3_L_Clik_Unlock >= 475)
        {
            GC.Bedroom_Lvl3_L_Clik_Unlock -=475;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_L = 10;
            bedroom_Lvl3_L_Up_9.SetActive(false);
            bedroom_Lvl3_L_Up_10.SetActive(true); DiplayUiStats();
        }
    }
    #endregion
    // BEDROOM LVL3 RIGHT UNLOCK
    #region Unlock Bedroom Lvl3 R & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Bedroom_Lvl3_R()
    {
        if (!GC.Bedroom_Lvl3_R) { Unlock_Bedroom_Lvl3_R(); }
        else
        {
            switch (GC.Bedroom_Upg_Lvl3_R)
            {
                case 1:
                    Buy_Up_To_2_Bedroom_Lvl3_R();
                    break;
                case 2:
                    Buy_Up_To_3_Bedroom_Lvl3_R();
                    break;
                case 3:
                    Buy_Up_To_4_Bedroom_Lvl3_R();
                    break;
                case 4:
                    Buy_Up_To_5_Bedroom_Lvl3_R();
                    break;
                case 5:
                    Buy_Up_To_6_Bedroom_Lvl3_R();
                    break;
                case 6:
                    Buy_Up_To_7_Bedroom_Lvl3_R();
                    break;
                case 7:
                    Buy_Up_To_8_Bedroom_Lvl3_R();
                    break;
                case 8:
                    Buy_Up_To_9_Bedroom_Lvl3_R();
                    break;
                case 9:
                    Buy_Up_To_10_Bedroom_Lvl3_R();
                    break;
                case 10:
                    // message max Level
                    break;
            }
        }
    }
    private void Unlock_Bedroom_Lvl3_R()
    {
        if (GC.LivingSpace_Lvl3_R2 && GC.Bedroom_Lvl3_R_Clik_Unlock >= 250)
        {
            GC.Bedroom_Lvl3_R_Clik_Unlock -=250;
            GC.Player_Capacity += 1;
            GC.Bedroom_Lvl3_R = true;
            GC.Bedroom_Upg_Lvl3_R = 1;
            bedroom_Lvl3_R_Rock.SetActive(false);
            bedroom_Lvl3_R_Up_1.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_2_Bedroom_Lvl3_R()
    {
        if (GC.Bedroom_Lvl3_R_Clik_Unlock >= 275)
        {
            GC.Bedroom_Lvl3_R_Clik_Unlock -=275;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_R = 2;
            bedroom_Lvl3_R_Up_1.SetActive(false);
            bedroom_Lvl3_R_Up_2.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_3_Bedroom_Lvl3_R()
    {
        if (GC.Bedroom_Lvl3_R_Clik_Unlock >= 300)
        {
            GC.Bedroom_Lvl3_R_Clik_Unlock -=300;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_R = 3;
            bedroom_Lvl3_R_Up_2.SetActive(false);
            bedroom_Lvl3_R_Up_3.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_4_Bedroom_Lvl3_R()
    {
        if (GC.Bedroom_Lvl3_R_Clik_Unlock >= 325)
        {
            GC.Bedroom_Lvl3_R_Clik_Unlock -=325;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_R = 4;
            bedroom_Lvl3_R_Up_3.SetActive(false);
            bedroom_Lvl3_R_Up_4.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_5_Bedroom_Lvl3_R()
    {
        if (GC.Bedroom_Lvl3_R_Clik_Unlock >= 350)
        {
            GC.Bedroom_Lvl3_R_Clik_Unlock -=350;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_R = 5;
            bedroom_Lvl3_R_Up_4.SetActive(false);
            bedroom_Lvl3_R_Up_5.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_6_Bedroom_Lvl3_R()
    {
        if (GC.Bedroom_Lvl3_R_Clik_Unlock >= 375)
        {
            GC.Bedroom_Lvl3_R_Clik_Unlock -=375;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_R = 6;
            bedroom_Lvl3_R_Up_5.SetActive(false);
            bedroom_Lvl3_R_Up_6.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_7_Bedroom_Lvl3_R()
    {
        if (GC.Bedroom_Lvl3_R_Clik_Unlock >= 400)
        {
            GC.Bedroom_Lvl3_R_Clik_Unlock -=400;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_R = 7;
            bedroom_Lvl3_R_Up_6.SetActive(false);
            bedroom_Lvl3_R_Up_7.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_8_Bedroom_Lvl3_R()
    {
        if (GC.Bedroom_Lvl3_R_Clik_Unlock >= 425)
        {
            GC.Bedroom_Lvl3_R_Clik_Unlock -=425;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_R = 8;
            bedroom_Lvl3_R_Up_7.SetActive(false);
            bedroom_Lvl3_R_Up_8.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_9_Bedroom_Lvl3_R()
    {
        if (GC.Bedroom_Lvl3_R_Clik_Unlock >= 450)
        {
            GC.Bedroom_Lvl3_R_Clik_Unlock -=450;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_R = 9;
            bedroom_Lvl3_R_Up_8.SetActive(false);
            bedroom_Lvl3_R_Up_9.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_10_Bedroom_Lvl3_R()
    {
        if (GC.Bedroom_Lvl3_R_Clik_Unlock >= 475)
        {
            GC.Bedroom_Lvl3_R_Clik_Unlock -=475;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_R = 10;
            bedroom_Lvl3_R_Up_9.SetActive(false);
            bedroom_Lvl3_R_Up_10.SetActive(true); DiplayUiStats();
        }
    }
    #endregion 
    // STAIRS 2 UNLOCK
    #region Stairs 2 Unlock
    public void Upgrade_Stairs_2()
    {
        Unlock_Stairs_2();
    }
    private void Unlock_Stairs_2()
    {
        if (GC.Stairs_1 && GC.Stairs_2_Clicks_Unlock >= 25)
        {
            GC.Stairs_2_Clicks_Unlock -=25;
            GC.Stairs_2 = true;
            stairs_2_Locked.SetActive(false); stairs_2_Unlocked.SetActive(true); DiplayUiStats();
        }
    }
    #endregion
    // STAIRS 3 UNLOCK
    #region Stairs 3 Unlock
    public void Upgrade_Stairs_3()
    {
        Unlock_Stairs_3();
    }
    private void Unlock_Stairs_3()
    {
        if (GC.Stairs_2 && GC.Stairs_2_Clicks_Unlock >= 125)
        {
            GC.Stairs_3_Clicks_Unlock -=125;
            GC.Stairs_3 = true;
            stairs_3_Locked.SetActive(false); stairs_3_Unlocked.SetActive(true); DiplayUiStats();
        }
    }
    #endregion
    // Expedition(1) & Training(2) IS LEVEL 2 RIGHT SIDE
    #region Expedition & Upgrades // not figured out the values to spend on unlocks
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Expedition_Building()
    {
        switch (GC.Expedition_Upg_Lvl1_R1)
        {
            case 1:
                Buy_Up_To_2_Expedition();
                break;
            case 2:
                Buy_Up_To_3_Expedition();
                break;
            case 3:
                Buy_Up_To_4_Expedition();
                break;
            case 4:
                Buy_Up_To_5_Expedition();
                break;
            case 5:
               // Ui message max level
                break;
        }
    }
    private void Buy_Up_To_2_Expedition()
    {
        if (GC.Player_Metal >= purchaseValue && GC.Player_Wood >= purchaseValue && GC.Player_Tech >= purchaseValue)
        {
            GC.Player_Metal -= purchaseValue;
            GC.Player_Wood -= purchaseValue;
            GC.Player_Tech -= purchaseValue;
            GC.Expedition_Upg_Lvl1_R1 = 2;
            expedition_Lvl1_R1_Up_1.SetActive(false);
            expedition_Lvl1_R1_Up_2.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_3_Expedition()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Expedition_Upg_Lvl1_R1 = 3;
            expedition_Lvl1_R1_Up_2.SetActive(false);
            expedition_Lvl1_R1_Up_3.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_4_Expedition()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Expedition_Upg_Lvl1_R1 = 4;
            expedition_Lvl1_R1_Up_3.SetActive(false);
            expedition_Lvl1_R1_Up_4.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_5_Expedition()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Expedition_Upg_Lvl1_R1 = 5;
            expedition_Lvl1_R1_Up_4.SetActive(false);
            expedition_Lvl1_R1_Up_5.SetActive(true); DiplayUiStats();
        }
    }
    #endregion
    #region Training & Upgrades // not figured out the values to spend on unlocks
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Training_Building()
    {
        switch (GC.Training_Upg_Lvl1_R2)
            {
                case 1:
                Buy_Up_To_2_Training();
                    break;
                case 2:
                Buy_Up_To_3_Training();
                    break;
                case 3:
                Buy_Up_To_4_Training();
                    break;
                case 4:
                Buy_Up_To_5_Training();
                    break;
                case 5:
                // ui message max level
                    break;
            }
    }
    private void Buy_Up_To_2_Training()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Training_Upg_Lvl1_R2 = 2;
            training_Lvl1_R2_Up_1.SetActive(false);
            training_Lvl1_R2_Up_2.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_3_Training()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Training_Upg_Lvl1_R2 = 3;
            training_Lvl1_R2_Up_2.SetActive(false);
            training_Lvl1_R2_Up_3.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_4_Training()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Training_Upg_Lvl1_R2 = 4;
            training_Lvl1_R2_Up_3.SetActive(false);
            training_Lvl1_R2_Up_4.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_5_Training()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.Training_Upg_Lvl1_R2 = 5;
            training_Lvl1_R2_Up_4.SetActive(false);
            training_Lvl1_R2_Up_5.SetActive(true); DiplayUiStats();
        }
    }
    #endregion
    // UnderGarden(1) & Radio(2) IS LEVEL 1 LEFT SIDE
    #region UnderGarden & Upgrades // not figured out the values to spend on unlocks
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_UnderGarden_Building()
    {
        switch (GC.UnderGarden_Upg_Lvl1_L1)
            {
                case 1:
                Buy_Up_To_2_UnderGarden();
                    break;
                case 2:
                Buy_Up_To_3_UnderGarden();
                    break;
                case 3:
                Buy_Up_To_4_UnderGarden();
                    break;
                case 4:
                Buy_Up_To_5_UnderGarden();
                    break;
                case 5:
                // ui message max level
                    break;
            }
    }
    private void Buy_Up_To_2_UnderGarden()
    {
        if (GC.Player_Metal >= purchaseValue && GC.Player_Wood >= purchaseValue && GC.Player_Tech >= purchaseValue)
        {
            GC.Player_Metal -= purchaseValue;
            GC.Player_Wood -= purchaseValue;
            GC.Player_Tech -= purchaseValue;
            GC.UnderGarden_Upg_Lvl1_L1 = 2;
            underGarden_Lvl1_L1_Up_1.SetActive(false);
            underGarden_Lvl1_L1_Up_2.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_3_UnderGarden()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.UnderGarden_Upg_Lvl1_L1 = 3;
            underGarden_Lvl1_L1_Up_2.SetActive(false);
            underGarden_Lvl1_L1_Up_3.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_4_UnderGarden()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.UnderGarden_Upg_Lvl1_L1 = 4;
            underGarden_Lvl1_L1_Up_3.SetActive(false);
            underGarden_Lvl1_L1_Up_4.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_5_UnderGarden()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.UnderGarden_Upg_Lvl1_L1 = 5;
            underGarden_Lvl1_L1_Up_4.SetActive(false);
            underGarden_Lvl1_L1_Up_5.SetActive(true); DiplayUiStats();
        }
    }
    #endregion
    #region Radio & Upgrades // not figured out the values to spend on unlocks
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Radio_Building()
    {
        switch (GC.Radio_Upg_Lvl1_L2)
            {
                case 1:
                    Buy_Up_To_2_Radio();
                    break;
                case 2:
                    Buy_Up_To_3_Radio();
                    break;
                case 3:
                    Buy_Up_To_4_Radio();
                    break;
                case 4:
                    Buy_Up_To_5_Radio();
                    break;
                case 5:
                    // ui message max level
                    break;
            }
    }
    private void Buy_Up_To_2_Radio()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Radio_Upg_Lvl1_L2 = 2;
            radio_Lvl1_L2_Up_1.SetActive(false);
            radio_Lvl1_L2_Up_2.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_3_Radio()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Radio_Upg_Lvl1_L2 = 3;
            radio_Lvl1_L2_Up_2.SetActive(false);
            radio_Lvl1_L2_Up_3.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_4_Radio()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Radio_Upg_Lvl1_L2 = 4;
            radio_Lvl1_L2_Up_3.SetActive(false);
            radio_Lvl1_L2_Up_4.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_5_Radio()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.Radio_Upg_Lvl1_L2 = 5;
            radio_Lvl1_L2_Up_4.SetActive(false);
            radio_Lvl1_L2_Up_5.SetActive(true); DiplayUiStats();
        }
    }
    #endregion
    // GENERATOR IS LEVEL 2 RIGHT SIDE
    #region Unlock Generator 1 & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Generator_Building_1()
    {
        if (!GC.Generator_Lvl2_R1) { Unlock_Generator_1(); }
        else
        {
            switch (GC.Generator_Upg_Lvl2_R1)
            {
                case 1:
                    Buy_Up_To_2_Generator_1();
                    break;
                case 2:
                    Buy_Up_To_3_Generator_1();
                    break;
                case 3:
                    Buy_Up_To_4_Generator_1();
                    break;
                case 4:
                    Buy_Up_To_5_Generator_1();
                    break;
                case 5:
                    // ui message max level
                    break;
            }
        }
    }
    private void Unlock_Generator_1()
    {
        if (GC.Stairs_2 && GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);// purchaseValue is 250
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Generator_Lvl2_R1 = true;
            GC.Generator_Upg_Lvl2_R1 = 1;
            generator_Lvl2_R1_Def.SetActive(false);
            generator_Lvl2_R1_Up_1.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_2_Generator_1()
    {
        if (GC.Player_Metal >= purchaseValue && GC.Player_Wood >= purchaseValue && GC.Player_Tech >= purchaseValue)
        {
            GC.Player_Metal -= purchaseValue;
            GC.Player_Wood -= purchaseValue;
            GC.Player_Tech -= purchaseValue;
            GC.Generator_Upg_Lvl2_R1 = 2;
            generator_Lvl2_R1_Up_1.SetActive(false);
            generator_Lvl2_R1_Up_2.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_3_Generator_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Generator_Upg_Lvl2_R1 = 3;
            generator_Lvl2_R1_Up_2.SetActive(false);
            generator_Lvl2_R1_Up_3.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_4_Generator_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Generator_Upg_Lvl2_R1 = 4;
            generator_Lvl2_R1_Up_3.SetActive(false);
            generator_Lvl2_R1_Up_4.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_5_Generator_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Generator_Upg_Lvl2_R1 = 5;
            generator_Lvl2_R1_Up_4.SetActive(false);
            generator_Lvl2_R1_Up_5.SetActive(true); DiplayUiStats();
        }
    }
    #endregion
    #region Unlock Generator 2 & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Generator_Building_2()
    {
        if (!GC.Generator_Lvl2_R2) { Unlock_Generator_2(); }
        else
        {
            switch (GC.Generator_Upg_Lvl2_R2)
            {
                case 1:
                    Buy_Up_To_2_Generator_2();
                    break;
                case 2:
                    Buy_Up_To_3_Generator_2();
                    break;
                case 3:
                    Buy_Up_To_4_Generator_2();
                    break;
                case 4:
                    Buy_Up_To_5_Generator_2();
                    break;
                case 5:
                    // ui message max level
                    break;
            }
        }
    }
    private void Unlock_Generator_2()
    {
        if (GC.Generator_Lvl2_R1 && GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);// purchaseValue is 250
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Generator_Lvl2_R2 = true;
            GC.Generator_Upg_Lvl2_R2 = 1;
            generator_Lvl2_R2_Def.SetActive(false);
            generator_Lvl2_R2_Up_1.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_2_Generator_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Generator_Upg_Lvl2_R2 = 2;
            generator_Lvl2_R2_Up_1.SetActive(false);
            generator_Lvl2_R2_Up_2.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_3_Generator_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Generator_Upg_Lvl2_R2 = 3;
            generator_Lvl2_R2_Up_2.SetActive(false);
            generator_Lvl2_R2_Up_3.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_4_Generator_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Generator_Upg_Lvl2_R2 = 4;
            generator_Lvl2_R2_Up_3.SetActive(false);
            generator_Lvl2_R2_Up_4.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_5_Generator_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.Generator_Upg_Lvl2_R2 = 5;
            generator_Lvl2_R2_Up_4.SetActive(false);
            generator_Lvl2_R2_Up_5.SetActive(true); DiplayUiStats();
        }
    }
    #endregion
    // WORKSHOP IS LEVEL 2 LEFT SIDE
    #region Unlock Workshop 1 & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Workshop_Building_1()
    {
        if (!GC.Workshop_Lvl2_L1) { Unlock_Workshop_1(); }
        else
        {
            switch (GC.Workshop_Upg_Lvl2_L1)
            {
                case 1:
                    Buy_Up_To_2_Workshop_1();
                    break;
                case 2:
                    Buy_Up_To_3_Workshop_1();
                    break;
                case 3:
                    Buy_Up_To_4_Workshop_1();
                    break;
                case 4:
                    Buy_Up_To_5_Workshop_1();
                    break;
                case 5:
                    // ui message max level
                    break;
            }
        }
    }
    private void Unlock_Workshop_1()
    {
        if (GC.Stairs_2 && GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);// purchaseValue is 250
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Workshop_Lvl2_L1 = true;
            GC.Workshop_Upg_Lvl2_L1 = 1;
            workshop_Lvl2_L1_Def.SetActive(false);
            workshop_Lvl2_L1_Up_1.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_2_Workshop_1()
    {
        if (GC.Player_Metal >= purchaseValue && GC.Player_Wood >= purchaseValue && GC.Player_Tech >= purchaseValue)
        {
            GC.Player_Metal -= purchaseValue;
            GC.Player_Wood -= purchaseValue;
            GC.Player_Tech -= purchaseValue;
            GC.Workshop_Upg_Lvl2_L1 = 2;
            workshop_Lvl2_L1_Up_1.SetActive(false);
            workshop_Lvl2_L1_Up_2.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_3_Workshop_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Workshop_Upg_Lvl2_L1 = 3;
            workshop_Lvl2_L1_Up_2.SetActive(false);
            workshop_Lvl2_L1_Up_3.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_4_Workshop_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Workshop_Upg_Lvl2_L1 = 4;
            workshop_Lvl2_L1_Up_3.SetActive(false);
            workshop_Lvl2_L1_Up_4.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_5_Workshop_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Workshop_Upg_Lvl2_L1 = 5;
            workshop_Lvl2_L1_Up_4.SetActive(false);
            workshop_Lvl2_L1_Up_5.SetActive(true); DiplayUiStats();
        }
    }
    #endregion
    #region Unlock Workshop 2 & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Workshop_Building_2()
    {
        if (!GC.Workshop_Lvl2_L2) { Unlock_Workshop_2(); }
        else
        {
            switch (GC.Workshop_Upg_Lvl2_L2)
            {
                case 1:
                    Buy_Up_To_2_Workshop_2();
                    break;
                case 2:
                    Buy_Up_To_3_Workshop_2();
                    break;
                case 3:
                    Buy_Up_To_4_Workshop_2();
                    break;
                case 4:
                    Buy_Up_To_5_Workshop_2();
                    break;
                case 5:
                    //ui message max level
                    break;
            }
        }
    }
    private void Unlock_Workshop_2()
    {
        if (GC.Workshop_Lvl2_L1 && GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);// purchaseValue is 250
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Workshop_Lvl2_L2 = true;
            GC.Workshop_Upg_Lvl2_L2 = 1;
            workshop_Lvl2_L2_Def.SetActive(false);
            workshop_Lvl2_L2_Up_1.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_2_Workshop_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Workshop_Upg_Lvl2_L2 = 2;
            workshop_Lvl2_L2_Up_1.SetActive(false);
            workshop_Lvl2_L2_Up_2.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_3_Workshop_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Workshop_Upg_Lvl2_L2 = 3;
            workshop_Lvl2_L2_Up_2.SetActive(false);
            workshop_Lvl2_L2_Up_3.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_4_Workshop_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Workshop_Upg_Lvl2_L2 = 4;
            workshop_Lvl2_L2_Up_3.SetActive(false);
            workshop_Lvl2_L2_Up_4.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_5_Workshop_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.Workshop_Upg_Lvl2_L2 = 5;
            workshop_Lvl2_L2_Up_4.SetActive(false);
            workshop_Lvl2_L2_Up_5.SetActive(true); DiplayUiStats();
        }
    }
    #endregion
    // LIVING IS LEVEL 3 RIGHT SIDE
    #region Unlock LivingSpace 1 & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_LivingSpace_Building_1()
    {
        if (!GC.LivingSpace_Lvl3_R1) { Unlock_LivingSpace_1(); }
        else
        {
            switch (GC.LivingSpace_Upg_Lvl3_R1)
            {
                case 1:
                    Buy_Up_To_2_LivingSpace_1();
                    break;
                case 2:
                    Buy_Up_To_3_LivingSpace_1();
                    break;
                case 3:
                    Buy_Up_To_4_LivingSpace_1();
                    break;
                case 4:
                    Buy_Up_To_5_LivingSpace_1();
                    break;
                case 5:
                    // ui message max level
                    break;
            }
        }
    }
    private void Unlock_LivingSpace_1()
    {
        if (GC.Stairs_3 && GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);// purchaseValue is 250
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.LivingSpace_Lvl3_R1 = true;
            GC.LivingSpace_Upg_Lvl3_R1 = 1;
            livingSpace_Lvl3_R1_Def.SetActive(false);
            livingSpace_Lvl3_R1_Up_1.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_2_LivingSpace_1()
    {
        if (GC.Player_Metal >= purchaseValue && GC.Player_Wood >= purchaseValue && GC.Player_Tech >= purchaseValue)
        {
            GC.Player_Metal -= purchaseValue;
            GC.Player_Wood -= purchaseValue;
            GC.Player_Tech -= purchaseValue;
            GC.LivingSpace_Upg_Lvl3_R1 = 2;
            livingSpace_Lvl3_R1_Up_1.SetActive(false);
            livingSpace_Lvl3_R1_Up_2.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_3_LivingSpace_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.LivingSpace_Upg_Lvl3_R1 = 3;
            livingSpace_Lvl3_R1_Up_2.SetActive(false);
            livingSpace_Lvl3_R1_Up_3.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_4_LivingSpace_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.LivingSpace_Upg_Lvl3_R1 = 4;
            livingSpace_Lvl3_R1_Up_3.SetActive(false);
            livingSpace_Lvl3_R1_Up_4.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_5_LivingSpace_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.LivingSpace_Upg_Lvl3_R1 = 5;
            livingSpace_Lvl3_R1_Up_4.SetActive(false);
            livingSpace_Lvl3_R1_Up_5.SetActive(true); DiplayUiStats();
        }
    }
    #endregion
    #region Unlock LivingSpace 2 & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_LivingSpace_Building_2()
    {
        if (!GC.LivingSpace_Lvl3_R2) { Unlock_LivingSpace_2(); }
        else
        {
            switch (GC.LivingSpace_Upg_Lvl3_R2)
            {
                case 1:
                    Buy_Up_To_2_LivingSpace_2();
                    break;
                case 2:
                    Buy_Up_To_3_LivingSpace_2();
                    break;
                case 3:
                    Buy_Up_To_4_LivingSpace_2();
                    break;
                case 4:
                    Buy_Up_To_5_LivingSpace_2();
                    break;
                case 5:
                    // ui message max level
                    break;
            }
        }
    }
    private void Unlock_LivingSpace_2()
    {
        if (GC.LivingSpace_Lvl3_R1 && GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);// purchaseValue is 250
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.LivingSpace_Lvl3_R2 = true;
            GC.LivingSpace_Upg_Lvl3_R2 = 1;
            livingSpace_Lvl3_R2_Def.SetActive(false);
            livingSpace_Lvl3_R2_Up_1.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_2_LivingSpace_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.LivingSpace_Upg_Lvl3_R2 = 2;
            livingSpace_Lvl3_R2_Up_1.SetActive(false);
            livingSpace_Lvl3_R2_Up_2.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_3_LivingSpace_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.LivingSpace_Upg_Lvl3_R2 = 3;
            livingSpace_Lvl3_R2_Up_2.SetActive(false);
            livingSpace_Lvl3_R2_Up_3.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_4_LivingSpace_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.LivingSpace_Upg_Lvl3_R2 = 4;
            livingSpace_Lvl3_R2_Up_3.SetActive(false);
            livingSpace_Lvl3_R2_Up_4.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_5_LivingSpace_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.LivingSpace_Upg_Lvl3_R2 = 5;
            livingSpace_Lvl3_R2_Up_4.SetActive(false);
            livingSpace_Lvl3_R2_Up_5.SetActive(true); DiplayUiStats();
        }
    }
    #endregion
    // RESEARCH IS LEVEL 3 LEFT SIDE
    #region Unlock Research 1 & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Research_Building_1()
    {
        if (!GC.Research_Lvl3_L1) { Unlock_Research_1(); }
        else
        {
            switch (GC.Research_Upg_Lvl3_L1)
            {
                case 1:
                    Buy_Up_To_2_Research_1();
                    break;
                case 2:
                    Buy_Up_To_3_Research_1();
                    break;
                case 3:
                    Buy_Up_To_4_Research_1();
                    break;
                case 4:
                    Buy_Up_To_5_Research_1();
                    break;
                case 5:
                    // ui display max level
                    break;
            }
        }
    }
    private void Unlock_Research_1()
    {
        if (GC.Stairs_3 && GC.Player_Metal >= (purchaseValue*2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);// purchaseValue is 250
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Research_Lvl3_L1 = true;
            GC.Research_Upg_Lvl3_L1 = 1;
            research_Lvl3_L1_Def.SetActive(false);
            research_Lvl3_L1_Up_1.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_2_Research_1()
    {
        if (GC.Player_Metal >= purchaseValue && GC.Player_Wood >= purchaseValue && GC.Player_Tech >= purchaseValue)
        {
            GC.Player_Metal -= purchaseValue;
            GC.Player_Wood -= purchaseValue;
            GC.Player_Tech -= purchaseValue;
            GC.Research_Upg_Lvl3_L1 = 2;
            research_Lvl3_L1_Up_1.SetActive(false);
            research_Lvl3_L1_Up_2.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_3_Research_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Research_Upg_Lvl3_L1 = 3;
            research_Lvl3_L1_Up_2.SetActive(false);
            research_Lvl3_L1_Up_3.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_4_Research_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Research_Upg_Lvl3_L1 = 4;
            research_Lvl3_L1_Up_3.SetActive(false);
            research_Lvl3_L1_Up_4.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_5_Research_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Research_Upg_Lvl3_L1 = 5;
            research_Lvl3_L1_Up_4.SetActive(false);
            research_Lvl3_L1_Up_5.SetActive(true); DiplayUiStats();
        }
    }
    #endregion
    #region Unlock Research 2 & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Research_Building_2()
    {
        if (!GC.Research_Lvl3_L2) { Unlock_Research_2(); }
        else
        {
            switch (GC.Research_Upg_Lvl3_L2)
            {
                case 1:
                    Buy_Up_To_2_Research_2();
                    break;
                case 2:
                    Buy_Up_to_3_Research_2();
                    break;
                case 3:
                    Buy_Up_To_4_Research_2();
                    break;
                case 4:
                    Buy_Up_To_5_Research_2();
                    break;
                case 5:
                    // Flag Up UI Max Level
                    break;
            }
        }
    }
    private void Unlock_Research_2()
    {
        if (GC.Research_Lvl3_L1 && GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);// purchaseValue is 250
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Research_Lvl3_L2 = true;
            GC.Research_Upg_Lvl3_L2 = 1;
            research_Lvl3_L1_Up_1.SetActive(true); research_Lvl3_L2_Def.SetActive(false); DiplayUiStats();
        }
    }
    private void Buy_Up_To_2_Research_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Research_Upg_Lvl3_L2 = 2;
            research_Lvl3_L2_Up_1.SetActive(false);
            research_Lvl3_L2_Up_2.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_to_3_Research_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Research_Upg_Lvl3_L2 = 3;
            research_Lvl3_L2_Up_2.SetActive(false);
            research_Lvl3_L2_Up_3.SetActive(true); DiplayUiStats(); 
        }
    }
    private void Buy_Up_To_4_Research_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Research_Upg_Lvl3_L2 = 4;
            research_Lvl3_L2_Up_3.SetActive(false);
            research_Lvl3_L2_Up_4.SetActive(true); DiplayUiStats(); 
        }
    }
    private void Buy_Up_To_5_Research_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.Research_Upg_Lvl3_L2 = 5;
            research_Lvl3_L2_Up_4.SetActive(false);
            research_Lvl3_L2_Up_5.SetActive(true); DiplayUiStats(); 
        }
    }
    #endregion
    // WALL LEFT UNLOCK
    #region Unlock Wall L & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Wall_L()
    {
        if (!GC.Wall_L) { Unlock_Wall_L(); }
        else
        {
            switch (GC.Wall_L_Upg)
            {
                case 1:
                    Buy_Up_To_2_Wall_L();
                    break;
                case 2:
                    Buy_Up_To_3_Wall_L();
                    break;
                case 3:
                    Buy_Up_To_4_Wall_L();
                    break;
                case 4:
                    Buy_Up_To_5_Wall_L();
                    break;
                case 5:
                    Buy_Up_To_6_Wall_L();
                    break;
                case 6:
                    Buy_Up_To_7_Wall_L();
                    break;
                case 7:
                    Buy_Up_To_8_Wall_L();
                    break;
                case 8:
                    Buy_Up_To_9_Wall_L();
                    break;
                case 9:
                    Buy_Up_To_10_Wall_L();
                    break;
                case 10:
                    //Buy_Up_10_Wall_R();
                    break;
            }
        }
    }
    private void Unlock_Wall_L()
    {
        if (GC.Wall_L_Clik_Unlock >= 50)
        {
            GC.Wall_L_Clik_Unlock = 0;
            GC.Wall_L = true;
            GC.Wall_L_Upg = 1;
            wall_Left_None.SetActive(false);
            wall_Left_Up_1.SetActive(true); DiplayUiStats(); 
        }
    }
    private void Buy_Up_To_2_Wall_L()
    {
        if (GC.Wall_L_Clik_Unlock >= 25)
        {
            GC.Wall_L_Clik_Unlock -=25;
            GC.Wall_L_Upg = 2;
            wall_Left_Up_1.SetActive(false);
            wall_Left_Up_2.SetActive(true); DiplayUiStats(); 
        }
    }
    private void Buy_Up_To_3_Wall_L()
    {
        if (GC.Wall_L_Clik_Unlock >= 50)
        {
            GC.Wall_L_Clik_Unlock -=50;
            GC.Wall_L_Upg = 3;
            wall_Left_Up_2.SetActive(false);
            wall_Left_Up_3.SetActive(true); DiplayUiStats(); 
        }
    }
    private void Buy_Up_To_4_Wall_L()
    {
        if (GC.Wall_L_Clik_Unlock >= 75)
        {
            GC.Wall_L_Clik_Unlock -= 75;
            GC.Wall_L_Upg = 4;
            wall_Left_Up_3.SetActive(false);
            wall_Left_Up_4.SetActive(true); DiplayUiStats(); 
        }
    }
    private void Buy_Up_To_5_Wall_L()
    {
        if (GC.Wall_L_Clik_Unlock >= 100)
        {
            GC.Wall_L_Clik_Unlock -=100;
            GC.Wall_L_Upg = 5;
            wall_Left_Up_4.SetActive(false);
            wall_Left_Up_5.SetActive(true); DiplayUiStats(); 
        }
    }
    private void Buy_Up_To_6_Wall_L()
    {
        if (GC.Wall_L_Clik_Unlock >= 125)
        {
            GC.Wall_L_Clik_Unlock -=125;
            GC.Wall_L_Upg = 6;
            wall_Left_Up_5.SetActive(false);
            wall_Left_Up_6.SetActive(true); DiplayUiStats(); 
        }
    }
    private void Buy_Up_To_7_Wall_L()
    {
        if (GC.Wall_L_Clik_Unlock >= 150)
        {
            GC.Wall_L_Clik_Unlock -=150;
            GC.Wall_L_Upg = 7;
            wall_Left_Up_6.SetActive(false);
            wall_Left_Up_7.SetActive(true); DiplayUiStats(); 
        }
    }
    private void Buy_Up_To_8_Wall_L()
    {
        if (GC.Wall_L_Clik_Unlock >= 175)
        {
            GC.Wall_L_Clik_Unlock -=175;
            GC.Wall_L_Upg = 8;
            wall_Left_Up_7.SetActive(false);
            wall_Left_Up_8.SetActive(true); DiplayUiStats(); 
        }
    }
    private void Buy_Up_To_9_Wall_L()
    {
        if (GC.Wall_L_Clik_Unlock >= 200)
        {
            GC.Wall_L_Clik_Unlock -=200;
            GC.Wall_L_Upg = 9;
            wall_Left_Up_8.SetActive(false);
            wall_Left_Up_9.SetActive(true); DiplayUiStats(); 
        }
    }
    private void Buy_Up_To_10_Wall_L()
    {
        if (GC.Wall_L_Clik_Unlock >= 225)
        {
            GC.Wall_L_Clik_Unlock -=225;
            GC.Wall_L_Upg = 10;
            wall_Left_Up_9.SetActive(false);
            wall_Left_Up_10.SetActive(true); DiplayUiStats(); 
        }
    }
    /*private void Buy_Up_10_Bedroom_Lvl1_R()
    {
        if (GC.Wall_R_Clik_Unlock >= 250)
        {
            GC.Wall_R_Clik_Unlock = 0;
            GC.Wall_R_Upg = 10;
            wall_Left_Up_10.SetActive(false);
            wall_Left_Up_11.SetActive(true); DiplayUiStats(); 
        }
    }*/
    #endregion
    // WALL RIGHT UNLOCK
    #region Unlock Wall R & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Wall_R()
    {
        if (!GC.Wall_R) { Unlock_Up_1_Wall_R(); }
        else
        {
            switch (GC.Wall_R_Upg)
            {
                case 1:
                    Buy_Up_To_2_Wall_R();
                    break;
                case 2:
                    Buy_Up_To_3_Wall_R();
                    break;
                case 3:
                    Buy_Up_To_4_Wall_R();
                    break;
                case 4:
                    Buy_Up_To_5_Wall_R();
                    break;
                case 5:
                    Buy_Up_To_6_Wall_R();
                    break;
                case 6:
                    Buy_Up_To_7_Wall_R();
                    break;
                case 7:
                    Buy_Up_To_8_Wall_R();
                    break;
                case 8:
                    Buy_Up_To_9_Wall_R();
                    break;
                case 9:
                    Buy_Up_To_10_Wall_R();
                    break;
                case 10:
                    //Buy_Up_10_Wall_R();
                    break;
            }
        }
    }
    private void Unlock_Up_1_Wall_R()
    {
        if (GC.Wall_R_Clik_Unlock >= 50)
        {
            GC.Wall_R_Clik_Unlock -= 50;
            GC.Wall_R = true;
            GC.Wall_R_Upg = 1;
            wall_Right_None.SetActive(false);
            wall_Right_Up_1.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_2_Wall_R()
    {
        if (GC.Wall_R_Clik_Unlock >= 25)
        {
            GC.Wall_R_Clik_Unlock -=25;
            GC.Wall_R_Upg = 2;
            wall_Right_Up_1.SetActive(false);
            wall_Right_Up_2.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_3_Wall_R()
    {
        if (GC.Wall_R_Clik_Unlock >= 50)
        {
            GC.Wall_R_Clik_Unlock -=50;
            GC.Wall_R_Upg = 3;
            wall_Right_Up_2.SetActive(false);
            wall_Right_Up_3.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_4_Wall_R()
    {
        if (GC.Wall_R_Clik_Unlock >= 75)
        {
            GC.Wall_R_Clik_Unlock -=75;
            GC.Wall_R_Upg = 4;
            wall_Right_Up_3.SetActive(false);
            wall_Right_Up_4.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_5_Wall_R()
    {
        if (GC.Wall_R_Clik_Unlock >= 100)
        {
            GC.Wall_R_Clik_Unlock -=100;
            GC.Wall_R_Upg = 5;
            wall_Right_Up_4.SetActive(false);
            wall_Right_Up_5.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_6_Wall_R()
    {
        if (GC.Wall_R_Clik_Unlock >= 125)
        {
            GC.Wall_R_Clik_Unlock -=125;
            GC.Wall_R_Upg = 6;
            wall_Right_Up_5.SetActive(false);
            wall_Right_Up_6.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_7_Wall_R()
    {
        if (GC.Wall_R_Clik_Unlock >= 150)
        {
            GC.Wall_R_Clik_Unlock -=150;
            GC.Wall_R_Upg = 7;
            wall_Right_Up_6.SetActive(false);
            wall_Right_Up_7.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_8_Wall_R()
    {
        if (GC.Wall_R_Clik_Unlock >= 175)
        {
            GC.Wall_R_Clik_Unlock -=175;
            GC.Wall_R_Upg = 8;
            wall_Right_Up_7.SetActive(false);
            wall_Right_Up_8.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_9_Wall_R()
    {
        if (GC.Wall_R_Clik_Unlock >= 200)
        {
            GC.Wall_R_Clik_Unlock -=200;
            GC.Wall_R_Upg = 9;
            wall_Right_Up_8.SetActive(false);
            wall_Right_Up_9.SetActive(true); DiplayUiStats();
        }
    }
    private void Buy_Up_To_10_Wall_R()
    {
        if (GC.Wall_R_Clik_Unlock >= 225)
        {
            GC.Wall_R_Clik_Unlock -=225;
            GC.Wall_R_Upg = 10;
            wall_Right_Up_9.SetActive(false);
            wall_Right_Up_10.SetActive(true); DiplayUiStats(); 
        }
    }
    /*private void Buy_Up_10_Bedroom_Lvl1_R()
    {
        if (GC.Wall_R_Clik_Unlock >= 250)
        {
            GC.Wall_R_Clik_Unlock = 0;
            GC.Wall_R_Upg = 10;
            wall_Left_Up_10.SetActive(false);
            wall_Left_Up_11.SetActive(true); DiplayUiStats(); 
        }
    }*/
    #endregion
    #endregion


    #region Set game after load checks
    #region Check Buildings & Upgrades
    // BEDROOM LVL1 LEFT UNLOCK
    #region Check Unlock Bedroom Lvl1 L & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Check_Upgrade_Bedroom_Lvl1_L()
    {
        if (GC.Bedroom_Lvl1_L) { 
            switch (GC.Bedroom_Upg_Lvl1_L)
            {
                case 1:
                    Check_1_Bedroom_Lvl1_L();
                    break;
                case 2:
                    Check_2_Bedroom_Lvl1_L();
                    break;
                case 3:
                    Check_3_Bedroom_Lvl1_L();
                    break;
                case 4:
                    Check_4_Bedroom_Lvl1_L();
                    break;
                case 5:
                    Check_5_Bedroom_Lvl1_L();
                    break;
                case 6:
                    Check_6_Bedroom_Lvl1_L();
                    break;
                case 7:
                    Check_7_Bedroom_Lvl1_L();
                    break;
                case 8:
                    Check_8_Bedroom_Lvl1_L();
                    break;
                case 9:
                    Check_9_Bedroom_Lvl1_L();
                    break;
                case 10:
                    Check_10_Bedroom_Lvl1_L();
                    break;
            }
        }
        else { Check_Locked_Bedroom_Lvl1_L(); }
    }
    private void Check_Locked_Bedroom_Lvl1_L()
    {
        bedroom_Lvl1_L_Rock.SetActive(true); DiplayUiStats();
    }
    private void Check_1_Bedroom_Lvl1_L()
    {
        bedroom_Lvl1_L_Rock.SetActive(false);
        bedroom_Lvl1_L_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_2_Bedroom_Lvl1_L()
    {
        bedroom_Lvl1_L_Up_1.SetActive(false);
        bedroom_Lvl1_L_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_3_Bedroom_Lvl1_L()
    {
        bedroom_Lvl1_L_Up_2.SetActive(false);
        bedroom_Lvl1_L_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_4_Bedroom_Lvl1_L()
    {
        bedroom_Lvl1_L_Up_3.SetActive(false);
        bedroom_Lvl1_L_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_5_Bedroom_Lvl1_L()
    {
        bedroom_Lvl1_L_Up_4.SetActive(false);
        bedroom_Lvl1_L_Up_5.SetActive(true); DiplayUiStats();
    }
    private void Check_6_Bedroom_Lvl1_L()
    {
        bedroom_Lvl1_L_Up_5.SetActive(false);
        bedroom_Lvl1_L_Up_6.SetActive(true); DiplayUiStats();
    }
    private void Check_7_Bedroom_Lvl1_L()
    {
        bedroom_Lvl1_L_Up_6.SetActive(false);
        bedroom_Lvl1_L_Up_7.SetActive(true); DiplayUiStats();
    }
    private void Check_8_Bedroom_Lvl1_L()
    {
        bedroom_Lvl1_L_Up_7.SetActive(false);
        bedroom_Lvl1_L_Up_8.SetActive(true); DiplayUiStats();
    }
    private void Check_9_Bedroom_Lvl1_L()
    {
        bedroom_Lvl1_L_Up_8.SetActive(false);
        bedroom_Lvl1_L_Up_9.SetActive(true); DiplayUiStats();
    }
    private void Check_10_Bedroom_Lvl1_L()
    {
        bedroom_Lvl1_L_Up_9.SetActive(false);
        bedroom_Lvl1_L_Up_10.SetActive(true); DiplayUiStats();
    }
    #endregion
    // BEDROOM LVL1 RIGHT UNLOCK
    #region Check Unlock Bedroom Lvl1 R & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Check_Upgrade_Bedroom_Lvl1_R()
    {
        if (GC.Bedroom_Lvl1_R) { 
            switch (GC.Bedroom_Upg_Lvl1_R)
            {
                case 1:
                    Check_1_Bedroom_Lvl1_R();
                    break;
                case 2:
                    Check_2_Bedroom_Lvl1_R();
                    break;
                case 3:
                    Check_3_Bedroom_Lvl1_R();
                    break;
                case 4:
                    Check_4_Bedroom_Lvl1_R();
                    break;
                case 5:
                    Check_5_Bedroom_Lvl1_R();
                    break;
                case 6:
                    Check_6_Bedroom_Lvl1_R();
                    break;
                case 7:
                    Check_7_Bedroom_Lvl1_R();
                    break;
                case 8:
                    Check_8_Bedroom_Lvl1_R();
                    break;
                case 9:
                    Check_9_Bedroom_Lvl1_R();
                    break;
                case 10:
                    Check_10_Bedroom_Lvl1_R();
                    break;
            }
        }
        else { Check_Locked_Bedroom_Lvl1_R(); }
    }
    private void Check_Locked_Bedroom_Lvl1_R()
    {
        bedroom_Lvl1_R_Rock.SetActive(true); DiplayUiStats();
    }
    private void Check_1_Bedroom_Lvl1_R()
    {
        bedroom_Lvl1_R_Rock.SetActive(false);
        bedroom_Lvl1_R_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_2_Bedroom_Lvl1_R()
    {
        bedroom_Lvl1_R_Up_1.SetActive(false);
        bedroom_Lvl1_R_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_3_Bedroom_Lvl1_R()
    {
        bedroom_Lvl1_R_Up_2.SetActive(false);
        bedroom_Lvl1_R_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_4_Bedroom_Lvl1_R()
    {
        bedroom_Lvl1_R_Up_3.SetActive(false);
        bedroom_Lvl1_R_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_5_Bedroom_Lvl1_R()
    {
        bedroom_Lvl1_R_Up_4.SetActive(false);
        bedroom_Lvl1_R_Up_5.SetActive(true); DiplayUiStats();
    }
    private void Check_6_Bedroom_Lvl1_R()
    {
        bedroom_Lvl1_R_Up_5.SetActive(false);
        bedroom_Lvl1_R_Up_6.SetActive(true); DiplayUiStats();
    }
    private void Check_7_Bedroom_Lvl1_R()
    {
        bedroom_Lvl1_R_Up_6.SetActive(false);
        bedroom_Lvl1_R_Up_7.SetActive(true); DiplayUiStats();
    }
    private void Check_8_Bedroom_Lvl1_R()
    {
        bedroom_Lvl1_R_Up_7.SetActive(false);
        bedroom_Lvl1_R_Up_8.SetActive(true); DiplayUiStats();
    }
    private void Check_9_Bedroom_Lvl1_R()
    {
        bedroom_Lvl1_R_Up_8.SetActive(false);
        bedroom_Lvl1_R_Up_9.SetActive(true); DiplayUiStats();
    }
    private void Check_10_Bedroom_Lvl1_R()
    {
        bedroom_Lvl1_R_Up_9.SetActive(false);
        bedroom_Lvl1_R_Up_10.SetActive(true); DiplayUiStats();
    }
    #endregion
    // BEDROOM LVL2 LEFT UNLOCK
    #region Check Unlock Bedroom Lvl2 L & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Check_Upgrade_Bedroom_Lvl2_L()
    {
        if (GC.Bedroom_Lvl2_L) { 
            switch (GC.Bedroom_Upg_Lvl2_L)
            {
                case 1:
                    Check_1_Bedroom_Lvl2_L();
                    break;
                case 2:
                    Check_2_Bedroom_Lvl2_L();
                    break;
                case 3:
                    Check_3_Bedroom_Lvl2_L();
                    break;
                case 4:
                    Check_4_Bedroom_Lvl2_L();
                    break;
                case 5:
                    Check_5_Bedroom_Lvl2_L();
                    break;
                case 6:
                    Check_6_Bedroom_Lvl2_L();
                    break;
                case 7:
                    Check_7_Bedroom_Lvl2_L();
                    break;
                case 8:
                    Check_8_Bedroom_Lvl2_L();
                    break;
                case 9:
                    Check_9_Bedroom_Lvl2_L();
                    break;
                case 10:
                    Check_10_Bedroom_Lvl2_L();
                    break;
            }
        }
        else { Check_Locked_Bedroom_Lvl2_L(); }
    }
    private void Check_Locked_Bedroom_Lvl2_L()
    {
        bedroom_Lvl2_L_Rock.SetActive(true); DiplayUiStats();
    }
    private void Check_1_Bedroom_Lvl2_L()
    {
        bedroom_Lvl2_L_Rock.SetActive(false);
        bedroom_Lvl2_L_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_2_Bedroom_Lvl2_L()
    {
        bedroom_Lvl2_L_Up_1.SetActive(false);
        bedroom_Lvl2_L_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_3_Bedroom_Lvl2_L()
    {
        bedroom_Lvl2_L_Up_2.SetActive(false);
        bedroom_Lvl2_L_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_4_Bedroom_Lvl2_L()
    {
        bedroom_Lvl2_L_Up_3.SetActive(false);
        bedroom_Lvl2_L_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_5_Bedroom_Lvl2_L()
    {
        bedroom_Lvl2_L_Up_4.SetActive(false);
        bedroom_Lvl2_L_Up_5.SetActive(true); DiplayUiStats();
    }
    private void Check_6_Bedroom_Lvl2_L()
    {
        bedroom_Lvl2_L_Up_5.SetActive(false);
        bedroom_Lvl2_L_Up_6.SetActive(true); DiplayUiStats();
    }
    private void Check_7_Bedroom_Lvl2_L()
    {
        bedroom_Lvl2_L_Up_6.SetActive(false);
        bedroom_Lvl2_L_Up_7.SetActive(true); DiplayUiStats();
    }
    private void Check_8_Bedroom_Lvl2_L()
    {
        bedroom_Lvl2_L_Up_7.SetActive(false);
        bedroom_Lvl2_L_Up_8.SetActive(true); DiplayUiStats();
    }
    private void Check_9_Bedroom_Lvl2_L()
    {
        bedroom_Lvl2_L_Up_8.SetActive(false);
        bedroom_Lvl2_L_Up_9.SetActive(true); DiplayUiStats();
    }
    private void Check_10_Bedroom_Lvl2_L()
    {
        bedroom_Lvl2_L_Up_9.SetActive(false);
        bedroom_Lvl2_L_Up_10.SetActive(true); DiplayUiStats();
    }
    #endregion
    // BEDROOM LVL2 RIGHT UNLOCK
    #region Check Unlock Bedroom Lvl2 R & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Check_Upgrade_Bedroom_Lvl2_R()
    {
        if (GC.Bedroom_Lvl2_R) { 
            switch (GC.Bedroom_Upg_Lvl2_R)
            {
                case 1:
                    Check_1_Bedroom_Lvl2_R();
                    break;
                case 2:
                    Check_2_Bedroom_Lvl2_R();
                    break;
                case 3:
                    Check_3_Bedroom_Lvl2_R();
                    break;
                case 4:
                    Check_4_Bedroom_Lvl2_R();
                    break;
                case 5:
                    Check_5_Bedroom_Lvl2_R();
                    break;
                case 6:
                    Check_6_Bedroom_Lvl2_R();
                    break;
                case 7:
                    Check_7_Bedroom_Lvl2_R();
                    break;
                case 8:
                    Check_8_Bedroom_Lvl2_R();
                    break;
                case 9:
                    Check_9_Bedroom_Lvl2_R();
                    break;
                case 10:
                    Check_10_Bedroom_Lvl2_R();
                    break;
            }
        }
        else { Check_Locked_Bedroom_Lvl2_R(); }
    }
    private void Check_Locked_Bedroom_Lvl2_R()
    {
        bedroom_Lvl2_R_Rock.SetActive(true); DiplayUiStats();
    }
    private void Check_1_Bedroom_Lvl2_R()
    {
        bedroom_Lvl2_R_Rock.SetActive(false);
        bedroom_Lvl2_R_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_2_Bedroom_Lvl2_R()
    {
        bedroom_Lvl2_R_Up_1.SetActive(false);
        bedroom_Lvl2_R_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_3_Bedroom_Lvl2_R()
    {
        bedroom_Lvl2_R_Up_2.SetActive(false);
        bedroom_Lvl2_R_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_4_Bedroom_Lvl2_R()
    {
        bedroom_Lvl2_R_Up_3.SetActive(false);
        bedroom_Lvl2_R_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_5_Bedroom_Lvl2_R()
    {
        bedroom_Lvl2_R_Up_4.SetActive(false);
        bedroom_Lvl2_R_Up_5.SetActive(true); DiplayUiStats();
    }
    private void Check_6_Bedroom_Lvl2_R()
    {
        bedroom_Lvl2_R_Up_5.SetActive(false);
        bedroom_Lvl2_R_Up_6.SetActive(true); DiplayUiStats();
    }
    private void Check_7_Bedroom_Lvl2_R()
    {
        bedroom_Lvl2_R_Up_6.SetActive(false);
        bedroom_Lvl2_R_Up_7.SetActive(true); DiplayUiStats();
    }
    private void Check_8_Bedroom_Lvl2_R()
    {
        bedroom_Lvl2_R_Up_7.SetActive(false);
        bedroom_Lvl2_R_Up_8.SetActive(true); DiplayUiStats();
    }
    private void Check_9_Bedroom_Lvl2_R()
    {
        bedroom_Lvl2_R_Up_8.SetActive(false);
        bedroom_Lvl2_R_Up_9.SetActive(true); DiplayUiStats();
    }
    private void Check_10_Bedroom_Lvl2_R()
    {
        bedroom_Lvl2_R_Up_9.SetActive(false);
        bedroom_Lvl2_R_Up_10.SetActive(true); DiplayUiStats();
    }
    #endregion
    // BEDROOM LVL3 LEFT UNLOCK
    #region Check Unlock Bedroom Lvl3 L & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Check_Upgrade_Bedroom_Lvl3_L()
    {
        if (GC.Bedroom_Lvl3_L) { 
            switch (GC.Bedroom_Upg_Lvl3_L)
            {
                case 1:
                    Check_1_Bedroom_Lvl3_L();
                    break;
                case 2:
                    Check_2_Bedroom_Lvl3_L();
                    break;
                case 3:
                    Check_3_Bedroom_Lvl3_L();
                    break;
                case 4:
                    Check_4_Bedroom_Lvl3_L();
                    break;
                case 5:
                    Check_5_Bedroom_Lvl3_L();
                    break;
                case 6:
                    Check_6_Bedroom_Lvl3_L();
                    break;
                case 7:
                    Check_7_Bedroom_Lvl3_L();
                    break;
                case 8:
                    Check_8_Bedroom_Lvl3_L();
                    break;
                case 9:
                    Check_9_Bedroom_Lvl3_L();
                    break;
                case 10:
                    Check_10_Bedroom_Lvl3_L();
                    break;
            }
        }
        else { Check_Locked_Bedroom_Lvl3_L(); }
    }
    private void Check_Locked_Bedroom_Lvl3_L()
    {
        bedroom_Lvl3_L_Rock.SetActive(true); DiplayUiStats();
    }
    private void Check_1_Bedroom_Lvl3_L()
    {
        bedroom_Lvl3_L_Rock.SetActive(false);
        bedroom_Lvl3_L_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_2_Bedroom_Lvl3_L()
    {
        bedroom_Lvl3_L_Up_1.SetActive(false);
        bedroom_Lvl3_L_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_3_Bedroom_Lvl3_L()
    {
        bedroom_Lvl3_L_Up_2.SetActive(false);
        bedroom_Lvl3_L_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_4_Bedroom_Lvl3_L()
    {
        bedroom_Lvl3_L_Up_3.SetActive(false);
        bedroom_Lvl3_L_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_5_Bedroom_Lvl3_L()
    {
        bedroom_Lvl3_L_Up_4.SetActive(false);
        bedroom_Lvl3_L_Up_5.SetActive(true); DiplayUiStats();
    }
    private void Check_6_Bedroom_Lvl3_L()
    {
        bedroom_Lvl3_L_Up_5.SetActive(false);
        bedroom_Lvl3_L_Up_6.SetActive(true); DiplayUiStats();
    }
    private void Check_7_Bedroom_Lvl3_L()
    {
        bedroom_Lvl3_L_Up_6.SetActive(false);
        bedroom_Lvl3_L_Up_7.SetActive(true); DiplayUiStats();
    }
    private void Check_8_Bedroom_Lvl3_L()
    {
        bedroom_Lvl3_L_Up_7.SetActive(false);
        bedroom_Lvl3_L_Up_8.SetActive(true); DiplayUiStats();
    }
    private void Check_9_Bedroom_Lvl3_L()
    {
        bedroom_Lvl3_L_Up_8.SetActive(false);
        bedroom_Lvl3_L_Up_9.SetActive(true); DiplayUiStats();
    }
    private void Check_10_Bedroom_Lvl3_L()
    {
        bedroom_Lvl3_L_Up_9.SetActive(false);
        bedroom_Lvl3_L_Up_10.SetActive(true); DiplayUiStats();
    }
    #endregion
    // BEDROOM LVL3 RIGHT UNLOCK
    #region Check Unlock Bedroom Lvl3 R & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Check_Upgrade_Bedroom_Lvl3_R()
    {
        if (GC.Bedroom_Lvl3_R) { 
            switch (GC.Bedroom_Upg_Lvl3_R)
            {
                case 1:
                    Check_1_Bedroom_Lvl3_R();
                    break;
                case 2:
                    Check_2_Bedroom_Lvl3_R();
                    break;
                case 3:
                    Check_3_Bedroom_Lvl3_R();
                    break;
                case 4:
                    Check_4_Bedroom_Lvl3_R();
                    break;
                case 5:
                    Check_5_Bedroom_Lvl3_R();
                    break;
                case 6:
                    Check_6_Bedroom_Lvl3_R();
                    break;
                case 7:
                    Check_7_Bedroom_Lvl3_R();
                    break;
                case 8:
                    Check_8_Bedroom_Lvl3_R();
                    break;
                case 9:
                    Check_9_Bedroom_Lvl3_R();
                    break;
                case 10:
                    Check_10_Bedroom_Lvl3_R();
                    break;
            }
        }
        else { Check_Locked_Bedroom_Lvl3_R(); }
    }
    private void Check_Locked_Bedroom_Lvl3_R()
    {
        bedroom_Lvl3_R_Rock.SetActive(true); DiplayUiStats();
    }
    private void Check_1_Bedroom_Lvl3_R()
    {
        bedroom_Lvl3_R_Rock.SetActive(false);
        bedroom_Lvl3_R_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_2_Bedroom_Lvl3_R()
    {
        bedroom_Lvl3_R_Up_1.SetActive(false);
        bedroom_Lvl3_R_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_3_Bedroom_Lvl3_R()
    {
        bedroom_Lvl3_R_Up_2.SetActive(false);
        bedroom_Lvl3_R_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_4_Bedroom_Lvl3_R()
    {
        bedroom_Lvl3_R_Up_3.SetActive(false);
        bedroom_Lvl3_R_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_5_Bedroom_Lvl3_R()
    {
        bedroom_Lvl3_R_Up_4.SetActive(false);
        bedroom_Lvl3_R_Up_5.SetActive(true); DiplayUiStats();
    }
    private void Check_6_Bedroom_Lvl3_R()
    {
        bedroom_Lvl3_R_Up_5.SetActive(false);
        bedroom_Lvl3_R_Up_6.SetActive(true); DiplayUiStats();
    }
    private void Check_7_Bedroom_Lvl3_R()
    {
        bedroom_Lvl3_R_Up_6.SetActive(false);
        bedroom_Lvl3_R_Up_7.SetActive(true); DiplayUiStats();
    }
    private void Check_8_Bedroom_Lvl3_R()
    {
        bedroom_Lvl3_R_Up_7.SetActive(false);
        bedroom_Lvl3_R_Up_8.SetActive(true); DiplayUiStats();
    }
    private void Check_9_Bedroom_Lvl3_R()
    {
        bedroom_Lvl3_R_Up_8.SetActive(false);
        bedroom_Lvl3_R_Up_9.SetActive(true); DiplayUiStats();
    }
    private void Check_10_Bedroom_Lvl3_R()
    {
        bedroom_Lvl3_R_Up_9.SetActive(false);
        bedroom_Lvl3_R_Up_10.SetActive(true); DiplayUiStats();
    }
    #endregion 
    // STAIRS 2 UNLOCK
    #region Check Stairs 2 Unlock
    public void Check_Upgrade_Stairs_2()
    {
        Check_Unlock_Stairs_2();
    }
    private void Check_Unlock_Stairs_2()
    {
        if (GC.Stairs_2)
        {
            stairs_2_Locked.SetActive(false);
            stairs_2_Unlocked.SetActive(true); DiplayUiStats();
        }
        else
        {
            stairs_2_Locked.SetActive(true);
            stairs_2_Unlocked.SetActive(false); DiplayUiStats();
        }
    }
    #endregion
    // STAIRS 3 UNLOCK
    #region Check Stairs 3 Unlock
    public void Check_Upgrade_Stairs_3()
    {
        Check_Unlock_Stairs_3();
    }
    private void Check_Unlock_Stairs_3()
    {
        if (GC.Stairs_3)
        {
            stairs_3_Locked.SetActive(false);
            stairs_3_Unlocked.SetActive(true); DiplayUiStats();
        }
        else
        {
            stairs_3_Locked.SetActive(true);
            stairs_3_Unlocked.SetActive(false); DiplayUiStats();
        }
    }
    #endregion
    // Expedition(1) & Training(2) IS LEVEL 2 RIGHT SIDE
    #region Check Expedition & Upgrades // not figured out the values to spend on unlocks
    /// <summary>
    /// 
    /// </summary>
    public void Check_Upgrade_Expedition_Building()
    {
        switch (GC.Expedition_Upg_Lvl1_R1)
        {
            case 1:
                Check_1_Expedition();
                break;
            case 2:
                Check_2_Expedition();
                break;
            case 3:
                Check_3_Expedition();
                break;
            case 4:
                Check_4_Expedition();
                break;
            case 5:
                Check_5_Expedition();
                break;
        }
    }
    private void Check_1_Expedition()
    {
        expedition_Lvl1_R1_Def.SetActive(false);
        expedition_Lvl1_R1_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_2_Expedition()
    {
        expedition_Lvl1_R1_Up_1.SetActive(false);
        expedition_Lvl1_R1_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_3_Expedition()
    {
        expedition_Lvl1_R1_Up_2.SetActive(false);
        expedition_Lvl1_R1_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_4_Expedition()
    {
        expedition_Lvl1_R1_Up_3.SetActive(false);
        expedition_Lvl1_R1_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_5_Expedition()
    {
        expedition_Lvl1_R1_Up_4.SetActive(false);
        expedition_Lvl1_R1_Up_5.SetActive(true); DiplayUiStats();
    }
    #endregion
    #region Check Training & Upgrades // not figured out the values to spend on unlocks
    /// <summary>
    /// 
    /// </summary>
    public void Check_Upgrade_Training_Building()
    {
        switch (GC.Training_Upg_Lvl1_R2)
        {
            case 1:
                Check_1_Training();
                break;
            case 2:
                Check_2_Training();
                break;
            case 3:
                Check_3_Training();
                break;
            case 4:
                Check_4_Training();
                break;
            case 5:
                Check_5_Training();
                break;
        }
    }
    private void Check_1_Training()
    {
        training_Lvl1_R2_Def.SetActive(false);
        training_Lvl1_R2_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_2_Training()
    {
        training_Lvl1_R2_Up_1.SetActive(false);
        training_Lvl1_R2_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_3_Training()
    {
        training_Lvl1_R2_Up_2.SetActive(false);
        training_Lvl1_R2_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_4_Training()
    {
        training_Lvl1_R2_Up_3.SetActive(false);
        training_Lvl1_R2_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_5_Training()
    {
        training_Lvl1_R2_Up_4.SetActive(false);
        training_Lvl1_R2_Up_5.SetActive(true); DiplayUiStats();
    }
    #endregion
    // UnderGarden(1) & Radio(2) IS LEVEL 1 LEFT SIDE
    #region  Check UnderGarden & Upgrades // not figured out the values to spend on unlocks
    /// <summary>
    /// 
    /// </summary>
    public void Check_Upgrade_UnderGarden_Building()
    {
        switch (GC.UnderGarden_Upg_Lvl1_L1)
        {
            case 1:
                Check_1_UnderGarden();
                break;
            case 2:
                Check_2_UnderGarden();
                break;
            case 3:
                Check_3_UnderGarden();
                break;
            case 4:
                Check_4_UnderGarden();
                break;
            case 5:
                Check_5_UnderGarden();
                break;
        }
    }
    private void Check_1_UnderGarden()
    {
        underGarden_Lvl1_L1_Def.SetActive(false);
        underGarden_Lvl1_L1_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_2_UnderGarden()
    {
        underGarden_Lvl1_L1_Up_1.SetActive(false);
        underGarden_Lvl1_L1_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_3_UnderGarden()
    {
        underGarden_Lvl1_L1_Up_2.SetActive(false);
        underGarden_Lvl1_L1_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_4_UnderGarden()
    {
        underGarden_Lvl1_L1_Up_3.SetActive(false);
        underGarden_Lvl1_L1_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_5_UnderGarden()
    {
        underGarden_Lvl1_L1_Up_4.SetActive(false);
        underGarden_Lvl1_L1_Up_5.SetActive(true); DiplayUiStats();
    }
    #endregion
    #region Check Radio & Upgrades // not figured out the values to spend on unlocks
    /// <summary>
    /// 
    /// </summary>
    public void Check_Upgrade_Radio_Building()
    {
        switch (GC.Radio_Upg_Lvl1_L2)
        {
            case 1:
                Check_1_Radio();
                break;
            case 2:
                Check_2_Radio();
                break;
            case 3:
                Check_3_Radio();
                break;
            case 4:
                Check_4_Radio();
                break;
            case 5:
                Check_5_Radio();
                break;
        }
    }
    private void Check_1_Radio()
    {
        radio_Lvl1_L2_Def.SetActive(false);
        radio_Lvl1_L2_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_2_Radio()
    {
        radio_Lvl1_L2_Up_1.SetActive(false);
        radio_Lvl1_L2_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_3_Radio()
    {
        radio_Lvl1_L2_Up_2.SetActive(false);
        radio_Lvl1_L2_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_4_Radio()
    {
        radio_Lvl1_L2_Up_3.SetActive(false);
        radio_Lvl1_L2_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_5_Radio()
    {
        radio_Lvl1_L2_Up_4.SetActive(false);
        radio_Lvl1_L2_Up_5.SetActive(true); DiplayUiStats();
    }
    #endregion
    // GENERATOR IS LEVEL 2 RIGHT SIDE
    #region Check Unlock Generator 1 & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Check_Upgrade_Generator_Building_1()
    {
        if (GC.Generator_Lvl2_R1) { 
            switch (GC.Generator_Upg_Lvl2_R1)
            {
                case 1:
                    Check_1_Generator_1();
                    break;
                case 2:
                    Check_2_Generator_1();
                    break;
                case 3:
                    Check_3_Generator_1();
                    break;
                case 4:
                    Check_4_Generator_1();
                    break;
                case 5:
                    Check_5_Generator_1();
                    break;
            }
        }
        else { Check_Locked_Generator_1(); }
    }
    private void Check_Locked_Generator_1()
    {
        generator_Lvl2_R1_Def.SetActive(true); DiplayUiStats();
    }
    private void Check_1_Generator_1()
    {
        generator_Lvl2_R1_Def.SetActive(false);
        generator_Lvl2_R1_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_2_Generator_1()
    {
        generator_Lvl2_R1_Up_1.SetActive(false);
        generator_Lvl2_R1_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_3_Generator_1()
    {
        generator_Lvl2_R1_Up_2.SetActive(false);
        generator_Lvl2_R1_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_4_Generator_1()
    {
        generator_Lvl2_R1_Up_3.SetActive(false);
        generator_Lvl2_R1_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_5_Generator_1()
    {
        generator_Lvl2_R1_Up_4.SetActive(false);
        generator_Lvl2_R1_Up_5.SetActive(true); DiplayUiStats();
    }
    #endregion
    #region Check Unlock Generator 2 & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Check_Upgrade_Generator_Building_2()
    {
        if (GC.Generator_Lvl2_R2) { 
            switch (GC.Generator_Upg_Lvl2_R2)
            {
                case 1:
                    Check_1_Generator_2();
                    break;
                case 2:
                    Check_2_Generator_2();
                    break;
                case 3:
                    Check_3_Generator_2();
                    break;
                case 4:
                    Check_4_Generator_2();
                    break;
                case 5:
                    Check_5_Generator_2();
                    break;
            }
        }
        else { Check_Locked_Generator_2(); }
    }
    private void Check_Locked_Generator_2()
    {
        generator_Lvl2_R2_Def.SetActive(true); DiplayUiStats();
    }
    private void Check_1_Generator_2()
    {
        generator_Lvl2_R2_Def.SetActive(false);
        generator_Lvl2_R2_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_2_Generator_2()
    {
        generator_Lvl2_R2_Up_1.SetActive(false);
        generator_Lvl2_R2_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_3_Generator_2()
    {
        generator_Lvl2_R2_Up_2.SetActive(false);
        generator_Lvl2_R2_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_4_Generator_2()
    {
        generator_Lvl2_R2_Up_3.SetActive(false);
        generator_Lvl2_R2_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_5_Generator_2()
    {
        generator_Lvl2_R2_Up_4.SetActive(false);
        generator_Lvl2_R2_Up_5.SetActive(true); DiplayUiStats();
    }
    #endregion
    // WORKSHOP IS LEVEL 2 LEFT SIDE
    #region Check Unlock Workshop 1 & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Check_Upgrade_Workshop_Building_1()
    {
        if (GC.Workshop_Lvl2_L1) { 
            switch (GC.Workshop_Upg_Lvl2_L1)
            {
                case 1:
                    Check_1_Workshop_1();
                    break;
                case 2:
                    Check_2_Workshop_1();
                    break;
                case 3:
                    Check_3_Workshop_1();
                    break;
                case 4:
                    Check_4_Workshop_1();
                    break;
                case 5:
                    Check_5_Workshop_1();
                    break;
            }
        }
        else { Check_Locked_Workshop_1(); }
    }
    private void Check_Locked_Workshop_1()
    {
        workshop_Lvl2_L1_Def.SetActive(true); DiplayUiStats();
    }
    private void Check_1_Workshop_1()
    {
        workshop_Lvl2_L1_Def.SetActive(false);
        workshop_Lvl2_L1_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_2_Workshop_1()
    {
        workshop_Lvl2_L1_Up_1.SetActive(false);
        workshop_Lvl2_L1_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_3_Workshop_1()
    {
        workshop_Lvl2_L1_Up_2.SetActive(false);
        workshop_Lvl2_L1_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_4_Workshop_1()
    {
        workshop_Lvl2_L1_Up_3.SetActive(false);
        workshop_Lvl2_L1_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_5_Workshop_1()
    {
        workshop_Lvl2_L1_Up_4.SetActive(false);
        workshop_Lvl2_L1_Up_5.SetActive(true); DiplayUiStats();
    }
    #endregion
    #region Check Unlock Workshop 2 & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Check_Upgrade_Workshop_Building_2()
    {
        if (GC.Workshop_Lvl2_L2) { 
            switch (GC.Workshop_Upg_Lvl2_L2)
            {
                case 1:
                    Check_1_Workshop_2();
                    break;
                case 2:
                    Check_2_Workshop_2();
                    break;
                case 3:
                    Check_3_Workshop_2();
                    break;
                case 4:
                    Check_4_Workshop_2();
                    break;
                case 5:
                    Check_5_Workshop_2();
                    break;
            }
        }
        else { Check_Locked_Workshop_2(); }
    }
    private void Check_Locked_Workshop_2()
    {
        workshop_Lvl2_L2_Def.SetActive(true); DiplayUiStats();
    }
    private void Check_1_Workshop_2()
    {
        workshop_Lvl2_L2_Def.SetActive(false);
        workshop_Lvl2_L2_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_2_Workshop_2()
    {
        workshop_Lvl2_L2_Up_1.SetActive(false);
        workshop_Lvl2_L2_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_3_Workshop_2()
    {
        workshop_Lvl2_L2_Up_2.SetActive(false);
        workshop_Lvl2_L2_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_4_Workshop_2()
    {
        workshop_Lvl2_L2_Up_3.SetActive(false);
        workshop_Lvl2_L2_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_5_Workshop_2()
    {
        workshop_Lvl2_L2_Up_4.SetActive(false);
        workshop_Lvl2_L2_Up_5.SetActive(true); DiplayUiStats();
    }
    #endregion
    // LIVING IS LEVEL 3 RIGHT SIDE
    #region Check Unlock LivingSpace 1 & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Check_Upgrade_LivingSpace_Building_1()
    {
        if (GC.LivingSpace_Lvl3_R1) { 
            switch (GC.LivingSpace_Upg_Lvl3_R1)
            {
                case 1:
                    Check_1_LivingSpace_1();
                    break;
                case 2:
                    Check_2_LivingSpace_1();
                    break;
                case 3:
                    Check_3_LivingSpace_1();
                    break;
                case 4:
                    Check_4_LivingSpace_1();
                    break;
                case 5:
                    Check_5_LivingSpace_1();
                    break;
            }
        }
        else { Check_Locked_LivingSpace_1(); }
    }
    private void Check_Locked_LivingSpace_1()
    {
        livingSpace_Lvl3_R1_Def.SetActive(true); DiplayUiStats();
    }
    private void Check_1_LivingSpace_1()
    {
        livingSpace_Lvl3_R1_Def.SetActive(false);
        livingSpace_Lvl3_R1_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_2_LivingSpace_1()
    {
        livingSpace_Lvl3_R1_Up_1.SetActive(false);
        livingSpace_Lvl3_R1_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_3_LivingSpace_1()
    {
        livingSpace_Lvl3_R1_Up_2.SetActive(false);
        livingSpace_Lvl3_R1_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_4_LivingSpace_1()
    {
        livingSpace_Lvl3_R1_Up_3.SetActive(false);
        livingSpace_Lvl3_R1_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_5_LivingSpace_1()
    {
        livingSpace_Lvl3_R1_Up_4.SetActive(false);
        livingSpace_Lvl3_R1_Up_5.SetActive(true); DiplayUiStats();
    }
    #endregion
    #region Check Unlock LivingSpace 2 & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Check_Upgrade_LivingSpace_Building_2()
    {
        if (GC.LivingSpace_Lvl3_R2) { 
            switch (GC.LivingSpace_Upg_Lvl3_R2)
            {
                case 1:
                    Check_1_LivingSpace_2();
                    break;
                case 2:
                    Check_2_LivingSpace_2();
                    break;
                case 3:
                    Check_3_LivingSpace_2();
                    break;
                case 4:
                    Check_4_LivingSpace_2();
                    break;
                case 5:
                    Check_5_LivingSpace_2();
                    break;
            }
        }
        else { Check_Locked_LivingSpace_2(); }
    }
    private void Check_Locked_LivingSpace_2()
    {
        livingSpace_Lvl3_R2_Def.SetActive(true); DiplayUiStats();
    }
    private void Check_1_LivingSpace_2()
    {
        livingSpace_Lvl3_R2_Def.SetActive(false);
        livingSpace_Lvl3_R2_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_2_LivingSpace_2()
    {
        livingSpace_Lvl3_R2_Up_1.SetActive(false);
        livingSpace_Lvl3_R2_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_3_LivingSpace_2()
    {
        livingSpace_Lvl3_R2_Up_2.SetActive(false);
        livingSpace_Lvl3_R2_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_4_LivingSpace_2()
    {
        livingSpace_Lvl3_R2_Up_3.SetActive(false);
        livingSpace_Lvl3_R2_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_5_LivingSpace_2()
    {
        livingSpace_Lvl3_R2_Up_4.SetActive(false);
        livingSpace_Lvl3_R2_Up_5.SetActive(true); DiplayUiStats();
    }
    #endregion
    // RESEARCH IS LEVEL 3 LEFT SIDE
    #region  Check Unlock Research 1 & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Check_Upgrade_Research_Building_1()
    {
        if (GC.Research_Lvl3_L1)
        {
            switch (GC.Research_Upg_Lvl3_L1)
            {
                case 1:
                    Check_1_Research_1();
                    break;
                case 2:
                    Check_2_Research_1();
                    break;
                case 3:
                    Check_3_Research_1();
                    break;
                case 4:
                    Check_4_Research_1();
                    break;
                case 5:
                    Check_5_Research_1();
                    break;
            }
        }
        else { Check_Locked_Research_1(); }
    }
    private void Check_Locked_Research_1()
    {
        research_Lvl3_L1_Def.SetActive(true); DiplayUiStats();
    }
    private void Check_1_Research_1()
    {
        research_Lvl3_L1_Def.SetActive(false);
        research_Lvl3_L1_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_2_Research_1()
    {
        research_Lvl3_L1_Up_1.SetActive(false);
        research_Lvl3_L1_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_3_Research_1()
    {
        research_Lvl3_L1_Up_2.SetActive(false);
        research_Lvl3_L1_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_4_Research_1()
    {
        research_Lvl3_L1_Up_3.SetActive(false);
        research_Lvl3_L1_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_5_Research_1()
    {
        research_Lvl3_L1_Up_4.SetActive(false);
        research_Lvl3_L1_Up_5.SetActive(true); DiplayUiStats();
    }
    #endregion
    #region Check Unlock Research 2 & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Check_Upgrade_Reserach_Building_2()
    {
        if (GC.Research_Lvl3_L2) { 
            switch (GC.Research_Upg_Lvl3_L2)
            {
                case 1:
                    Check_1_Research_2();
                    break;
                case 2:
                    Check_2_Research_2();
                    break;
                case 3:
                    Check_3_Research_2();
                    break;
                case 4:
                    Check_4_Research_2();
                    break;
                case 5:
                    Check_5_Research_2();
                    break;
            }
        }
        else { Check_Locked_Research_2(); }
    }
    private void Check_Locked_Research_2()
    {
        research_Lvl3_L2_Def.SetActive(true); DiplayUiStats();
    }
    private void Check_1_Research_2()
    {
        research_Lvl3_L2_Def.SetActive(false);
        research_Lvl3_L2_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_2_Research_2()
    {
        research_Lvl3_L2_Up_1.SetActive(false);
        research_Lvl3_L2_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_3_Research_2()
    {
        research_Lvl3_L2_Up_2.SetActive(false);
        research_Lvl3_L2_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_4_Research_2()
    {
        research_Lvl3_L2_Up_3.SetActive(false);
        research_Lvl3_L2_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_5_Research_2()
    {
        research_Lvl3_L2_Up_4.SetActive(false);
        research_Lvl3_L2_Up_5.SetActive(true); DiplayUiStats();
    }
    #endregion
    // WALL L Check Save
    #region Check Unlock Wall L & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Check_Save_Wall_L()
    {
        if (GC.Wall_L) { 
            switch (GC.Wall_L_Upg)
            {
                case 1:
                    Check_1_Wall_L();
                    break;
                case 2:
                    Check_2_Wall_L();
                    break;
                case 3:
                    Check_3_Wall_L();
                    break;
                case 4:
                    Check_4_Wall_L();
                    break;
                case 5:
                    Check_5_Wall_L();
                    break;
                case 6:
                    Check_6_Wall_L();
                    break;
                case 7:
                    Check_7_Wall_L();
                    break;
                case 8:
                    Check_8_Wall_L();
                    break;
                case 9:
                    Check_9_Wall_L();
                    break;
                case 10:
                    Check_10_Wall_L();
                    break;
            }
        }
        else { Check_Locked_Wall_L(); }
    }
    private void Check_Locked_Wall_L()
    {
        wall_Left_None.SetActive(true); DiplayUiStats();
    }
    private void Check_1_Wall_L()
    {
        wall_Left_None.SetActive(false);
        wall_Left_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_2_Wall_L()
    {
        wall_Left_Up_1.SetActive(false);
        wall_Left_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_3_Wall_L()
    {
        wall_Left_Up_2.SetActive(false);
        wall_Left_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_4_Wall_L()
    {
        wall_Left_Up_3.SetActive(false);
        wall_Left_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_5_Wall_L()
    {
        wall_Left_Up_4.SetActive(false);
        wall_Left_Up_5.SetActive(true); DiplayUiStats();
    }
    private void Check_6_Wall_L()
    {
        wall_Left_Up_5.SetActive(false);
        wall_Left_Up_6.SetActive(true); DiplayUiStats();
    }
    private void Check_7_Wall_L()
    {
        wall_Left_Up_6.SetActive(false);
        wall_Left_Up_7.SetActive(true); DiplayUiStats();
    }
    private void Check_8_Wall_L()
    {
        wall_Left_Up_7.SetActive(false);
        wall_Left_Up_8.SetActive(true); DiplayUiStats();
    }
    private void Check_9_Wall_L()
    {
        wall_Left_Up_8.SetActive(false);
        wall_Left_Up_9.SetActive(true); DiplayUiStats();
    }
    private void Check_10_Wall_L()
    {
        wall_Left_Up_9.SetActive(false);
        wall_Left_Up_10.SetActive(true); DiplayUiStats();
    }
    #endregion
    // WALL R Check Save
    #region Check Unlock Wall R & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Check_Save_Wall_R()
    {
        if (GC.Wall_R) { 
            switch (GC.Wall_R_Upg)
            {
                case 1:
                    Check_Save_1_Wall_R();
                    break;
                case 2:
                    Check_Save_2_Wall_R();
                    break;
                case 3:
                    Check_Save_3_Wall_R();
                    break;
                case 4:
                    Check_Save_4_Wall_R();
                    break;
                case 5:
                    Check_Save_5_Wall_R();
                    break;
                case 6:
                    Check_Save_6_Wall_R();
                    break;
                case 7:
                    Check_Save_7_Wall_R();
                    break;
                case 8:
                    Check_Save_8_Wall_R();
                    break;
                case 9:
                    Check_Save_9_Wall_R();
                    break;
                case 10:
                    Check_Save_10_Wall_R();
                    break;
            }
        }
        else { Check_Save_Locked_Wall_R(); }

    }
    private void Check_Save_Locked_Wall_R()
    {
        wall_Right_None.SetActive(true); DiplayUiStats();
    }
    private void Check_Save_1_Wall_R()
    {
        wall_Right_None.SetActive(false);
        wall_Right_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_Save_2_Wall_R()
    {
        wall_Right_Up_1.SetActive(false);
        wall_Right_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_Save_3_Wall_R()
    {
        wall_Right_Up_2.SetActive(false);
        wall_Right_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_Save_4_Wall_R()
    {
        wall_Right_Up_3.SetActive(false);
        wall_Right_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_Save_5_Wall_R()
    {
        wall_Right_Up_4.SetActive(false);
        wall_Right_Up_5.SetActive(true); DiplayUiStats();
    }
    private void Check_Save_6_Wall_R()
    {
        wall_Right_Up_5.SetActive(false);
        wall_Right_Up_6.SetActive(true); DiplayUiStats();
    }
    private void Check_Save_7_Wall_R()
    {
        wall_Right_Up_6.SetActive(false);
        wall_Right_Up_7.SetActive(true); DiplayUiStats();
    }
    private void Check_Save_8_Wall_R()
    {
        wall_Right_Up_7.SetActive(false);
        wall_Right_Up_8.SetActive(true); DiplayUiStats();
    }
    private void Check_Save_9_Wall_R()
    {
        wall_Right_Up_8.SetActive(false);
        wall_Right_Up_9.SetActive(true); DiplayUiStats();
    }
    private void Check_Save_10_Wall_R()
    {
        wall_Right_Up_9.SetActive(false);
        wall_Right_Up_10.SetActive(true); DiplayUiStats();
    }
    #endregion
    #endregion
    #endregion
}
