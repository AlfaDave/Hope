using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Logic : MonoBehaviour
{
    private GameController GC;
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

    private float WaitClickTime = 5;
    private float WaitResearchBonus = 0;
    private float WaitWorkshopBonus = 0;
    private float WaitPowerGenBonus = 0;
    private float WaitLivingSpace = 0;
    private int purchaseValue = 250;
    private void CheckClickWaitingTime()
    {

    }
    private void Start()
    {
        GC = GameObject.Find("GameController").GetComponent<GameController>();
        LinkButtons();
        LinkArtGameObjects();
        TurnAllItemsOff();
        SetDefaultBuildingsViews();
        CheckRoomUnlockProgress();
    }
    private void SetupPlayArea()
    {

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
private void LivingSpacesBonus() { }
    private void ResearchBonus() { }
    private void WorkshopBonus() { }
    private void PowerGeneratorBonus() { }
    private void SetDefaultBuildingsViews()
    {
        #region Upgrade GameObjects
        #region Bedrooms
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
        #region Stairs
        stairs_1_Locked.SetActive(false);
        stairs_1_Unlocked.SetActive(true);
        stairs_2_Locked.SetActive(true);
        stairs_2_Unlocked.SetActive(false);
        stairs_3_Locked.SetActive(true);
        stairs_3_Unlocked.SetActive(false);
        #endregion
        #region Walls
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
        #region Main Rooms
        underGarden_Lvl1_L1_Def.SetActive(true);
        underGarden_Lvl1_L1_Up_1.SetActive(false);
        underGarden_Lvl1_L1_Up_2.SetActive(false);
        underGarden_Lvl1_L1_Up_3.SetActive(false);
        underGarden_Lvl1_L1_Up_4.SetActive(false);
        underGarden_Lvl1_L1_Up_5.SetActive(false);
        radio_Lvl1_L2_Def.SetActive(true);
        radio_Lvl1_L2_Up_1.SetActive(false);
        radio_Lvl1_L2_Up_2.SetActive(false);
        radio_Lvl1_L2_Up_3.SetActive(false);
        radio_Lvl1_L2_Up_4.SetActive(false);
        radio_Lvl1_L2_Up_5.SetActive(false);
        expedition_Lvl1_R1_Def.SetActive(true);
        expedition_Lvl1_R1_Up_1.SetActive(false);
        expedition_Lvl1_R1_Up_2.SetActive(false);
        expedition_Lvl1_R1_Up_3.SetActive(false);
        expedition_Lvl1_R1_Up_4.SetActive(false);
        expedition_Lvl1_R1_Up_5.SetActive(false);
        training_Lvl1_R2_Def.SetActive(true);
        training_Lvl1_R2_Up_1.SetActive(false);
        training_Lvl1_R2_Up_2.SetActive(false);
        training_Lvl1_R2_Up_3.SetActive(false);
        training_Lvl1_R2_Up_4.SetActive(false);
        training_Lvl1_R2_Up_5.SetActive(false);
        workshop_Lvl2_L1_Def.SetActive(true);
        workshop_Lvl2_L1_Up_1.SetActive(false);
        workshop_Lvl2_L1_Up_2.SetActive(false);
        workshop_Lvl2_L1_Up_3.SetActive(false);
        workshop_Lvl2_L1_Up_4.SetActive(false);
        workshop_Lvl2_L1_Up_5.SetActive(false);
        workshop_Lvl2_L2_Def.SetActive(true);
        workshop_Lvl2_L2_Up_1.SetActive(false);
        workshop_Lvl2_L2_Up_2.SetActive(false);
        workshop_Lvl2_L2_Up_3.SetActive(false);
        workshop_Lvl2_L2_Up_4.SetActive(false);
        workshop_Lvl2_L2_Up_5.SetActive(false);
        generator_Lvl2_R1_Def.SetActive(true);
        generator_Lvl2_R1_Up_1.SetActive(false);
        generator_Lvl2_R1_Up_2.SetActive(false);
        generator_Lvl2_R1_Up_3.SetActive(false);
        generator_Lvl2_R1_Up_4.SetActive(false);
        generator_Lvl2_R1_Up_5.SetActive(false);
        generator_Lvl2_R2_Def.SetActive(true);
        generator_Lvl2_R2_Up_1.SetActive(false);
        generator_Lvl2_R2_Up_2.SetActive(false);
        generator_Lvl2_R2_Up_3.SetActive(false);
        generator_Lvl2_R2_Up_4.SetActive(false);
        generator_Lvl2_R2_Up_5.SetActive(false);
        research_Lvl3_L1_Def.SetActive(true);
        research_Lvl3_L1_Up_1.SetActive(false);
        research_Lvl3_L1_Up_2.SetActive(false);
        research_Lvl3_L1_Up_3.SetActive(false);
        research_Lvl3_L1_Up_4.SetActive(false);
        research_Lvl3_L1_Up_5.SetActive(false);
        research_Lvl3_L2_Def.SetActive(true);
        research_Lvl3_L2_Up_1.SetActive(false);
        research_Lvl3_L2_Up_2.SetActive(false);
        research_Lvl3_L2_Up_3.SetActive(false);
        research_Lvl3_L2_Up_4.SetActive(false);
        research_Lvl3_L2_Up_5.SetActive(false);
        livingSpace_Lvl3_R1_Def.SetActive(true);
        livingSpace_Lvl3_R1_Up_1.SetActive(false);
        livingSpace_Lvl3_R1_Up_2.SetActive(false);
        livingSpace_Lvl3_R1_Up_3.SetActive(false);
        livingSpace_Lvl3_R1_Up_4.SetActive(false);
        livingSpace_Lvl3_R1_Up_5.SetActive(false);
        livingSpace_Lvl3_R2_Def.SetActive(true);
        livingSpace_Lvl3_R2_Up_1.SetActive(false);
        livingSpace_Lvl3_R2_Up_2.SetActive(false);
        livingSpace_Lvl3_R2_Up_3.SetActive(false);
        livingSpace_Lvl3_R2_Up_4.SetActive(false);
        livingSpace_Lvl3_R2_Up_5.SetActive(false);
        #endregion
        #endregion
    }
    private void CheckRoomUnlockProgress()
    {
        CheckBedroomUnlockProgress();
        CheckStairsUnlockProgress();
        CheckGeneratorUnlockProgress();
        BuyWorkshopUnlockProgress();
        BuyLivingSpaceUnlockProgress();
        //BuyResearchUnlockProgress();
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
    #region Purchase Buildings & Upgrades
    #region Expedition & Upgrades // not figured out the values to spend on unlocks
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Expedition_Building()
    {
        switch (GC.Expedition_Upg_Lvl1_R1)
        {
            case 0:
                Buy_Up_1_Expedition();
                break;
            case 1:
                Buy_Up_2_Expedition();
                break;
            case 2:
                Buy_Up_3_Expedition();
                break;
            case 3:
                Buy_Up_4_Expedition();
                break;
            case 4:
                Buy_Up_5_Expedition();
                break;
        }
    }
    private void Buy_Up_1_Expedition()
    {
        if (GC.Player_Metal >= purchaseValue && GC.Player_Wood >= purchaseValue && GC.Player_Tech >= purchaseValue)
        {
            GC.Player_Metal -= purchaseValue;
            GC.Player_Wood -= purchaseValue;
            GC.Player_Tech -= purchaseValue;
            GC.Expedition_Upg_Lvl1_R1 = 1;
            expedition_Lvl1_R1_Def.SetActive(false);
            expedition_Lvl1_R1_Up_1.SetActive(true);
        }
    }
    private void Buy_Up_2_Expedition()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Expedition_Upg_Lvl1_R1 = 2;
            expedition_Lvl1_R1_Up_1.SetActive(false);
            expedition_Lvl1_R1_Up_2.SetActive(true);
        }
    }
    private void Buy_Up_3_Expedition()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Expedition_Upg_Lvl1_R1 = 3;
            expedition_Lvl1_R1_Up_2.SetActive(false);
            expedition_Lvl1_R1_Up_3.SetActive(true);
        }
    }
    private void Buy_Up_4_Expedition()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Expedition_Upg_Lvl1_R1 = 4;
            expedition_Lvl1_R1_Up_3.SetActive(false);
            expedition_Lvl1_R1_Up_4.SetActive(true);
        }
    }
    private void Buy_Up_5_Expedition()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.Expedition_Upg_Lvl1_R1 = 5;
            expedition_Lvl1_R1_Up_4.SetActive(false);
            expedition_Lvl1_R1_Up_5.SetActive(true);
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
                case 0:
                Buy_Up_1_Training();
                    break;
                case 1:
                Buy_Up_2_Training();
                    break;
                case 2:
                Buy_Up_3_Training();
                    break;
                case 3:
                Buy_Up_4_Training();
                    break;
                case 4:
                Buy_Up_5_Training();
                    break;
            }
    }
    private void Buy_Up_1_Training()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Training_Upg_Lvl1_R2 = 1;
            training_Lvl1_R2_Def.SetActive(false);
            training_Lvl1_R2_Up_1.SetActive(true);
        }
    }
    private void Buy_Up_2_Training()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Training_Upg_Lvl1_R2 = 2;
            training_Lvl1_R2_Up_1.SetActive(false);
            training_Lvl1_R2_Up_2.SetActive(true);
        }
    }
    private void Buy_Up_3_Training()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Training_Upg_Lvl1_R2 = 3;
            training_Lvl1_R2_Up_2.SetActive(false);
            training_Lvl1_R2_Up_3.SetActive(true);
        }
    }
    private void Buy_Up_4_Training()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.Training_Upg_Lvl1_R2 = 4;
            training_Lvl1_R2_Up_3.SetActive(false);
            training_Lvl1_R2_Up_4.SetActive(true);
        }
    }
    private void Buy_Up_5_Training()
    {
        if (GC.Player_Metal >= (purchaseValue * 32) && GC.Player_Wood >= (purchaseValue * 32) && GC.Player_Tech >= (purchaseValue * 32))
        {
            GC.Player_Metal -= (purchaseValue * 32);
            GC.Player_Wood -= (purchaseValue * 32);
            GC.Player_Tech -= (purchaseValue * 32);
            GC.Training_Upg_Lvl1_R2 = 5;
            training_Lvl1_R2_Up_4.SetActive(false);
            training_Lvl1_R2_Up_5.SetActive(true);
        }
    }
    #endregion
    // Expedition(1) & Training(2) IS LEVEL 2 RIGHT SIDE
    #region UnderGarden & Upgrades // not figured out the values to spend on unlocks
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_UnderGarden_Building()
    {
        switch (GC.UnderGarden_Upg_Lvl1_L1)
            {
                case 0:
                Buy_Up_1_UnderGarden();
                    break;
                case 1:
                Buy_Up_2_UnderGarden();
                    break;
                case 2:
                Buy_Up_3_UnderGarden();
                    break;
                case 3:
                Buy_Up_4_UnderGarden();
                    break;
                case 4:
                Buy_Up_5_UnderGarden();
                    break;
            }
    }
    private void Buy_Up_1_UnderGarden()
    {
        if (GC.Player_Metal >= purchaseValue && GC.Player_Wood >= purchaseValue && GC.Player_Tech >= purchaseValue)
        {
            GC.Player_Metal -= purchaseValue;
            GC.Player_Wood -= purchaseValue;
            GC.Player_Tech -= purchaseValue;
            GC.UnderGarden_Upg_Lvl1_L1 = 1;
            underGarden_Lvl1_L1_Def.SetActive(false);
            underGarden_Lvl1_L1_Up_1.SetActive(true);
        }
    }
    private void Buy_Up_2_UnderGarden()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.UnderGarden_Upg_Lvl1_L1 = 2;
            underGarden_Lvl1_L1_Up_1.SetActive(false);
            underGarden_Lvl1_L1_Up_2.SetActive(true);
        }
    }
    private void Buy_Up_3_UnderGarden()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.UnderGarden_Upg_Lvl1_L1 = 3;
            underGarden_Lvl1_L1_Up_2.SetActive(false);
            underGarden_Lvl1_L1_Up_3.SetActive(true);
        }
    }
    private void Buy_Up_4_UnderGarden()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.UnderGarden_Upg_Lvl1_L1 = 4;
            underGarden_Lvl1_L1_Up_3.SetActive(false);
            underGarden_Lvl1_L1_Up_4.SetActive(true);
        }
    }
    private void Buy_Up_5_UnderGarden()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.UnderGarden_Upg_Lvl1_L1 = 5;
            underGarden_Lvl1_L1_Up_4.SetActive(false);
            underGarden_Lvl1_L1_Up_5.SetActive(true);
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
                case 0:
                    Buy_Up_1_Radio();
                    break;
                case 1:
                    Buy_Up_2_Radio();
                    break;
                case 2:
                    Buy_Up_3_Radio();
                    break;
                case 3:
                    Buy_Up_4_Radio();
                    break;
                case 4:
                    Buy_Up_5_Radio();
                    break;
            }
    }
    private void Buy_Up_1_Radio()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Radio_Upg_Lvl1_L2 = 1;
            radio_Lvl1_L2_Def.SetActive(false);
            radio_Lvl1_L2_Up_1.SetActive(true);
        }
    }
    private void Buy_Up_2_Radio()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Radio_Upg_Lvl1_L2 = 2;
            radio_Lvl1_L2_Up_1.SetActive(false);
            radio_Lvl1_L2_Up_2.SetActive(true);
        }
    }
    private void Buy_Up_3_Radio()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Radio_Upg_Lvl1_L2 = 3;
            radio_Lvl1_L2_Up_2.SetActive(false);
            radio_Lvl1_L2_Up_3.SetActive(true);
        }
    }
    private void Buy_Up_4_Radio()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.Radio_Upg_Lvl1_L2 = 4;
            radio_Lvl1_L2_Up_3.SetActive(false);
            radio_Lvl1_L2_Up_4.SetActive(true);
        }
    }
    private void Buy_Up_5_Radio()
    {
        if (GC.Player_Metal >= (purchaseValue * 32) && GC.Player_Wood >= (purchaseValue * 32) && GC.Player_Tech >= (purchaseValue * 32))
        {
            GC.Player_Metal -= (purchaseValue * 32);
            GC.Player_Wood -= (purchaseValue * 32);
            GC.Player_Tech -= (purchaseValue * 32);
            GC.Radio_Upg_Lvl1_L2 = 5;
            radio_Lvl1_L2_Up_4.SetActive(false);
            radio_Lvl1_L2_Up_5.SetActive(true);
        }
    }
    #endregion
    // UnderGarden(1) & Radio(2) IS LEVEL 1 LEFT SIDE
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
                case 0:
                    Buy_Up_1_Generator_1();
                    break;
                case 1:
                    Buy_Up_2_Generator_1();
                    break;
                case 2:
                    Buy_Up_3_Generator_1();
                    break;
                case 3:
                    Buy_Up_4_Generator_1();
                    break;
                case 4:
                    Buy_Up_5_Generator_1();
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
            GC.Generator_Upg_Lvl2_R1 = 0;
            generator_Lvl2_R1_Def.SetActive(true);
        }
    }
    private void Buy_Up_1_Generator_1()
    {
        if (GC.Player_Metal >= purchaseValue && GC.Player_Wood >= purchaseValue && GC.Player_Tech >= purchaseValue)
        {
            GC.Player_Metal -= purchaseValue;
            GC.Player_Wood -= purchaseValue;
            GC.Player_Tech -= purchaseValue;
            GC.Generator_Upg_Lvl2_R1 = 1;
            generator_Lvl2_R1_Def.SetActive(false);
            generator_Lvl2_R1_Up_1.SetActive(true);
        }
    }
    private void Buy_Up_2_Generator_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Generator_Upg_Lvl2_R1 = 2;
            generator_Lvl2_R1_Up_1.SetActive(false);
            generator_Lvl2_R1_Up_2.SetActive(true);
        }
    }
    private void Buy_Up_3_Generator_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Generator_Upg_Lvl2_R1 = 3;
            generator_Lvl2_R1_Up_2.SetActive(false);
            generator_Lvl2_R1_Up_3.SetActive(true);
        }
    }
    private void Buy_Up_4_Generator_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Generator_Upg_Lvl2_R1 = 4;
            generator_Lvl2_R1_Up_3.SetActive(false);
            generator_Lvl2_R1_Up_4.SetActive(true);
        }
    }
    private void Buy_Up_5_Generator_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.Generator_Upg_Lvl2_R1 = 5;
            generator_Lvl2_R1_Up_4.SetActive(false);
            generator_Lvl2_R1_Up_5.SetActive(true);
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
                case 0:
                    Buy_Up_1_Generator_2();
                    break;
                case 1:
                    Buy_Up_2_Generator_2();
                    break;
                case 2:
                    Buy_Up_3_Generator_2();
                    break;
                case 3:
                    Buy_Up_4_Generator_2();
                    break;
                case 4:
                    Buy_Up_5_Generator_2();
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
            GC.Generator_Upg_Lvl2_R2 = 0;
            generator_Lvl2_R2_Def.SetActive(true);
        }
    }
    private void Buy_Up_1_Generator_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Generator_Upg_Lvl2_R2 = 1;
            generator_Lvl2_R2_Def.SetActive(false);
            generator_Lvl2_R2_Up_1.SetActive(true);
        }
    }
    private void Buy_Up_2_Generator_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Generator_Upg_Lvl2_R2 = 2;
            generator_Lvl2_R2_Up_1.SetActive(false);
            generator_Lvl2_R2_Up_2.SetActive(true);
        }
    }
    private void Buy_Up_3_Generator_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Generator_Upg_Lvl2_R2 = 3;
            generator_Lvl2_R2_Up_2.SetActive(false);
            generator_Lvl2_R2_Up_3.SetActive(true);
        }
    }
    private void Buy_Up_4_Generator_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.Generator_Upg_Lvl2_R2 = 4;
            generator_Lvl2_R2_Up_3.SetActive(false);
            generator_Lvl2_R2_Up_4.SetActive(true);
        }
    }
    private void Buy_Up_5_Generator_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 32) && GC.Player_Wood >= (purchaseValue * 32) && GC.Player_Tech >= (purchaseValue * 32))
        {
            GC.Player_Metal -= (purchaseValue * 32);
            GC.Player_Wood -= (purchaseValue * 32);
            GC.Player_Tech -= (purchaseValue * 32);
            GC.Generator_Upg_Lvl2_R2 = 5;
            generator_Lvl2_R2_Up_4.SetActive(false);
            generator_Lvl2_R2_Up_5.SetActive(true);
        }
    }
    #endregion
    // GENERATOR IS LEVEL 2 RIGHT SIDE
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
                case 0:
                    Buy_Up_1_Workshop_1();
                    break;
                case 1:
                    Buy_Up_2_Workshop_1();
                    break;
                case 2:
                    Buy_Up_3_Workshop_1();
                    break;
                case 3:
                    Buy_Up_4_Workshop_1();
                    break;
                case 4:
                    Buy_Up_5_Workshop_1();
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
            GC.Workshop_Upg_Lvl2_L1 = 0;
            workshop_Lvl2_L1_Def.SetActive(true);
        }
    }
    private void Buy_Up_1_Workshop_1()
    {
        if (GC.Player_Metal >= purchaseValue && GC.Player_Wood >= purchaseValue && GC.Player_Tech >= purchaseValue)
        {
            GC.Player_Metal -= purchaseValue;
            GC.Player_Wood -= purchaseValue;
            GC.Player_Tech -= purchaseValue;
            GC.Workshop_Upg_Lvl2_L1 = 1;
            workshop_Lvl2_L1_Def.SetActive(false);
            workshop_Lvl2_L1_Up_1.SetActive(true);
        }
    }
    private void Buy_Up_2_Workshop_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Workshop_Upg_Lvl2_L1 = 2;
            workshop_Lvl2_L1_Up_1.SetActive(false);
            workshop_Lvl2_L1_Up_2.SetActive(true);
        }
    }
    private void Buy_Up_3_Workshop_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Workshop_Upg_Lvl2_L1 = 3;
            workshop_Lvl2_L1_Up_2.SetActive(false);
            workshop_Lvl2_L1_Up_3.SetActive(true);
        }
    }
    private void Buy_Up_4_Workshop_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Workshop_Upg_Lvl2_L1 = 4;
            workshop_Lvl2_L1_Up_3.SetActive(false);
            workshop_Lvl2_L1_Up_4.SetActive(true);
        }
    }
    private void Buy_Up_5_Workshop_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.Workshop_Upg_Lvl2_L1 = 5;
            workshop_Lvl2_L1_Up_4.SetActive(false);
            workshop_Lvl2_L1_Up_5.SetActive(true);
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
                case 0:
                    Buy_Up_1_Workshop_2();
                    break;
                case 1:
                    Buy_Up_2_Workshop_2();
                    break;
                case 2:
                    Buy_Up_3_Workshop_2();
                    break;
                case 3:
                    Buy_Up_4_Workshop_2();
                    break;
                case 4:
                    Buy_Up_5_Workshop_2();
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
            GC.Workshop_Upg_Lvl2_L2 = 0;
            workshop_Lvl2_L2_Def.SetActive(true);
        }
    }
    private void Buy_Up_1_Workshop_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Workshop_Upg_Lvl2_L2 = 1;
            workshop_Lvl2_L2_Def.SetActive(false);
            workshop_Lvl2_L2_Up_1.SetActive(true);
        }
    }
    private void Buy_Up_2_Workshop_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Workshop_Upg_Lvl2_L2 = 2;
            workshop_Lvl2_L2_Up_1.SetActive(false);
            workshop_Lvl2_L2_Up_2.SetActive(true);
        }
    }
    private void Buy_Up_3_Workshop_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Workshop_Upg_Lvl2_L2 = 3;
            workshop_Lvl2_L2_Up_2.SetActive(false);
            workshop_Lvl2_L2_Up_3.SetActive(true);
        }
    }
    private void Buy_Up_4_Workshop_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.Workshop_Upg_Lvl2_L2 = 4;
            workshop_Lvl2_L2_Up_3.SetActive(false);
            workshop_Lvl2_L2_Up_4.SetActive(true);
        }
    }
    private void Buy_Up_5_Workshop_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 32) && GC.Player_Wood >= (purchaseValue * 32) && GC.Player_Tech >= (purchaseValue * 32))
        {
            GC.Player_Metal -= (purchaseValue * 32);
            GC.Player_Wood -= (purchaseValue * 32);
            GC.Player_Tech -= (purchaseValue * 32);
            GC.Workshop_Upg_Lvl2_L2 = 5;
            workshop_Lvl2_L2_Up_4.SetActive(false);
            workshop_Lvl2_L2_Up_5.SetActive(true);
        }
    }
    #endregion
    // WORKSHOP IS LEVEL 2 LEFT SIDE
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
                case 0:
                    Buy_Up_1_LivingSpace_1();
                    break;
                case 1:
                    Buy_Up_2_LivingSpace_1();
                    break;
                case 2:
                    Buy_Up_3_LivingSpace_1();
                    break;
                case 3:
                    Buy_Up_4_LivingSpace_1();
                    break;
                case 4:
                    Buy_Up_5_LivingSpace_1();
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
            GC.LivingSpace_Upg_Lvl3_R1 = 0;
            livingSpace_Lvl3_R1_Def.SetActive(true);
        }
    }
    private void Buy_Up_1_LivingSpace_1()
    {
        if (GC.Player_Metal >= purchaseValue && GC.Player_Wood >= purchaseValue && GC.Player_Tech >= purchaseValue)
        {
            GC.Player_Metal -= purchaseValue;
            GC.Player_Wood -= purchaseValue;
            GC.Player_Tech -= purchaseValue;
            GC.LivingSpace_Upg_Lvl3_R1 = 1;
            livingSpace_Lvl3_R1_Def.SetActive(false);
            livingSpace_Lvl3_R1_Up_1.SetActive(true);
        }
    }
    private void Buy_Up_2_LivingSpace_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.LivingSpace_Upg_Lvl3_R1 = 2;
            livingSpace_Lvl3_R1_Up_1.SetActive(false);
            livingSpace_Lvl3_R1_Up_2.SetActive(true);
        }
    }
    private void Buy_Up_3_LivingSpace_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.LivingSpace_Upg_Lvl3_R1 = 3;
            livingSpace_Lvl3_R1_Up_2.SetActive(false);
            livingSpace_Lvl3_R1_Up_3.SetActive(true);
        }
    }
    private void Buy_Up_4_LivingSpace_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.LivingSpace_Upg_Lvl3_R1 = 4;
            livingSpace_Lvl3_R1_Up_3.SetActive(false);
            livingSpace_Lvl3_R1_Up_4.SetActive(true);
        }
    }
    private void Buy_Up_5_LivingSpace_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.LivingSpace_Upg_Lvl3_R1 = 5;
            livingSpace_Lvl3_R1_Up_4.SetActive(false);
            livingSpace_Lvl3_R1_Up_5.SetActive(true);
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
                case 0:
                    Buy_Up_1_LivingSpace_2();
                    break;
                case 1:
                    Buy_Up_2_LivingSpace_2();
                    break;
                case 2:
                    Buy_Up_3_LivingSpace_2();
                    break;
                case 3:
                    Buy_Up_4_LivingSpace_2();
                    break;
                case 4:
                    Buy_Up_5_LivingSpace_2();
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
            GC.LivingSpace_Upg_Lvl3_R2 = 0;
            livingSpace_Lvl3_R2_Def.SetActive(true);
        }
    }
    private void Buy_Up_1_LivingSpace_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.LivingSpace_Upg_Lvl3_R2 = 1;
            livingSpace_Lvl3_R2_Def.SetActive(false);
            livingSpace_Lvl3_R2_Up_1.SetActive(true);
        }
    }
    private void Buy_Up_2_LivingSpace_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.LivingSpace_Upg_Lvl3_R2 = 2;
            livingSpace_Lvl3_R2_Up_1.SetActive(false);
            livingSpace_Lvl3_R2_Up_2.SetActive(true);
        }
    }
    private void Buy_Up_3_LivingSpace_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.LivingSpace_Upg_Lvl3_R2 = 3;
            livingSpace_Lvl3_R2_Up_2.SetActive(false);
            livingSpace_Lvl3_R2_Up_3.SetActive(true);
        }
    }
    private void Buy_Up_4_LivingSpace_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.LivingSpace_Upg_Lvl3_R2 = 4;
            livingSpace_Lvl3_R2_Up_3.SetActive(false);
            livingSpace_Lvl3_R2_Up_4.SetActive(true);
        }
    }
    private void Buy_Up_5_LivingSpace_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 32) && GC.Player_Wood >= (purchaseValue * 32) && GC.Player_Tech >= (purchaseValue * 32))
        {
            GC.Player_Metal -= (purchaseValue * 32);
            GC.Player_Wood -= (purchaseValue * 32);
            GC.Player_Tech -= (purchaseValue * 32);
            GC.LivingSpace_Upg_Lvl3_R2 = 5;
            livingSpace_Lvl3_R2_Up_4.SetActive(false);
            livingSpace_Lvl3_R2_Up_5.SetActive(true);
        }
    }
    #endregion
    // LIVING IS LEVEL 3 RIGHT SIDE
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
                case 0:
                    Buy_Up_1_Research_1();
                    break;
                case 1:
                    Buy_Up_2_Research_1();
                    break;
                case 2:
                    Buy_Up_3_Research_1();
                    break;
                case 3:
                    Buy_Up_4_Research_1();
                    break;
                case 4:
                    Buy_Up_5_Research_1();
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
            GC.Research_Upg_Lvl3_L1 = 0;
            research_Lvl3_L1_Def.SetActive(true);
        }
    }
    private void Buy_Up_1_Research_1()
    {
        if (GC.Player_Metal >= purchaseValue && GC.Player_Wood >= purchaseValue && GC.Player_Tech >= purchaseValue)
        {
            GC.Player_Metal -= purchaseValue;
            GC.Player_Wood -= purchaseValue;
            GC.Player_Tech -= purchaseValue;
            GC.Research_Upg_Lvl3_L1 = 1;
            research_Lvl3_L1_Def.SetActive(false);
            research_Lvl3_L1_Up_1.SetActive(true);
        }
    }
    private void Buy_Up_2_Research_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Research_Upg_Lvl3_L1 = 2;
            research_Lvl3_L1_Up_1.SetActive(false);
            research_Lvl3_L1_Up_2.SetActive(true);
        }
    }
    private void Buy_Up_3_Research_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Research_Upg_Lvl3_L1 = 3;
            research_Lvl3_L1_Up_2.SetActive(false);
            research_Lvl3_L1_Up_3.SetActive(true);
        }
    }
    private void Buy_Up_4_Research_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Research_Upg_Lvl3_L1 = 4;
            research_Lvl3_L1_Up_3.SetActive(false);
            research_Lvl3_L1_Up_4.SetActive(true);
        }
    }
    private void Buy_Up_5_Research_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.Research_Upg_Lvl3_L1 = 5;
            research_Lvl3_L1_Up_4.SetActive(false);
            research_Lvl3_L1_Up_5.SetActive(true);
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
                case 0:
                    Buy_Up_1_Research_2();
                    break;
                case 1:
                    Buy_Up_2_Research_2();
                    break;
                case 2:
                    Buy_Up_3_Research_2();
                    break;
                case 3:
                    Buy_Up_4_Research_2();
                    break;
                case 4:
                    Buy_Up_5_Research_2();
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
            GC.Research_Upg_Lvl3_L2 = 0;
            research_Lvl3_L2_Def.SetActive(true);
        }
    }
    private void Buy_Up_1_Research_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Research_Upg_Lvl3_L2 = 1;
            research_Lvl3_L2_Def.SetActive(false);
            research_Lvl3_L2_Up_1.SetActive(true);
        }
    }
    private void Buy_Up_2_Research_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Research_Upg_Lvl3_L2 = 2;
            research_Lvl3_L2_Up_1.SetActive(false);
            research_Lvl3_L2_Up_2.SetActive(true);
        }
    }
    private void Buy_Up_3_Research_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Research_Upg_Lvl3_L2 = 3;
            research_Lvl3_L2_Up_2.SetActive(false);
            research_Lvl3_L2_Up_3.SetActive(true);
        }
    }
    private void Buy_Up_4_Research_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.Research_Upg_Lvl3_L2 = 4;
            research_Lvl3_L2_Up_3.SetActive(false);
            research_Lvl3_L2_Up_4.SetActive(true);
        }
    }
    private void Buy_Up_5_Research_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 32) && GC.Player_Wood >= (purchaseValue * 32) && GC.Player_Tech >= (purchaseValue * 32))
        {
            GC.Player_Metal -= (purchaseValue * 32);
            GC.Player_Wood -= (purchaseValue * 32);
            GC.Player_Tech -= (purchaseValue * 32);
            GC.Research_Upg_Lvl3_L2 = 5;
            research_Lvl3_L2_Up_4.SetActive(false);
            research_Lvl3_L2_Up_5.SetActive(true);
        }
    }
    #endregion
    // RESEARCH IS LEVEL 3 LEFT SIDE
    #endregion
    #endregion
}
