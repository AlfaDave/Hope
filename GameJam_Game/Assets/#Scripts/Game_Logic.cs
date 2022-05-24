using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Logic : MonoBehaviour
{
    private GameController GC;
    [SerializeField] internal GameObject res_Metal, res_Wood, res_Food, res_Tech;
    [SerializeField] internal GameObject hatch, wall_Left, wall_Right, stairs_1, stairs_2, stairs_3;
    [SerializeField]internal GameObject underGarden_Lvl1_L1, radio_Lvl1_L2, expedition_Lvl1_R1, training_Lvl1_R2, workshop_Lvl2_L1, workshop_Lvl2_L2, generator_Lvl2_R1, generator_Lvl2_R2, research_Lvl3_L1, research_Lvl3_L2, livingSpace_Lvl3_R1, LivingSpace_Lvl3_R2, bedroom_Lvl1_L, bedroom_Lvl1_R, bedroom_Lvl2_L, bedroom_Lvl2_R, bedroom_Lvl3_L, bedroom_Lvl3_R;
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
    public GameObject bedroom_Lvl1_L_Rock, bedroom_Lvl1_L_Up_1, bedroom_Lvl1_L_Up_2, bedroom_Lvl1_L_Up_3, bedroom_Lvl1_L_Up_4, bedroom_Lvl1_L_Up_5, bedroom_Lvl1_L_Up_6, bedroom_Lvl1_L_Up_7, bedroom_Lvl1_L_Up_8, bedroom_Lvl1_L_Up_9, bedroom_Lvl1_L_Up_10;
    public GameObject bedroom_Lvl2_L_Rock, bedroom_Lvl2_L_Up_1, bedroom_Lvl2_L_Up_2, bedroom_Lvl2_L_Up_3, bedroom_Lvl2_L_Up_4, bedroom_Lvl2_L_Up_5, bedroom_Lvl2_L_Up_6, bedroom_Lvl2_L_Up_7, bedroom_Lvl2_L_Up_8, bedroom_Lvl2_L_Up_9, bedroom_Lvl2_L_Up_10;
    public GameObject bedroom_Lvl3_L_Rock, bedroom_Lvl3_L_Up_1, bedroom_Lvl3_L_Up_2, bedroom_Lvl3_L_Up_3, bedroom_Lvl3_L_Up_4, bedroom_Lvl3_L_Up_5, bedroom_Lvl3_L_Up_6, bedroom_Lvl3_L_Up_7, bedroom_Lvl3_L_Up_8, bedroom_Lvl3_L_Up_9, bedroom_Lvl3_L_Up_10;
    public GameObject bedroom_Lvl1_R_Rock, bedroom_Lvl1_R_Up_1, bedroom_Lvl1_R_Up_2, bedroom_Lvl1_R_Up_3, bedroom_Lvl1_R_Up_4, bedroom_Lvl1_R_Up_5, bedroom_Lvl1_R_Up_6, bedroom_Lvl1_R_Up_7, bedroom_Lvl1_R_Up_8, bedroom_Lvl1_R_Up_9, bedroom_Lvl1_R_Up_10;
    public GameObject bedroom_Lvl2_R_Rock, bedroom_Lvl2_R_Up_1, bedroom_Lvl2_R_Up_2, bedroom_Lvl2_R_Up_3, bedroom_Lvl2_R_Up_4, bedroom_Lvl2_R_Up_5, bedroom_Lvl2_R_Up_6, bedroom_Lvl2_R_Up_7, bedroom_Lvl2_R_Up_8, bedroom_Lvl2_R_Up_9, bedroom_Lvl2_R_Up_10;
    public GameObject bedroom_Lvl3_R_Rock, bedroom_Lvl3_R_Up_1, bedroom_Lvl3_R_Up_2, bedroom_Lvl3_R_Up_3, bedroom_Lvl3_R_Up_4, bedroom_Lvl3_R_Up_5, bedroom_Lvl3_R_Up_6, bedroom_Lvl3_R_Up_7, bedroom_Lvl3_R_Up_8, bedroom_Lvl3_R_Up_9, bedroom_Lvl3_R_Up_10;
    #endregion
    #region Stairs
    public GameObject stairs_1_Locked, stairs_1_Unlocked, stairs_2_Locked, stairs_2_Unlocked, stairs_3_Locked, stairs_3_Unlocked;
    #endregion
    #region Walls
    public GameObject wall_Left_None, wall_Left_Up_1, wall_Left_Up_2, wall_Left_Up_3, wall_Left_Up_4, wall_Left_Up_5, wall_Left_Up_6, wall_Left_Up_7, wall_Left_Up_8, wall_Left_Up_9, wall_Left_Up_10;
    public GameObject wall_Right_None, wall_Right_Up_1, wall_Right_Up_2, wall_Right_Up_3, wall_Right_Up_4, wall_Right_Up_5, wall_Right_Up_6, wall_Right_Up_7, wall_Right_Up_8, wall_Right_Up_9, wall_Right_Up_10;
    #endregion
    #endregion

    private float WaitClickTime = 5;
    private float WaitResearchBonus = 0;
    private float WaitWorkshopBonus = 0;
    private float WaitPowerGenBonus = 0;
    private float WaitLivingSpace = 0;
    private void CheckClickWaitingTime()
    {

    }
    private void Start()
    {
        GC = GameObject.Find("GameController").GetComponent<GameController>();
        LinkButtons(); LinkArtGameObjects();
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
        hatch_Button = hatch.transform.GetChild(0).GetComponent<Button>();
        wall_Left_Button = wall_Left.transform.GetChild(0).GetComponent<Button>();
        wall_Right_Button = wall_Right.transform.GetChild(0).GetComponent<Button>();
        stairs_1_Button = stairs_1.transform.GetChild(0).GetComponent<Button>();
        stairs_2_Button = stairs_2.transform.GetChild(0).GetComponent<Button>();
        stairs_3_Button = stairs_3.transform.GetChild(0).GetComponent<Button>();
        underGarden_Lvl1_L1_Button = underGarden_Lvl1_L1.transform.GetChild(0).GetComponent<Button>();
        radio_Lvl1_L2_Button = radio_Lvl1_L2.transform.GetChild(0).GetComponent<Button>();
        expedition_Lvl1_R1_Button = expedition_Lvl1_R1.transform.GetChild(0).GetComponent<Button>();
        training_Lvl1_R2_Button = training_Lvl1_R2.transform.GetChild(0).GetComponent<Button>();
        workshop_Lvl2_L1_Button = workshop_Lvl2_L1.transform.GetChild(0).GetComponent<Button>();
        workshop_Lvl2_L2_Button = workshop_Lvl2_L2.transform.GetChild(0).GetComponent<Button>();
        generator_Lvl2_R1_Button = generator_Lvl2_R1.transform.GetChild(0).GetComponent<Button>();
        generator_Lvl2_R2_Button = generator_Lvl2_R2.transform.GetChild(0).GetComponent<Button>();
        research_Lvl3_L1_Button = research_Lvl3_L1.transform.GetChild(0).GetComponent<Button>();
        research_Lvl3_L2_Button = research_Lvl3_L2.transform.GetChild(0).GetComponent<Button>();
        livingSpace_Lvl3_R1_Button = livingSpace_Lvl3_R1.transform.GetChild(0).GetComponent<Button>();
        livingSpace_Lvl3_R2_Button = LivingSpace_Lvl3_R2.transform.GetChild(0).GetComponent<Button>();
        bedroom_lvl1_L_Button = bedroom_Lvl1_L.transform.GetChild(0).GetComponent<Button>();
        bedroom_Lvl1_R_Button = bedroom_Lvl1_R.transform.GetChild(0).GetComponent<Button>();
        bedroom_Lvl2_L_Button = bedroom_Lvl2_L.transform.GetChild(0).GetComponent<Button>();
        bedroom_Lvl2_R_Button = bedroom_Lvl2_R.transform.GetChild(0).GetComponent<Button>();
        bedroom_Lvl3_L_Button = bedroom_Lvl3_L.transform.GetChild(0).GetComponent<Button>();
        bedroom_Lvl3_R_Button = bedroom_Lvl3_R.transform.GetChild(0).GetComponent<Button>();
    }
    private void LinkArtGameObjects()
    {
        #region Bedrooms + Upgrades
        bedroom_Lvl1_L_Rock = bedroom_Lvl1_L.transform.GetChild(1).gameObject;
        bedroom_Lvl1_L_Up_1 = bedroom_Lvl1_L.transform.GetChild(2).gameObject;
        bedroom_Lvl1_L_Up_2 = bedroom_Lvl1_L.transform.GetChild(3).gameObject;
        bedroom_Lvl1_L_Up_3 = bedroom_Lvl1_L.transform.GetChild(4).gameObject;
        bedroom_Lvl1_L_Up_4 = bedroom_Lvl1_L.transform.GetChild(5).gameObject;
        bedroom_Lvl1_L_Up_5 = bedroom_Lvl1_L.transform.GetChild(6).gameObject;
        bedroom_Lvl1_L_Up_6 = bedroom_Lvl1_L.transform.GetChild(7).gameObject;
        bedroom_Lvl1_L_Up_7 = bedroom_Lvl1_L.transform.GetChild(8).gameObject;
        bedroom_Lvl1_L_Up_8 = bedroom_Lvl1_L.transform.GetChild(9).gameObject;
        bedroom_Lvl1_L_Up_9 = bedroom_Lvl1_L.transform.GetChild(10).gameObject;
        bedroom_Lvl1_L_Up_10 = bedroom_Lvl1_L.transform.GetChild(11).gameObject;

        bedroom_Lvl2_L_Rock = bedroom_Lvl2_L.transform.GetChild(1).gameObject;
        bedroom_Lvl2_L_Up_1 = bedroom_Lvl2_L.transform.GetChild(2).gameObject;
        bedroom_Lvl2_L_Up_2 = bedroom_Lvl2_L.transform.GetChild(3).gameObject;
        bedroom_Lvl2_L_Up_3 = bedroom_Lvl2_L.transform.GetChild(4).gameObject;
        bedroom_Lvl2_L_Up_4 = bedroom_Lvl2_L.transform.GetChild(5).gameObject;
        bedroom_Lvl2_L_Up_5 = bedroom_Lvl2_L.transform.GetChild(6).gameObject;
        bedroom_Lvl2_L_Up_6 = bedroom_Lvl2_L.transform.GetChild(7).gameObject;
        bedroom_Lvl2_L_Up_7 = bedroom_Lvl2_L.transform.GetChild(8).gameObject;
        bedroom_Lvl2_L_Up_8 = bedroom_Lvl2_L.transform.GetChild(9).gameObject;
        bedroom_Lvl2_L_Up_9 = bedroom_Lvl2_L.transform.GetChild(10).gameObject;
        bedroom_Lvl2_L_Up_10 = bedroom_Lvl2_L.transform.GetChild(11).gameObject;

        bedroom_Lvl3_L_Rock = bedroom_Lvl3_L.transform.GetChild(1).gameObject;
        bedroom_Lvl3_L_Up_1 = bedroom_Lvl3_L.transform.GetChild(2).gameObject;
        bedroom_Lvl3_L_Up_2 = bedroom_Lvl3_L.transform.GetChild(3).gameObject;
        bedroom_Lvl3_L_Up_3 = bedroom_Lvl3_L.transform.GetChild(4).gameObject;
        bedroom_Lvl3_L_Up_4 = bedroom_Lvl3_L.transform.GetChild(5).gameObject;
        bedroom_Lvl3_L_Up_5 = bedroom_Lvl3_L.transform.GetChild(6).gameObject;
        bedroom_Lvl3_L_Up_6 = bedroom_Lvl3_L.transform.GetChild(7).gameObject;
        bedroom_Lvl3_L_Up_7 = bedroom_Lvl3_L.transform.GetChild(8).gameObject;
        bedroom_Lvl3_L_Up_8 = bedroom_Lvl3_L.transform.GetChild(9).gameObject;
        bedroom_Lvl3_L_Up_9 = bedroom_Lvl3_L.transform.GetChild(10).gameObject;
        bedroom_Lvl3_L_Up_10 = bedroom_Lvl3_L.transform.GetChild(11).gameObject;

        bedroom_Lvl1_R_Rock = bedroom_Lvl1_R.transform.GetChild(1).gameObject;
        bedroom_Lvl1_R_Up_1 = bedroom_Lvl1_R.transform.GetChild(2).gameObject;
        bedroom_Lvl1_R_Up_2 = bedroom_Lvl1_R.transform.GetChild(3).gameObject;
        bedroom_Lvl1_R_Up_3 = bedroom_Lvl1_R.transform.GetChild(4).gameObject;
        bedroom_Lvl1_R_Up_4 = bedroom_Lvl1_R.transform.GetChild(5).gameObject;
        bedroom_Lvl1_R_Up_5 = bedroom_Lvl1_R.transform.GetChild(6).gameObject;
        bedroom_Lvl1_R_Up_6 = bedroom_Lvl1_R.transform.GetChild(7).gameObject;
        bedroom_Lvl1_R_Up_7 = bedroom_Lvl1_R.transform.GetChild(8).gameObject;
        bedroom_Lvl1_R_Up_8 = bedroom_Lvl1_R.transform.GetChild(9).gameObject;
        bedroom_Lvl1_R_Up_9 = bedroom_Lvl1_R.transform.GetChild(10).gameObject;
        bedroom_Lvl1_R_Up_10 = bedroom_Lvl1_R.transform.GetChild(11).gameObject;

        bedroom_Lvl2_R_Rock = bedroom_Lvl2_R.transform.GetChild(1).gameObject;
        bedroom_Lvl2_R_Up_1 = bedroom_Lvl2_R.transform.GetChild(2).gameObject;
        bedroom_Lvl2_R_Up_2 = bedroom_Lvl2_R.transform.GetChild(3).gameObject;
        bedroom_Lvl2_R_Up_3 = bedroom_Lvl2_R.transform.GetChild(4).gameObject;
        bedroom_Lvl2_R_Up_4 = bedroom_Lvl2_R.transform.GetChild(5).gameObject;
        bedroom_Lvl2_R_Up_5 = bedroom_Lvl2_R.transform.GetChild(6).gameObject;
        bedroom_Lvl2_R_Up_6 = bedroom_Lvl2_R.transform.GetChild(7).gameObject;
        bedroom_Lvl2_R_Up_7 = bedroom_Lvl2_R.transform.GetChild(8).gameObject;
        bedroom_Lvl2_R_Up_8 = bedroom_Lvl2_R.transform.GetChild(9).gameObject;
        bedroom_Lvl2_R_Up_9 = bedroom_Lvl2_R.transform.GetChild(10).gameObject;
        bedroom_Lvl2_R_Up_10 = bedroom_Lvl2_R.transform.GetChild(11).gameObject;

        bedroom_Lvl3_R_Rock = bedroom_Lvl3_R.transform.GetChild(1).gameObject;
        bedroom_Lvl3_R_Up_1 = bedroom_Lvl3_R.transform.GetChild(2).gameObject;
        bedroom_Lvl3_R_Up_2 = bedroom_Lvl3_R.transform.GetChild(3).gameObject;
        bedroom_Lvl3_R_Up_3 = bedroom_Lvl3_R.transform.GetChild(4).gameObject;
        bedroom_Lvl3_R_Up_4 = bedroom_Lvl3_R.transform.GetChild(5).gameObject;
        bedroom_Lvl3_R_Up_5 = bedroom_Lvl3_R.transform.GetChild(6).gameObject;
        bedroom_Lvl3_R_Up_6 = bedroom_Lvl3_R.transform.GetChild(7).gameObject;
        bedroom_Lvl3_R_Up_7 = bedroom_Lvl3_R.transform.GetChild(8).gameObject;
        bedroom_Lvl3_R_Up_8 = bedroom_Lvl3_R.transform.GetChild(9).gameObject;
        bedroom_Lvl3_R_Up_9 = bedroom_Lvl3_R.transform.GetChild(10).gameObject;
        bedroom_Lvl3_R_Up_10 = bedroom_Lvl3_R.transform.GetChild(11).gameObject;
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
        wall_Left_None = wall_Left.transform.GetChild(1).gameObject;
        wall_Left_Up_1 = wall_Left.transform.GetChild(2).gameObject;
        wall_Left_Up_2 = wall_Left.transform.GetChild(3).gameObject;
        wall_Left_Up_3 = wall_Left.transform.GetChild(4).gameObject;
        wall_Left_Up_4 = wall_Left.transform.GetChild(5).gameObject;
        wall_Left_Up_5 = wall_Left.transform.GetChild(6).gameObject;
        wall_Left_Up_6 = wall_Left.transform.GetChild(7).gameObject;
        wall_Left_Up_7 = wall_Left.transform.GetChild(8).gameObject;
        wall_Left_Up_8 = wall_Left.transform.GetChild(9).gameObject;
        wall_Left_Up_9 = wall_Left.transform.GetChild(10).gameObject;
        wall_Left_Up_10 = wall_Left.transform.GetChild(11).gameObject;
        wall_Right_None = wall_Right.transform.GetChild(1).gameObject;
        wall_Right_Up_1 = wall_Right.transform.GetChild(2).gameObject;
        wall_Right_Up_2 = wall_Right.transform.GetChild(3).gameObject;
        wall_Right_Up_3 = wall_Right.transform.GetChild(4).gameObject;
        wall_Right_Up_4 = wall_Right.transform.GetChild(5).gameObject;
        wall_Right_Up_5 = wall_Right.transform.GetChild(6).gameObject;
        wall_Right_Up_6 = wall_Right.transform.GetChild(7).gameObject;
        wall_Right_Up_7 = wall_Right.transform.GetChild(8).gameObject;
        wall_Right_Up_8 = wall_Right.transform.GetChild(9).gameObject;
        wall_Right_Up_9 = wall_Right.transform.GetChild(10).gameObject;
        wall_Right_Up_10 = wall_Right.transform.GetChild(11).gameObject;
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
    private void LivingSpacesBonus() { }
    private void ResearchBonus() { }
    private void WorkshopBonus() { }
    private void PowerGeneratorBonus() { }
    private void CheckRoomUnlockProgress()
    {
        CheckBedroomUnlockProgress();
        CheckStairsUnlockProgress();
        CheckGeneratorUnlockProgress();
        CheckWorkshopUnlockProgress();
        CheckLivingSpaceUnlockProgress();
        CheckResearchUnlockProgress();
    }
    #region Need To add visual Unlock images to the check button items
    private void CheckBedroomUnlockProgress()// Need to add visual presentation of unlocks
    {// this checks if these buildings are unlocked via click amounts and on lvl2 & 3 also checks if previous building is unlocked
        if (!GC.Bedroom_Lvl1_L)
        { if (GC.Bedroom_Lvl1_L_Clik_Unlock >= 50) { GC.Bedroom_Lvl1_L = true; } }// need to make the visual sprite change
        if (!GC.Bedroom_Lvl1_R)
        { if (GC.Bedroom_Lvl1_R_Clik_Unlock >= 50) { GC.Bedroom_Lvl1_R = true; } }
        if (!GC.Bedroom_Lvl2_L)
        { if (GC.Bedroom_Lvl2_L_Clik_Unlock >= 250 && GC.Workshop_Lvl2_L2) { GC.Bedroom_Lvl2_L = true; } }
        if (!GC.Bedroom_Lvl2_R)
        { if (GC.Bedroom_Lvl2_R_Clik_Unlock >= 250 && GC.Generator_Lvl2_R2) { GC.Bedroom_Lvl2_R = true; } }
        if (!GC.Bedroom_Lvl3_L)
        { if (GC.Bedroom_Lvl3_L_Clik_Unlock >= 1000 && GC.Research_Lvl3_L2) { GC.Bedroom_Lvl3_L = true; } }
        if (!GC.Bedroom_Lvl3_R)
        { if (GC.Bedroom_Lvl3_R_Clik_Unlock >= 1000 && GC.LivingSpace_Lvl3_R2) { GC.Bedroom_Lvl3_R = true; } }
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
            if (GC.Stairs_2 && GC.Player_Metal >= 50 && GC.Player_Wood >= 50 && GC.Player_Tech >= 50) { GC.Player_Metal -= 50; GC.Player_Wood -= 50;GC.Player_Tech -= 50; GC.Generator_Lvl2_R1 = true; }
        }
        if (!GC.Generator_Lvl2_R2)
        {
            if (GC.Generator_Lvl2_R1 && GC.Player_Metal >= 250 && GC.Player_Wood >= 250 && GC.Player_Tech >= 250) { GC.Player_Metal -= 250; GC.Player_Wood -= 250; GC.Player_Tech -= 250; GC.Generator_Lvl2_R2 = true; }
        }
    }
    private void CheckWorkshopUnlockProgress()// no visual unlock needs adding
    {
        if (!GC.Workshop_Lvl2_L1)
        {
            if (GC.Stairs_2 && GC.Player_Metal >= 50 && GC.Player_Wood >= 50 && GC.Player_Tech >= 50) { GC.Player_Metal -= 50; GC.Player_Wood -= 50; GC.Player_Tech -= 50; GC.Workshop_Lvl2_L1 = true; }
        }
        if (!GC.Workshop_Lvl2_L2)
        {
            if (GC.Workshop_Lvl2_L1 && GC.Player_Metal >= 250 && GC.Player_Wood >= 250 && GC.Player_Tech >= 250) { GC.Player_Metal -= 250; GC.Player_Wood -= 250; GC.Player_Tech -= 250; GC.Workshop_Lvl2_L2 = true; }
        }
    }
    private void CheckLivingSpaceUnlockProgress()// no visual unlock needs adding
    {
        if (!GC.LivingSpace_Lvl3_R1)
        {
            if (GC.Stairs_3 && GC.Player_Metal >= 500 && GC.Player_Wood >= 500 && GC.Player_Tech >= 500) { GC.Player_Metal -= 500; GC.Player_Wood -= 500; GC.Player_Tech -= 500; GC.LivingSpace_Lvl3_R1 = true; }
        }
        if (!GC.LivingSpace_Lvl3_R2)
        {
            if (GC.LivingSpace_Lvl3_R1 && GC.Player_Metal >= 1000 && GC.Player_Wood >= 1000 && GC.Player_Tech >= 1000) { GC.Player_Metal -= 1000; GC.Player_Wood -= 1000; GC.Player_Tech -= 1000; GC.LivingSpace_Lvl3_R2 = true; }
        }
    }
    private void CheckResearchUnlockProgress()// no visual unlock needs adding
    {
        if (!GC.Research_Lvl3_L1)
        {
            if (GC.Stairs_3 && GC.Player_Metal >= 500 && GC.Player_Wood >= 500 && GC.Player_Tech >= 500) { GC.Player_Metal -= 500; GC.Player_Wood -= 500; GC.Player_Tech -= 500; GC.Research_Lvl3_L1 = true; }
        }
        if (!GC.Research_Lvl3_L2)
        {
            if (GC.Research_Lvl3_L1 && GC.Player_Metal >= 1000 && GC.Player_Wood >= 1000 && GC.Player_Tech >= 1000) { GC.Player_Metal -= 1000; GC.Player_Wood -= 1000; GC.Player_Tech -= 1000; GC.Research_Lvl3_L2 = true; }
        }
    }
    #endregion
}
