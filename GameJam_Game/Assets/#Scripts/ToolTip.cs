using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ToolTip : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private GameController GC;
    public GameObject tooltipGameObject;
    [SerializeField] internal enum Type { Expedition, Training, Garden, Radio, Generator_1, Generator_2, Workshop_1, Workshop_2, Research_1,Research_2, Living_1,Living_2, Bedroom_Lv1_Left, Bedroom_Lv1_Right, Bedroom_Lv2_Left, Bedroom_Lv2_Right, Bedroom_Lv3_Left, Bedroom_Lv3_Right, Stairs_2,Stairs_3, Wall, TutorialMessage };
    [SerializeField] internal Type type;
    private Text txt_Task,txt_Metal,txt_Wood,txt_Tech,txt_Seeds,text_Science;
    private Text txt_Bonus;
    private float counter = 30;

    private void Start()
    {
        GC = GameObject.Find("GameController").GetComponent<GameController>();
        if (tooltipGameObject == null) { Debug.Log(this.gameObject); }
        tooltipGameObject.SetActive(false);
        SetElements();
        WriteElements();
    }
    private void Update()
    {
        counter -= Time.deltaTime;
        if (counter <= 0) { counter = 30; WriteElements();  }
    }
    private void SetElements()
    {
        txt_Bonus = tooltipGameObject.transform.GetChild(3).GetChild(0).GetChild(0).GetComponent<Text>();
        txt_Task = tooltipGameObject.transform.GetChild(2).GetChild(0).GetChild(0).GetComponent<Text>();
        txt_Metal = tooltipGameObject.transform.GetChild(2).GetChild(1).GetChild(0).GetComponent<Text>();
        txt_Wood = tooltipGameObject.transform.GetChild(2).GetChild(2).GetChild(0).GetComponent<Text>();
        txt_Tech = tooltipGameObject.transform.GetChild(2).GetChild(3).GetChild(0).GetComponent<Text>();
        txt_Seeds = tooltipGameObject.transform.GetChild(2).GetChild(4).GetChild(0).GetComponent<Text>();
        text_Science = tooltipGameObject.transform.GetChild(2).GetChild(5).GetChild(0).GetComponent<Text>();
    }
    private void WriteElements()
    {
        switch (type)
        {
            case Type.Expedition: GetData_Expedition();
                break;
            case Type.Training: GetData_Training();
                break;
            case Type.Garden: GetData_Garden();
                break;
            case Type.Radio: GetData_Radio();
                break;
            case Type.Generator_1: GetData_Generator_1();
                break;
            case Type.Generator_2: GetData_Generator_2();
                break;
            case Type.Workshop_1: GetData_Workshop_1();
                break;
            case Type.Workshop_2: GetData_Workshop_2();
                break;
            case Type.Research_1: GetData_Research_1();
                break;
            case Type.Research_2: GetData_Research_2();
                break;
            case Type.Living_1: GetData_Living_1();
                break;
            case Type.Living_2: GetData_Living_2();
                break;
            case Type.Bedroom_Lv1_Left: GetData_Bedroom_Lv1_Left();
                break;
            case Type.Bedroom_Lv1_Right: GetData_Bedroom_Lv1_Right();
                break;
            case Type.Bedroom_Lv2_Left: GetData_Bedroom_Lv2_Left();
                break;
            case Type.Bedroom_Lv2_Right: GetData_Bedroom_Lv2_Right();
                break;
            case Type.Bedroom_Lv3_Left: GetData_Bedroom_Lv3_Left();
                break;
            case Type.Bedroom_Lv3_Right: GetData_Bedroom_Lv3_Right();
                break;
            case Type.Stairs_2: GetData_Stairs_2();
                break;
            case Type.Stairs_3: GetData_Stairs_3();
                break;
            case Type.Wall: GetData_Wall();
                break;
        }
    }

    private void GetData_Wall()
    {//value_Wall_Tasks, value_Wall_Metal, value_Wall_Wood, value_Wall_Tech, value_Wall_Seeds, value_Wall_Science
        txt_Task.text = GC.value_Wall_Tasks.ToString();
        txt_Metal.text = GC.value_Wall_Metal.ToString();
        txt_Wood.text = GC.value_Wall_Wood.ToString();
        txt_Tech.text = GC.value_Wall_Tech.ToString();
        txt_Seeds.text = GC.value_Wall_Seeds.ToString();
        text_Science.text = GC.value_Wall_Science.ToString();
        txt_Bonus.text = "Defends people from being attacked & buildings being damaged";
    }

    private void GetData_Stairs_3()
    {
        txt_Task.text = GC.value_Stairs_3_Tasks.ToString();
        txt_Metal.text = GC.value_Stairs_3_Metal.ToString();
        txt_Wood.text = GC.value_Stairs_3_Wood.ToString();
        txt_Tech.text = GC.value_Stairs_3_Tech.ToString();
        txt_Seeds.text = GC.value_Stairs_3_Seeds.ToString();
        text_Science.text = GC.value_Stairs_3_Science.ToString();
        txt_Bonus.text = "Allows final tier buildings to be unlocked";
    }

    private void GetData_Stairs_2()
    {
        txt_Task.text = GC.value_Stairs_2_Tasks.ToString();
        txt_Metal.text = GC.value_Stairs_2_Metal.ToString();
        txt_Wood.text = GC.value_Stairs_2_Wood.ToString();
        txt_Tech.text = GC.value_Stairs_2_Tech.ToString();
        txt_Seeds.text = GC.value_Stairs_2_Seeds.ToString();
        text_Science.text = GC.value_Stairs_2_Science.ToString();
        txt_Bonus.text = "Allows tier 2 buildings to be unlocked";
    }

    private void GetData_Bedroom_Lv3_Right()
    {
        txt_Task.text = GC.value_Bedroom_Lvl3_R_Tasks.ToString();
        txt_Metal.text = GC.value_Bedroom_Lvl3_R_Metal.ToString();
        txt_Wood.text = GC.value_Bedroom_Lvl3_R_Wood.ToString();
        txt_Tech.text = GC.value_Bedroom_Lvl3_R_Tech.ToString();
        txt_Seeds.text = GC.value_Bedroom_Lvl3_R_Seeds.ToString();
        text_Science.text = GC.value_Bedroom_Lvl3_R_Science.ToString();
        txt_Bonus.text = "Allows higher capacity per upgrade";
    }

    private void GetData_Bedroom_Lv3_Left()
    {
        txt_Task.text = GC.value_Bedroom_Lvl3_L_Tasks.ToString();
        txt_Metal.text = GC.value_Bedroom_Lvl3_L_Metal.ToString();
        txt_Wood.text = GC.value_Bedroom_Lvl3_L_Wood.ToString();
        txt_Tech.text = GC.value_Bedroom_Lvl3_L_Tech.ToString();
        txt_Seeds.text = GC.value_Bedroom_Lvl3_L_Seeds.ToString();
        text_Science.text = GC.value_Bedroom_Lvl3_L_Science.ToString();
        txt_Bonus.text = "Allows higher capacity per upgrade";
    }

    private void GetData_Bedroom_Lv2_Right()
    {
        txt_Task.text = GC.value_Bedroom_Lvl2_R_Tasks.ToString();
        txt_Metal.text = GC.value_Bedroom_Lvl2_R_Metal.ToString();
        txt_Wood.text = GC.value_Bedroom_Lvl2_R_Wood.ToString();
        txt_Tech.text = GC.value_Bedroom_Lvl2_R_Tech.ToString();
        txt_Seeds.text = GC.value_Bedroom_Lvl2_R_Seeds.ToString();
        text_Science.text = GC.value_Bedroom_Lvl2_R_Science.ToString();
        txt_Bonus.text = "Allows higher capacity per upgrade";
    }

    private void GetData_Bedroom_Lv2_Left()
    {
        txt_Task.text = GC.value_Bedroom_Lvl2_L_Tasks.ToString();
        txt_Metal.text = GC.value_Bedroom_Lvl2_L_Metal.ToString();
        txt_Wood.text = GC.value_Bedroom_Lvl2_L_Wood.ToString();
        txt_Tech.text = GC.value_Bedroom_Lvl2_L_Tech.ToString();
        txt_Seeds.text = GC.value_Bedroom_Lvl2_L_Seeds.ToString();
        text_Science.text = GC.value_Bedroom_Lvl2_L_Science.ToString();
        txt_Bonus.text = "Allows higher capacity per upgrade";
    }

    private void GetData_Bedroom_Lv1_Right()
    {
        txt_Task.text = GC.value_Bedroom_Lvl1_R_Tasks.ToString();
        txt_Metal.text = GC.value_Bedroom_Lvl1_R_Metal.ToString();
        txt_Wood.text = GC.value_Bedroom_Lvl1_R_Wood.ToString();
        txt_Tech.text = GC.value_Bedroom_Lvl1_R_Tech.ToString();
        txt_Seeds.text = GC.value_Bedroom_Lvl1_R_Seeds.ToString();
        text_Science.text = GC.value_Bedroom_Lvl1_R_Science.ToString();
        txt_Bonus.text = "Allows higher capacity per upgrade";
    }

    private void GetData_Bedroom_Lv1_Left()
    {
        txt_Task.text = GC.value_Bedroom_Lvl1_L_Tasks.ToString();
        txt_Metal.text = GC.value_Bedroom_Lvl1_L_Metal.ToString();
        txt_Wood.text = GC.value_Bedroom_Lvl1_L_Wood.ToString();
        txt_Tech.text = GC.value_Bedroom_Lvl1_L_Tech.ToString();
        txt_Seeds.text = GC.value_Bedroom_Lvl1_L_Seeds.ToString();
        text_Science.text = GC.value_Bedroom_Lvl1_L_Science.ToString();
        txt_Bonus.text = "Allows higher capacity per upgrade";
    }

    private void GetData_Living_2()
    {
        txt_Task.text = GC.value_LivingSpace_2_Tasks.ToString();
        txt_Metal.text = GC.value_LivingSpace_2_Metal.ToString();
        txt_Wood.text = GC.value_LivingSpace_2_Wood.ToString();
        txt_Tech.text = GC.value_LivingSpace_2_Tech.ToString();
        txt_Seeds.text = GC.value_LivingSpace_2_Seeds.ToString();
        text_Science.text = GC.value_LivingSpace_2_Science.ToString();
        txt_Bonus.text = "New survivours need cartain comforts, livings spaces bring those comforts";
    }

    private void GetData_Living_1()
    {
        txt_Task.text = GC.value_LivingSpace_1_Tasks.ToString();
        txt_Metal.text = GC.value_LivingSpace_1_Metal.ToString();
        txt_Wood.text = GC.value_LivingSpace_1_Wood.ToString();
        txt_Tech.text = GC.value_LivingSpace_1_Tech.ToString();
        txt_Seeds.text = GC.value_LivingSpace_1_Seeds.ToString();
        text_Science.text = GC.value_LivingSpace_1_Science.ToString();
        txt_Bonus.text = "New survivours need cartain comforts, livings spaces bring those comforts";
    }

    private void GetData_Research_2()
    {
        txt_Task.text = GC.value_Research_2_Tasks.ToString();
        txt_Metal.text = GC.value_Research_2_Metal.ToString();
        txt_Wood.text = GC.value_Research_2_Wood.ToString();
        txt_Tech.text = GC.value_Research_2_Tech.ToString();
        txt_Seeds.text = GC.value_Research_2_Seeds.ToString();
        text_Science.text = GC.value_Research_2_Science.ToString();
        txt_Bonus.text = "Increases Tech Gathering Rate. Creates Science at a rate depending on upgrades";
    }

    private void GetData_Research_1()
    {
        txt_Task.text = GC.value_Research_1_Tasks.ToString();
        txt_Metal.text = GC.value_Research_1_Metal.ToString();
        txt_Wood.text = GC.value_Research_1_Wood.ToString();
        txt_Tech.text = GC.value_Research_1_Tech.ToString();
        txt_Seeds.text = GC.value_Research_1_Seeds.ToString();
        text_Science.text = GC.value_Research_1_Science.ToString();
        txt_Bonus.text = "Increases Tech Gathering Rate. Creates Science at a rate depending on upgrades";
    }

    private void GetData_Workshop_2()
    {
        txt_Task.text = GC.value_Workshop_2_Tasks.ToString();
        txt_Metal.text = GC.value_Workshop_2_Metal.ToString();
        txt_Wood.text = GC.value_Workshop_2_Wood.ToString();
        txt_Tech.text = GC.value_Workshop_2_Tech.ToString();
        txt_Seeds.text = GC.value_Workshop_2_Seeds.ToString();
        text_Science.text = GC.value_Workshop_2_Science.ToString();
        txt_Bonus.text = "Increases Wood Gathering Rate";
    }

    private void GetData_Workshop_1()
    {
        txt_Task.text = GC.value_Workshop_1_Tasks.ToString();
        txt_Metal.text = GC.value_Workshop_1_Metal.ToString();
        txt_Wood.text = GC.value_Workshop_1_Wood.ToString();
        txt_Tech.text = GC.value_Workshop_1_Tech.ToString();
        txt_Seeds.text = GC.value_Workshop_1_Seeds.ToString();
        text_Science.text = GC.value_Workshop_1_Science.ToString();
        txt_Bonus.text = "Increases Wood Gathering Rate";
    }

    private void GetData_Generator_2()
    {
        txt_Task.text = GC.value_Generator_2_Tasks.ToString();
        txt_Metal.text = GC.value_Generator_2_Metal.ToString();
        txt_Wood.text = GC.value_Generator_2_Wood.ToString();
        txt_Tech.text = GC.value_Generator_2_Tech.ToString();
        txt_Seeds.text = GC.value_Generator_2_Seeds.ToString();
        text_Science.text = GC.value_Generator_2_Science.ToString();
        txt_Bonus.text = "Increases Metal Gathering Rate";
    }

    private void GetData_Generator_1()
    {
        txt_Task.text = GC.value_Generator_1_Tasks.ToString();
        txt_Metal.text = GC.value_Generator_1_Metal.ToString();
        txt_Wood.text = GC.value_Generator_1_Wood.ToString();
        txt_Tech.text = GC.value_Generator_1_Tech.ToString();
        txt_Seeds.text = GC.value_Generator_1_Seeds.ToString();
        text_Science.text = GC.value_Generator_1_Science.ToString();
        txt_Bonus.text = "Increases Metal Gathering Rate";
    }

    private void GetData_Radio()
    {
        txt_Task.text = GC.value_Radio_Tasks.ToString();
        txt_Metal.text = GC.value_Radio_Metal.ToString();
        txt_Wood.text = GC.value_Radio_Wood.ToString();
        txt_Tech.text = GC.value_Radio_Tech.ToString();
        txt_Seeds.text = GC.value_Radio_Seeds.ToString();
        text_Science.text = GC.value_Radio_Science.ToString();
        txt_Bonus.text = "Upgrading the Radio will increase the frequency of more survivours requesting to join";
    }

    private void GetData_Garden()
    {
        txt_Task.text = GC.value_Garden_Tasks.ToString();
        txt_Metal.text = GC.value_Garden_Metal.ToString();
        txt_Wood.text = GC.value_Garden_Wood.ToString();
        txt_Tech.text = GC.value_Garden_Tech.ToString();
        txt_Seeds.text = GC.value_Garden_Seeds.ToString();
        text_Science.text = GC.value_Garden_Science.ToString();
        txt_Bonus.text = "Upgrading the Garden will gather food automatically, survivours need to eat 10 food items per day";
    }

    private void GetData_Training()
    {
        txt_Task.text = GC.value_Training_Tasks.ToString();
        txt_Metal.text = GC.value_Training_Metal.ToString();
        txt_Wood.text = GC.value_Training_Wood.ToString();
        txt_Tech.text = GC.value_Training_Tech.ToString();
        txt_Seeds.text = GC.value_Training_Seeds.ToString();
        text_Science.text = GC.value_Training_Science.ToString();
        txt_Bonus.text = "Upgrading the Training area will increase your scouts ability to bring back items more frequently on expeditions";
    }

    private void GetData_Expedition()
    {
        txt_Task.text = GC.value_Expedition_Tasks.ToString();
        txt_Metal.text = GC.value_Expedition_Metal.ToString();
        txt_Wood.text = GC.value_Expedition_Wood.ToString();
        txt_Tech.text = GC.value_Expedition_Tech.ToString();
        txt_Seeds.text = GC.value_Expedition_Seeds.ToString();
        text_Science.text = GC.value_Expedition_Science.ToString();
        txt_Bonus.text = "Upgrades increase the Expeditions per turn, you could potentially find a safe haven to settle a new settlement";
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tooltipGameObject.SetActive(true);
        WriteElements();
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        tooltipGameObject.SetActive(false);
    }
}
