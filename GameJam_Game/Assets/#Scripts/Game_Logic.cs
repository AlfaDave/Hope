using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Logic : MonoBehaviour
{
    [SerializeField] internal GameObject res_Metal, res_Wood, res_Food, res_Tech;
    [SerializeField] internal GameObject hatch, wall_Left, wall_Right, stairs_1, stairs_2, stairs_3, room_Top_Left_1, room_Top_Left_2, room_Top_Right_1, room_Top_Right_2, room_Mid_Left_1, room_Mid_Left_2, room_Mid_Right_1, room_Mid_Right_2, room_Bot_Left_1, room_Bot_Left_2, room_Bot_Right_1, room_Bot_Right_2, bedroom_Top_Left, bedroom_Top_Right, bedroom_Mid_Left, bedroom_Mid_Right, bedroom_Bot_Left, bedroom_Bot_Right;
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
    private Button room_Top_Left_1_Button, room_Top_Left_2_Button, room_Top_Right_1_Button, room_Top_Right_2_Button, room_Mid_Left_1_Button, room_Mid_Left_2_Button, room_Mid_Right_1_Button, room_Mid_Right_2_Button, room_Bot_Left_1_Button, room_Bot_Left_2_Button, room_Bot_Right_1_Button, room_Bot_Right_2_Button, bedroom_Top_Left_Button, bedroom_Top_Right_Button, bedroom_Mid_Left_Button, bedroom_Mid_Right_Button, bedroom_Bot_Left_Button, bedroom_Bot_Right_Button;
    #endregion

    private float WaitClickTime = 5;
    private float WaitResearchBonus = 0;
    private float WaitWorkshopBonus = 0;
    private float WaitPowerGenBonus = 0;

    private void CheckClickWaitingTime()
    {

    }
    private void Start()
    {
        LinkButtons();
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
        room_Top_Left_1_Button = room_Top_Left_1.transform.GetChild(0).GetComponent<Button>();
        room_Top_Left_2_Button = room_Top_Left_2.transform.GetChild(0).GetComponent<Button>();
        room_Top_Right_1_Button = room_Top_Right_1.transform.GetChild(0).GetComponent<Button>();
        room_Top_Right_2_Button = room_Top_Right_2.transform.GetChild(0).GetComponent<Button>();
        room_Mid_Left_1_Button = room_Mid_Left_1.transform.GetChild(0).GetComponent<Button>();
        room_Mid_Left_2_Button = room_Mid_Left_2.transform.GetChild(0).GetComponent<Button>();
        room_Mid_Right_1_Button = room_Mid_Right_1.transform.GetChild(0).GetComponent<Button>();
        room_Mid_Right_2_Button = room_Mid_Right_2.transform.GetChild(0).GetComponent<Button>();
        room_Bot_Left_1_Button = room_Bot_Left_1.transform.GetChild(0).GetComponent<Button>();
        room_Bot_Left_2_Button = room_Bot_Left_2.transform.GetChild(0).GetComponent<Button>();
        room_Bot_Right_1_Button = room_Bot_Right_1.transform.GetChild(0).GetComponent<Button>();
        room_Bot_Right_2_Button = room_Bot_Right_2.transform.GetChild(0).GetComponent<Button>();
        bedroom_Top_Left_Button = bedroom_Top_Left.transform.GetChild(0).GetComponent<Button>();
        bedroom_Top_Right_Button = bedroom_Top_Right.transform.GetChild(0).GetComponent<Button>();
        bedroom_Mid_Left_Button = bedroom_Mid_Left.transform.GetChild(0).GetComponent<Button>();
        bedroom_Mid_Right_Button = bedroom_Mid_Right.transform.GetChild(0).GetComponent<Button>();
        bedroom_Bot_Left_Button = bedroom_Bot_Left.transform.GetChild(0).GetComponent<Button>();
        bedroom_Bot_Right_Button = bedroom_Bot_Right.transform.GetChild(0).GetComponent<Button>();
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
        room_Top_Left_1_Button.interactable = false;
        room_Top_Left_2_Button.interactable = false;
        room_Top_Right_1_Button.interactable = false;
        room_Top_Right_2_Button.interactable = false;
        room_Mid_Left_1_Button.interactable = false;
        room_Mid_Left_2_Button.interactable = false;
        room_Mid_Right_1_Button.interactable = false;
        room_Mid_Right_2_Button.interactable = false;
        room_Bot_Left_1_Button.interactable = false;
        room_Bot_Left_2_Button.interactable = false;
        room_Bot_Right_1_Button.interactable = false;
        room_Bot_Right_2_Button.interactable = false;
        bedroom_Top_Left_Button.interactable = false;
        bedroom_Top_Right_Button.interactable = false;
        bedroom_Mid_Left_Button.interactable = false;
        bedroom_Mid_Right_Button.interactable = false;
        bedroom_Bot_Left_Button.interactable = false;
        bedroom_Bot_Right_Button.interactable = false;
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
        room_Top_Left_1_Button.interactable = false;
        room_Top_Left_2_Button.interactable = false;
        room_Top_Right_1_Button.interactable = false;
        room_Top_Right_2_Button.interactable = false;
        room_Mid_Left_1_Button.interactable = false;
        room_Mid_Left_2_Button.interactable = false;
        room_Mid_Right_1_Button.interactable = false;
        room_Mid_Right_2_Button.interactable = false;
        room_Bot_Left_1_Button.interactable = false;
        room_Bot_Left_2_Button.interactable = false;
        room_Bot_Right_1_Button.interactable = false;
        room_Bot_Right_2_Button.interactable = false;
        bedroom_Top_Left_Button.interactable = false;
        bedroom_Top_Right_Button.interactable = false;
        bedroom_Mid_Left_Button.interactable = false;
        bedroom_Mid_Right_Button.interactable = false;
        bedroom_Bot_Left_Button.interactable = false;
        bedroom_Bot_Right_Button.interactable = false;
    }
    private void CheckStairUnlockProgress()
    {
        
    }
    private void CheckRoomUnlockProgress()
    {

    }
    private void CheckRoomStatus()
    {

    }
}
