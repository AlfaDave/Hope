using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Logic : MonoBehaviour
{
    private GameController GC;
    private SoundManager SM;
    private SaveGame gSave;
    [SerializeField] internal GameObject display_Res_Progress, display_Res_Items;
    private GameObject display_Res_Turns, display_Res_Tasks, display_Res_People, display_Res_Science;
    private GameObject display_Res_Food, display_Res_Metal, display_Res_Wood, display_Res_Tech, display_Res_Seeds, display_Res_SpareParts;
    private Text display_Text_Res_Turns_Shadow, display_Text_Res_Tasks_Shadow, display_Text_Res_People_Shadow, display_Text_Res_Capacity_Shadow, display_Text_Res_Science_Shadow;
    private Text display_Text_Res_Food_Shadow, display_Text_Res_Metal_Shadow, display_Text_Res_Wood_Shadow, display_Text_Res_Tech_Shadow, display_Text_Res_Seeds_Shadow, display_Text_Res_SpareParts_Shadow;
    private Text display_Text_Res_Turns, display_Text_Res_Tasks, display_Text_Res_People, display_Text_Res_Capacity, display_Text_Res_Science;
    private Text display_Text_Res_Food, display_Text_Res_Metal, display_Text_Res_Wood, display_Text_Res_Tech, display_Text_Res_Seeds, display_Text_Res_SpareParts;
    [SerializeField] internal GameObject res_Metal, res_Wood, res_Food, res_Tech;
    [SerializeField] internal GameObject hatch, wall_Left, wall_Right, stairs_1, stairs_2, stairs_3;
    [SerializeField] internal GameObject underGarden_Lvl1_L1, radio_Lvl1_L2, expedition_Lvl1_R1, training_Lvl1_R2, workshop_Lvl2_L1, workshop_Lvl2_L2, generator_Lvl2_R1, generator_Lvl2_R2, research_Lvl3_L1, research_Lvl3_L2, livingSpace_Lvl3_R1, livingSpace_Lvl3_R2, bedroom_Lvl1_L, bedroom_Lvl1_R, bedroom_Lvl2_L, bedroom_Lvl2_R, bedroom_Lvl3_L, bedroom_Lvl3_R;
    #region Buttons for gathering
    private Button res_Metal_Button, res_Wood_Button, res_Food_Button, res_Tech_Button;
    private GameObject res_Metal_Wait, res_Wood_Wait, res_Food_Wait, res_Tech_Wait;
    private Text res_Metal_Wait_Text, res_Wood_Wait_Text, res_Food_Wait_Text, res_Tech_Wait_Text;
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
    #region End Turn Button
    public GameObject endTurn;
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
    private GameObject stairs_1_Unlocked, stairs_2_Locked, stairs_2_Unlocked, stairs_3_Locked, stairs_3_Unlocked;
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
    private float wait_Button_Defaults = 6;
    private float wait_Button_Metal;
    private float wait_Button_Wood;
    private float wait_Button_Food;
    private float wait_Button_Tech;
    private float tempMetal, tempWood, tempFood, tempTech;
    //private float WaitResearchBonus = 0;
    //private float WaitWorkshopBonus = 0;
    //private float WaitPowerGenBonus = 0;
    //private float WaitLivingSpace = 0;
    private int purchaseValue = 50;
    public GameObject exitGame, exitGameButton, exitCancelButton, exitProceedButton;
    public GameObject endTurnUi, endTurnUi_Display, endTurnUi_GameOver, endTurnUi_Win;
    public Text endTurnFoodConsumption, endTurnCivStarved, endTurnCivKilled, endTurnFoundSeeds, endTurnFoundGuides, endTurnFoundSpareParts, endTurnSuvivourFound, endTurnSuvivourThinks;
    public GameObject shortResSeedsMaster, shortResScienceMaster;
    private bool shortResSeeds = false, shortResScience = false;
    private float shortResSeedsTimer = 1, shortResScienceTimer = 1;

    private string intro = "From the dusts of the unforgiven may bring life and hope to the remaining few", intro_2 = "Once they were billions now there are few";
    private string intro_3 = "Dad why did the big people in charge attack everyone", intro_4 = "Son i can't answer that question, sometimes people chase after greed and power over living in harmony and for peace", intro_5 = "My son we will survive and we will rebuild a better life";
    [SerializeField] internal Text dailyMessage_Text, dailyMessageShadow_Text;
    private string dailyMessage;
    private string dailyMes_1, dailyMes_2, dailyMes_3, dailyMes_4, dailyMes_5, dailyMes_6, dailyMes_7, dailyMes_8, dailyMes_9, dailyMes_10, dailyMes_11, dailyMes_12, dailyMes_13, dailyMes_14, dailyMes_15, dailyMes_16, dailyMes_17, dailyMes_18, dailyMes_19, dailyMes_20;
    private void Start()
    {
        
        FindAllStatics();
        gSave.LoadingGame();
        LinkAllItemsInGame(); // these extra functions are just used to logically track the game logic steps
        //
        TurnOffUnwantedItems(); // these extra functions are just used to logically track the game logic steps
        //
        if (!GC.PlayerSave) { SetDefaults(); }
        TurnOnAllVitalInitialItems();
        //
        CheckRoomUnlockProgress();
        DiplayUiStats();
        //CheatMode();
        //DiplayUiStats();
        //Turn();
        SetDailyMessages();
    }
    private void Update()
    {
        WaitTimers();
    }
    private void SetDailyMessages()
    {
        dailyMes_1 = "Son N:- Daddy, i wish i still had an ybox to play on, Dad:- Son N, so do we it would be much quieter....";
        dailyMes_2 = "Dad:- I think we should gather the resources to upgrade our Expedition room.";
        dailyMes_3 = "Mom:- Atleast we dont have to worry about our credit card debt anymore.";
        dailyMes_4 = "Son H:- Dad, should we start thinking about looking at building some beds as sleeping on the floor is getting cold.";
        dailyMes_5 = "Dad:- Mom, some extra beds could allow us to take in people if we find any.";
        dailyMes_6 = "Dad:- Family, i really think we should start building some walls or anything to block anything bad from getting in.";
        dailyMes_7 = "Son H:- Dad, do you still have skills to build a wall ????";
        dailyMes_8 = "Dad:- Son H, i can try. In worse case if it falls down it will still slow any enemy.";
        dailyMes_9 = "Wife:- Dad, im sure i spotted something in the distance when gathering food and water.";
        dailyMes_10 = "Dad:- Wife, im sure its nothing. but if it is something i best get this wall built.";
        dailyMes_11 = "Son N:- Mommy, I'm scared when i wake at night i hear sounds above us.";
        dailyMes_12 = "Mom:- Son N, Sweetie pie i'm sure it was nothing probably just some wild animals";
        dailyMes_13 = "Dad:- Family, i don't wish to alarm you but i have seen some very strange looking creatures out past the town.";
        dailyMes_14 = "Mom:- Dad, so i wasnt seeing things 5 days ago";
        dailyMes_15 = "Dad:- Wife, no im fairly sure its something. I suspect its nothing good.";
        dailyMes_16 = "Son H:- Dad, do you think our walls and hatch will keep anything bad out??";
        dailyMes_17 = "Dad:- Son H, i think we could make our walls stronger, but i do think it will be hard to break through";
        dailyMes_18 = "Son N:- Daddy, Are we safe??";
        dailyMes_19 = "Dad:- Son N, yes bud we are safe here.";
        dailyMes_20 = "Dad:- Family, I'm sure i have spotted campfire smoke last night, maybe there will be other survivours.";
    }
    private void SetMessageOfTheDay()
    {
        switch (GC.Player_Turns)
        {
            case 0:
                dailyMessage = dailyMes_1;
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;
            case 1:
                dailyMessage = dailyMes_2;
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;
            case 2:
                dailyMessage = dailyMes_3;
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;
            case 3:
                dailyMessage = dailyMes_4;
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;
            case 4:
                dailyMessage = dailyMes_5;
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;
            case 5:
                dailyMessage = dailyMes_6;
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;
            case 6:
                dailyMessage = dailyMes_7;
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;
            case 7:
                dailyMessage = dailyMes_8;
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;
            case 8:
                dailyMessage = dailyMes_9;
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;
            case 9:
                dailyMessage = dailyMes_10;
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;
            case 10:
                dailyMessage = dailyMes_11;
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;
            case 11:
                dailyMessage = dailyMes_12;
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;
            case 12:
                dailyMessage = dailyMes_13;
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;
            case 13:
                dailyMessage = dailyMes_14;
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;
            case 14:
                dailyMessage = dailyMes_15;
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;
            case 15:
                dailyMessage = dailyMes_16;
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;
            case 16:
                dailyMessage = dailyMes_17;
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;
            case 17:
                dailyMessage = dailyMes_18;
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;
            case 18:
                dailyMessage = dailyMes_19;
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;
            case 19:
                dailyMessage = dailyMes_20;
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;
            case 20:
                dailyMessage = "";
                dailyMessage_Text.text = dailyMessage;
                dailyMessageShadow_Text.text = dailyMessage;
                break;

        }
    }
    private void WaitTimers()
    {
        if (wait_Metal)
        {
            wait_Button_Metal -= Time.deltaTime;
            if (wait_Button_Metal <= 0) { wait_Button_Metal = 0; Unlock_Metal_Button(); }
        }
        if (wait_Wood)
        {
            wait_Button_Wood -= Time.deltaTime;
            if (wait_Button_Wood <= 0) { wait_Button_Wood = 0; Unlock_Wood_Button(); }
        }
        if (wait_Food)
        {
            wait_Button_Food -= Time.deltaTime;
            if (wait_Button_Food <= 0) { wait_Button_Food = 0; Unlock_Food_Button(); }
        }
        if (wait_Tech)
        {
            wait_Button_Tech -= Time.deltaTime;
            if (wait_Button_Tech <= 0) { wait_Button_Tech = 0; Unlock_Tech_Button(); }
        }
        if (shortResSeeds)
        {
            shortResSeedsTimer -= Time.deltaTime;
            if (shortResSeedsTimer <= 0) { shortResSeedsTimer = 1; shortResSeedsMaster.SetActive(false); }
        }
        if (shortResScience)
        {
            shortResScienceTimer -= Time.deltaTime;
            if (shortResScienceTimer <= 0) { shortResScienceTimer = 1; shortResScienceMaster.SetActive(false); }
        }
    }
    public void ExitGame()
    {
        SFX_Button();
        exitGameButton.SetActive(false);
        exitProceedButton.SetActive(true);
        exitCancelButton.SetActive(true);
        // pop up exit message
        // change to two buttons exit and cancel
    }
    public void ExitCancel()
    {
        SFX_Button();
        exitGameButton.SetActive(true);
        exitProceedButton.SetActive(false);
        exitCancelButton.SetActive(false);
    }
    public void FinalExitGame()
    {
        SFX_EndTurn();
        gSave.LoadLevel("Main");
    }
    public void Turn()
    {
        SFX_EndTurn();
        endTurn.SetActive(false);
        if (GC.Player_Turns <= 1) { GC.Player_People = 4;GC.Player_Capacity = 4; }
        GC.Player_Turns += 1;
        GC.Player_Tasks = 0;
        GC.Player_Tasks += GC.Player_People * 3;
        int i = GC.Player_People * 10;
        endTurnFoodConsumption.text = i.ToString();
        endTurnUi.SetActive(true); endTurnUi_Display.SetActive(false); endTurnUi_GameOver.SetActive(false); endTurnUi_Win.SetActive(false);
        StarvingPeople();
        Attacked();
        CivilianRequest();
        Expedition();
        DiplayUiStats();
        /*if (GC.Player_Turns > 1)
        {
            endTurnUi.SetActive(true); endTurnUi_Display.SetActive(false); endTurnUi_GameOver.SetActive(false); endTurnUi_Win.SetActive(false);
            StarvingPeople();
            Attacked();
            CivilianRequest();
            Expedition();
            DiplayUiStats();
        }*/
        DiplayUiStats();

        gSave.SavingGame();
        //public int AttackRisk { get; set; } <<< end of turn risk factor
        //public int SurvivourChance { get; set; } < end of turn chance new civilian
        //public int SurvivourNeeds { get; set; } <end of turn how picky a requesting civilian will be
        //public int BaseJoy { get; set; } <end of turn base joy which is what the above needs
        //public int ChanceOfSeeds { get; set; } <end of turn chance of new seeds
        //public int ChanceOfResearch { get; set; } < end of turn chance of new science
        //public int ChanceOfSettlement { get; set; } < end of turn win game chance
    }
    public void TurnOffEndOfTurnUi()
    {
        endTurnCivKilled.text = "";
        endTurnCivStarved.text = "";
        endTurnFoodConsumption.text = "";
        endTurnFoundGuides.text = "";
        endTurnFoundSeeds.text = "";
        endTurnFoundSpareParts.text = "0";
        endTurnSuvivourFound.text = "";
        endTurnSuvivourThinks.text = "";
        endTurnUi.SetActive(false); endTurnUi_Display.SetActive(false); endTurnUi_GameOver.SetActive(false); endTurnUi_Win.SetActive(false);
    }
    private void Attacked()
    {
        string value2 = "No Enemy Known";
        endTurnCivKilled.text = value2.ToString();
        if (GC.Wall_R)
        {
            switch (GC.Wall_R_Upg)
            {
                case 1:
                    GC.AttackRisk = 25;
                    break;
                case 2:
                    GC.AttackRisk = 23;
                    break;
                case 3:
                    GC.AttackRisk = 21;
                    break;
                case 4:
                    GC.AttackRisk = 19;
                    break;
                case 5:
                    GC.AttackRisk = 17;
                    break;
                case 6:
                    GC.AttackRisk = 15;
                    break;
                case 7:
                    GC.AttackRisk = 13;
                    break;
                case 8:
                    GC.AttackRisk = 11;
                    break;
                case 9:
                    GC.AttackRisk = 7;
                    break;
                case 10:
                    GC.AttackRisk = 5;
                    break;
            }
        }
        else
        {
            GC.AttackRisk = 27; // 1 in 4 chance of having a civilian killed
        }
        int i = UnityEngine.Random.Range(1,101);
        if (i >= GC.AttackRisk)
        {
            string value = "0 civilians Killed, Welldone";
            endTurnCivKilled.text = value.ToString();
        }
        else
        {
            // civilian killed
            if (GC.Player_Turns >= 20)
            {
                GC.Player_People -= 1;
                string value = "1 civilian Killed, focus more on wall improvements";
                endTurnCivKilled.text = value;
                if (GC.Player_People <= 0)
                {
                    endTurnUi.SetActive(true); endTurnUi_Display.SetActive(false); endTurnUi_GameOver.SetActive(true); endTurnUi_Win.SetActive(false);
                }
            }
            else
            {
                string value = "0 civilians Killed, Welldone";
                endTurnCivKilled.text = value.ToString();
            }
        }
    }
    private void CivilianRequest()
    {
        if (GC.Player_People < GC.Player_Capacity)
        {

            switch (GC.Radio_Upg_Lvl1_L2)
            {
                case 1:
                    GC.SurvivourChance = 5;
                    break;
                case 2:
                    GC.SurvivourChance = 10;
                    break;
                case 3:
                    GC.SurvivourChance = 15;
                    break;
                case 4:
                    GC.SurvivourChance = 20;
                    break;
                case 5:
                    GC.SurvivourChance = 25;
                    break;
            }
            GC.SurvivourNeeds = GC.Player_People;
            int i = UnityEngine.Random.Range(1, 101);
            if (i <= GC.SurvivourChance)
            {
                if (GC.BaseJoy > GC.SurvivourNeeds)
                {
                    if (GC.Player_Turns >= 20)
                    {
                        GC.Player_People += 1;
                        endTurnSuvivourFound.text = "1 survivour has joined us";
                        endTurnSuvivourThinks.text = "This Shelter is up to my standards";
                    }
                    else
                    {
                        endTurnSuvivourFound.text = "Unsure if any others have survived";
                        endTurnSuvivourThinks.text = "";
                    }
                }
                else
                {
                    if (GC.Player_Turns >= 20)
                    {
                        endTurnSuvivourFound.text = "1 survivour checked out our shelter";
                        endTurnSuvivourThinks.text = "This Shelter is a dump can't believe i wasted my time walking here..";
                    }
                    else
                    {
                        endTurnSuvivourFound.text = "Unsure if any others have survived";
                        endTurnSuvivourThinks.text = "";
                    }
                }
            }
            else
            {
                if (GC.Player_Turns >= 20)
                { 
                endTurnSuvivourFound.text = "0 survivours have found us, maybe we should look at upgrading our Radio equiptment";
                endTurnSuvivourThinks.text = "That we dont exist";
                }
                else
                {
                    endTurnSuvivourFound.text = "Unsure if any others have survived";
                    endTurnSuvivourThinks.text = "";
                }
            }
        }
    }
    private void Expedition()
    {
        switch (GC.Training_Upg_Lvl1_R2)
        {
            case 1:
                GC.ChanceOfSeeds = 5; // out of 100
                GC.ChanceOfResearch = 5; // out of 100
                GC.ChanceOfSettlement = 1; // out of 1000
                break;
            case 2:
                GC.ChanceOfSeeds = 7;
                GC.ChanceOfResearch = 7;
                GC.ChanceOfSettlement = 5; // out of 1000
                break;
            case 3:
                GC.ChanceOfSeeds = 9;
                GC.ChanceOfResearch = 9;
                GC.ChanceOfSettlement = 10; // out of 1000
                break;
            case 4:
                GC.ChanceOfSeeds = 11;
                GC.ChanceOfResearch = 11;
                GC.ChanceOfSettlement = 15; // out of 1000
                break;
            case 5:
                GC.ChanceOfSeeds = 13;
                GC.ChanceOfResearch = 13;
                GC.ChanceOfSettlement = 20; // out of 1000
                break;
        }
        int seeds = UnityEngine.Random.Range(1, 101);
        int research = UnityEngine.Random.Range(1, 101);
        int settlement = UnityEngine.Random.Range(1, 1001);
        int sparePartsChance = UnityEngine.Random.Range(1, 101);
        int spareParts = UnityEngine.Random.Range(1, 10);
        if (sparePartsChance >= 75) { GC.Player_SpareParts += spareParts; endTurnFoundSpareParts.text = spareParts.ToString(); }
        if (seeds <= GC.ChanceOfSeeds)
        {
            GC.Player_Seeds += 1; DiplayUiStats();
            int rand1 = UnityEngine.Random.Range(1, 4);
            switch (rand1)
            {
                case 1:
                    endTurnFoundSeeds.text = "We have found Fruit seeds.";
                    break;
                case 2:
                    endTurnFoundSeeds.text = "We have found Veg seeds.";
                    break;
                case 3:
                    endTurnFoundSeeds.text = "We have found Mutated seeds.";
                    break;
            }
        }
        else
        {
            endTurnFoundSeeds.text = "We didn't find any seeds..";
        }
        if (research <= GC.ChanceOfResearch)
        {
            GC.Player_Science += 1; DiplayUiStats();
            int rand2 = UnityEngine.Random.Range(1, 4);
            switch (rand2)
            {
                case 1:
                    endTurnFoundGuides.text = "We have found Radio Codes.";
                    break;
                case 2:
                    endTurnFoundGuides.text = "We have found Building techniques.";
                    break;
                case 3:
                    endTurnFoundGuides.text = "We have found How to survive for dummies.";
                    break;
            }
        }
        else
        {
            endTurnFoundGuides.text = "We didn't find any Guides";
        }
        if (settlement <= GC.ChanceOfSettlement)
        {
            endTurnUi.SetActive(true); endTurnUi_Display.SetActive(false); endTurnUi_GameOver.SetActive(false); endTurnUi_Win.SetActive(true);
            // display this to end of turn ui
        }
        else
        {
            endTurnUi.SetActive(true); endTurnUi_Display.SetActive(true);
            // display no settlement found
        }        
    }
    private void StarvingPeople()
    {
        GC.Starvation = false;
        if (GC.Player_Food < (GC.Player_People*10))
        {
            GC.Player_Food -= GC.Player_People * 10;
            if (GC.Player_Food <= 0) { GC.Player_Food = 0; }
            GC.Starvation = true;
            GC.Player_People -= 1;
            string value = "1 Shelter member starved, please focus more on food";
            endTurnCivStarved.text = value;
        }
        else
        {
            GC.Player_Food -= GC.Player_People * 10;
            string value = "0 civilians starved, Welldone";
            endTurnCivStarved.text = value;
        }
    }
    public void GameOverResetSaveFile()
    {
        SFX_Deny();
        GC.PlayerSave = false;
        gSave.SavingGame();
        gSave.LoadLevel("Main");
    }
    private void FindAllStatics()
    {
        gSave = GameObject.Find("GameSave").GetComponent<SaveGame>();
        GC = GameObject.Find("GameController").GetComponent<GameController>();
        SM = GameObject.Find("SoundManager").GetComponent<SoundManager>();
    }
    private void SetDefaults()
    {
        #region Default Buildings
        GC.Room_Radio = 1;
        GC.Room_Expedition = 1;
        GC.Room_UndergroundGarden = 1;
        GC.Room_Training = 1;
        #endregion
        #region Vault Heath Items
        GC.Vault_Health = 0;
        #endregion
        #region Vault Room Upgrades
        GC.Stairs_1 = true;
        GC.Stairs_2 = false;
        GC.Stairs_3 = false;
        GC.Stairs_2_Clicks_Unlock = 0;
        GC.Stairs_3_Clicks_Unlock = 0;
        /// <summary>
        /// Rooms are ordered in layers with left and right number 1 room is closest to the stairs
        /// </summary>
        GC.UnderGarden_Lvl1_L1 = true;
        GC.Radio_Lvl1_L2 = true;
        GC.Expedition_Lvl1_R1 = true;
        GC.Training_Lvl1_R2 = true;
        GC.Workshop_Lvl2_L1 = false;
        GC.Workshop_Lvl2_L2 = false;
        GC.Generator_Lvl2_R1 = false;
        GC.Generator_Lvl2_R2 = false;
        GC.Research_Lvl3_L1 = false;
        GC.Research_Lvl3_L2 = false;
        GC.LivingSpace_Lvl3_R1 = false;
        GC.LivingSpace_Lvl3_R2 = false;
        /// <summary>
        /// room Upgrade levels only 0 rock 1 first type of room 2 second type of room 3 third type of room
        /// </summary>
        GC.UnderGarden_Upg_Lvl1_L1 = 1;
        GC.Radio_Upg_Lvl1_L2 = 1;
        GC.Expedition_Upg_Lvl1_R1 = 1;
        GC.Training_Upg_Lvl1_R2 = 1;
        GC.Workshop_Upg_Lvl2_L1 = 0;
        GC.Workshop_Upg_Lvl2_L2 = 0;
        GC.Generator_Upg_Lvl2_R1 = 0;
        GC.Generator_Upg_Lvl2_R2 = 0;
        GC.Research_Upg_Lvl3_L1 = 0;
        GC.Research_Upg_Lvl3_L2 = 0;
        GC.LivingSpace_Upg_Lvl3_R1 = 0;
        GC.LivingSpace_Upg_Lvl3_R2 = 0;
        GC.Bedroom_Lvl1_L = false;
        GC.Bedroom_Lvl1_R = false;
        GC.Bedroom_Lvl2_L = false;
        GC.Bedroom_Lvl2_R = false;
        GC.Bedroom_Lvl3_L = false;
        GC.Bedroom_Lvl3_R = false;
        GC.Bedroom_Upg_Lvl1_L = 0;
        GC.Bedroom_Upg_Lvl1_R = 0;
        GC.Bedroom_Upg_Lvl2_L = 0;
        GC.Bedroom_Upg_Lvl2_R = 0;
        GC.Bedroom_Upg_Lvl3_L = 0;
        GC.Bedroom_Upg_Lvl3_R = 0;
        GC.Bedroom_Lvl1_L_Clik_Unlock = 0;
        GC.Bedroom_Lvl1_R_Clik_Unlock = 0;
        GC.Bedroom_Lvl2_L_Clik_Unlock = 0;
        GC.Bedroom_Lvl2_R_Clik_Unlock = 0;
        GC.Bedroom_Lvl3_L_Clik_Unlock = 0;
        GC.Bedroom_Lvl3_R_Clik_Unlock = 0;
        GC.Wall_L = false;
        GC.Wall_R = false;
        GC.Wall_L_Clik_Unlock = 0;
        GC.Wall_R_Clik_Unlock = 0;
        GC.Wall_L_Upg = 0;
        GC.Wall_R_Upg = 0;
        GC.Wall_L_Health = 0;
        GC.Wall_R_Health = 0;
        #endregion
        #region Main Game Stats
        GC.Player_Turns = 0;
        GC.Player_Tasks = 0;
        GC.Player_People = 4;
        GC.Player_Capacity = 4;
        GC.Player_Science = 0;
        #endregion
        #region Main Game Resources
        GC.Player_Food = 0;
        GC.Player_Metal = 0;
        GC.Player_Wood = 0;
        GC.Player_Tech = 0;
        GC.Player_Seeds = 0;
        GC.Player_SpareParts = 0;
        GC.AttackRisk = 0;
        GC.SurvivourChance = 0;
        GC.SurvivourNeeds = 0;
        GC.BaseJoy = 0;
        GC.ChanceOfSeeds = 0;
        GC.ChanceOfResearch = 0;
        GC.ChanceOfSettlement = 0;
        GC.Starvation = false;
        #endregion
        if (GC.Player_Capacity < 4) { GC.Player_Capacity = 4; }
        if (GC.Player_People >= GC.Player_Capacity) { GC.Player_People = GC.Player_Capacity; }
        GC.Player_Tasks = GC.Player_People * 4;
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
        //SetDefaults();
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
        GC.Player_SpareParts = 9999999;

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
        display_Text_Res_Metal.text = GC.Player_Metal.ToString();
        display_Text_Res_Wood.text = GC.Player_Wood.ToString();
        display_Text_Res_Food.text = GC.Player_Food.ToString();
        display_Text_Res_Tech.text = GC.Player_Tech.ToString();
        display_Text_Res_Seeds.text = GC.Player_Seeds.ToString();
        display_Text_Res_SpareParts.text = GC.Player_SpareParts.ToString();

        display_Text_Res_Turns_Shadow.text = GC.Player_Turns.ToString();
        display_Text_Res_Tasks_Shadow.text = GC.Player_Tasks.ToString();
        display_Text_Res_People_Shadow.text = GC.Player_People.ToString();
        display_Text_Res_Capacity_Shadow.text = GC.Player_Capacity.ToString();
        display_Text_Res_Science_Shadow.text = GC.Player_Science.ToString();
        display_Text_Res_Metal_Shadow.text = GC.Player_Metal.ToString();
        display_Text_Res_Wood_Shadow.text = GC.Player_Wood.ToString();
        display_Text_Res_Food_Shadow.text = GC.Player_Food.ToString();
        display_Text_Res_Tech_Shadow.text = GC.Player_Tech.ToString();
        display_Text_Res_Seeds_Shadow.text = GC.Player_Seeds.ToString();
        display_Text_Res_SpareParts_Shadow.text = GC.Player_SpareParts.ToString();
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
        display_Res_SpareParts = display_Res_Items.transform.GetChild(0).GetChild(4).gameObject;

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
        display_Text_Res_SpareParts = display_Res_SpareParts.transform.GetChild(2).GetComponent<Text>();
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
        display_Text_Res_SpareParts_Shadow = display_Res_SpareParts.transform.GetChild(2).GetChild(0).GetComponent<Text>();


        res_Metal_Wait = res_Metal.transform.GetChild(1).gameObject;
        res_Wood_Wait = res_Wood.transform.GetChild(1).gameObject;
        res_Food_Wait = res_Food.transform.GetChild(1).gameObject;
        res_Tech_Wait = res_Tech.transform.GetChild(1).gameObject;
        res_Metal_Wait_Text = res_Metal_Wait.transform.GetChild(1).GetComponent<Text>();
        res_Wood_Wait_Text = res_Wood_Wait.transform.GetChild(1).GetComponent<Text>();
        res_Food_Wait_Text = res_Food_Wait.transform.GetChild(1).GetComponent<Text>();
        res_Tech_Wait_Text = res_Tech_Wait.transform.GetChild(1).GetComponent<Text>();
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
        stairs_1_Unlocked = stairs_1.transform.GetChild(1).gameObject;
        stairs_2_Locked = stairs_2.transform.GetChild(2).gameObject;
        stairs_2_Unlocked = stairs_2.transform.GetChild(3).gameObject;
        stairs_3_Locked = stairs_3.transform.GetChild(2).gameObject;
        stairs_3_Unlocked = stairs_3.transform.GetChild(3).gameObject;
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
        res_Metal_Button.interactable = true;
        res_Wood_Button.interactable = true;
        res_Food_Button.interactable = true;
        res_Tech_Button.interactable = true;
        hatch_Button.interactable = true;
        wall_Left_Button.interactable = true;
        wall_Right_Button.interactable = true;
        stairs_1_Button.interactable = true;
        stairs_2_Button.interactable = true;
        stairs_3_Button.interactable = true;
        underGarden_Lvl1_L1_Button.interactable = true;
        radio_Lvl1_L2_Button.interactable = true;
        expedition_Lvl1_R1_Button.interactable = true;
        training_Lvl1_R2_Button.interactable = true;
        workshop_Lvl2_L1_Button.interactable = true;
        workshop_Lvl2_L2_Button.interactable = true;
        generator_Lvl2_R1_Button.interactable = true;
        generator_Lvl2_R2_Button.interactable = true;
        research_Lvl3_L1_Button.interactable = true;
        research_Lvl3_L2_Button.interactable = true;
        livingSpace_Lvl3_R1_Button.interactable = true;
        livingSpace_Lvl3_R2_Button.interactable = true;
        bedroom_lvl1_L_Button.interactable = true;
        bedroom_Lvl1_R_Button.interactable = true;
        bedroom_Lvl2_L_Button.interactable = true;
        bedroom_Lvl2_R_Button.interactable = true;
        bedroom_Lvl3_L_Button.interactable = true;
        bedroom_Lvl3_R_Button.interactable = true;
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
    private void NextTurnItems()
    {
        SetMessageOfTheDay();
        endTurn.SetActive(true);
    }
    // Calculations for the wait time after pressing a gathering resource
    #region Gathering resources
    public void Gather_Metal()
    {
        if (GC.Player_Tasks >= 1)
        {
            SFX_Gather();
            GC.Player_Metal += 10;
            GC.Player_Tasks -= 1;
            DiplayUiStats();
            Lock_Metal_Button();
            Calculate_Wait_Metal();
            if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); }
        }
        else
        {
            SFX_Deny();
            // no turns left 
            NextTurnItems();
        }
    }
    public void Gather_Wood()
    {
        if (GC.Player_Tasks >= 1)
        {
            SFX_Gather();
            GC.Player_Wood += 10;
            GC.Player_Tasks -= 1;
            DiplayUiStats();
            Lock_Wood_Button();
            Calculate_Wait_Wood();
            if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); }
        }
        else
        {
            SFX_Deny();
            // no turns left 
            NextTurnItems();
        }
    }
    public void Gather_Food()
    {
        if (GC.Player_Tasks >= 1)
        {
            SFX_Gather();
            GC.Player_Food += 10;
            GC.Player_Tasks -= 1;
            DiplayUiStats();
            Lock_Food_Button();
            Calculate_Wait_Food();
            if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); }
        }
        else
        {
            SFX_Deny();
            // no turns left 
            NextTurnItems();
        }
    }
    public void Gather_Tech()
    {
        if (GC.Player_Tasks >= 1)
        {
            SFX_Gather();
            GC.Player_Tech += 10;
            GC.Player_Tasks -= 1;
            DiplayUiStats();
            Lock_Tech_Button();
            Calculate_Wait_Tech();
            if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); }
        }
        else
        {
            SFX_Deny();
            // no turns left 
            NextTurnItems();
        }
    }
    private void Get_Layer_1_Building_Bonus(int building)
    {
        if (building == 1)// Generator metal
        {
            tempMetal = 0;
            switch (GC.Generator_Upg_Lvl2_R1)
            {
                case 1: tempMetal = 0.5f; break;
                case 2: tempMetal = 1.0f; break;
                case 3: tempMetal = 1.5f; break;
                case 4: tempMetal = 2.0f; break;
                case 5: tempMetal = 2.5f; break;
            }
        }
        else if (building == 2) // Workshop wood
        {
            tempWood = 0;
            switch (GC.Workshop_Upg_Lvl2_L1)
            {
                case 1: tempWood = 0.5f; break;
                case 2: tempWood = 1.0f; break;
                case 3: tempWood = 1.5f; break;
                case 4: tempWood = 2.0f; break;
                case 5: tempWood = 2.5f; break;
            }

        }
        else if (building == 3) // LivingSpace food
        {
            tempFood = 0;
            switch (GC.LivingSpace_Upg_Lvl3_R1)
            {
                case 1: tempFood = 0.5f; break;
                case 2: tempFood = 1.0f; break;
                case 3: tempFood = 1.5f; break;
                case 4: tempFood = 2.0f; break;
                case 5: tempFood = 2.5f; break;
            }

        }
        else if (building == 4) // Research tech
        {
            tempTech = 0;
            switch (GC.Research_Upg_Lvl3_L1)
            {
                case 1: tempTech = 0.5f; break;
                case 2: tempTech = 1.0f; break;
                case 3: tempTech = 1.5f; break;
                case 4: tempTech = 2.0f; break;
                case 5: tempTech = 2.5f; break;
            }
        }
    }
    private void Get_Layer_2_Building_Bonus(int building)
    {
        if (building == 1)// Generator
        {
            switch (GC.Generator_Upg_Lvl2_R2)
            {
                case 1: tempMetal = 0.5f; break;
                case 2: tempMetal = 1.0f; break;
                case 3: tempMetal = 1.5f; break;
                case 4: tempMetal = 2.0f; break;
                case 5: tempMetal = 2.5f; break;
            }
        }
        else if (building == 2) // Workshop
        {
            switch (GC.Workshop_Upg_Lvl2_L2)
            {
                case 1: tempWood = 0.5f; break;
                case 2: tempWood = 1.0f; break;
                case 3: tempWood = 1.5f; break;
                case 4: tempWood = 2.0f; break;
                case 5: tempWood = 2.5f; break;
            }

        }
        else if (building == 3) // LivingSpace
        {
            switch (GC.LivingSpace_Upg_Lvl3_R2)
            {
                case 1: tempFood = 0.5f; break;
                case 2: tempFood = 1.0f; break;
                case 3: tempFood = 1.5f; break;
                case 4: tempFood = 2.0f; break;
                case 5: tempFood = 2.5f; break;
            }

        }
        else if (building == 4) // Research
        {
            switch (GC.Research_Upg_Lvl3_L2)
            {
                case 1: tempTech = 0.5f; break;
                case 2: tempTech = 1.0f; break;
                case 3: tempTech = 1.5f; break;
                case 4: tempTech = 2.0f; break;
                case 5: tempTech = 2.5f; break;
            }
        }
    } 
    private void Calculate_Wait_Metal()
    {
        wait_Button_Metal = 0;
        Get_Layer_1_Building_Bonus(1);
        wait_Button_Metal = wait_Button_Defaults -= tempMetal;
        tempMetal = 0;

        Get_Layer_2_Building_Bonus(1);
        wait_Button_Metal = wait_Button_Metal -= tempMetal;
        tempMetal = 0;
        res_Metal_Wait.SetActive(true);
        res_Metal_Wait_Text.text = wait_Button_Metal.ToString()+ " Seconds";
    }
    private void Calculate_Wait_Wood()
    {
        wait_Button_Wood = 0;
        Get_Layer_1_Building_Bonus(2);
        wait_Button_Wood = wait_Button_Defaults -= tempWood;
        tempWood = 0;

        Get_Layer_2_Building_Bonus(2);
        wait_Button_Wood = wait_Button_Wood -= tempWood;
        tempWood = 0;
        res_Wood_Wait.SetActive(true);
        res_Wood_Wait_Text.text = wait_Button_Wood.ToString() + " Seconds";
    }
    private void Calculate_Wait_Food()
    {
        wait_Button_Food = 0;
        Get_Layer_1_Building_Bonus(3);
        wait_Button_Food = wait_Button_Defaults -= tempFood;
        tempFood = 0;

        Get_Layer_2_Building_Bonus(3);
        wait_Button_Food = wait_Button_Food -= tempFood;
        tempFood = 0;
        res_Food_Wait.SetActive(true);
        res_Food_Wait_Text.text = wait_Button_Food.ToString() + " Seconds";
    }
    private void Calculate_Wait_Tech()
    {
        wait_Button_Tech = 0;
        Get_Layer_1_Building_Bonus(4);
        wait_Button_Tech = wait_Button_Defaults -= tempTech;
        tempTech = 0;

        Get_Layer_2_Building_Bonus(4);
        wait_Button_Tech = wait_Button_Tech -= tempTech;
        tempTech = 0;
        res_Tech_Wait.SetActive(true);
        res_Tech_Wait_Text.text = wait_Button_Tech.ToString() + " Seconds";
    }

    private void Unlock_Metal_Button()
    {
        wait_Metal = false;
        res_Metal_Wait.SetActive(false);
        res_Metal_Button.enabled = true;
    }
    private void Lock_Metal_Button()
    {
        wait_Metal = true;
        res_Metal_Button.enabled = false;
    }
    private void Unlock_Wood_Button()
    {
        wait_Wood = false;
        res_Wood_Wait.SetActive(false);
        res_Wood_Button.enabled = true;
    }
    private void Lock_Wood_Button()
    {
        wait_Wood = true;
        res_Wood_Button.enabled = false;
    }
    private void Unlock_Food_Button()
    {
        wait_Food = false;
        res_Food_Wait.SetActive(false);
        res_Food_Button.enabled = true;
    }
    private void Lock_Food_Button()
    {
        wait_Food = true;
        res_Food_Button.enabled = false;
    }
    private void Unlock_Tech_Button()
    {
        wait_Tech = false;
        res_Tech_Wait.SetActive(false);
        res_Tech_Button.enabled = true;
    }
    private void Lock_Tech_Button()
    {
        wait_Tech = true;
        res_Tech_Button.enabled = false;
    }
    
    #endregion
    #region Set GameControl Resources for tool tips
    private void SetGCResourceValues_Expedition(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_Expedition_Tasks = value_Tasks;
        GC.value_Expedition_Metal = value_Metal;
        GC.value_Expedition_Wood = value_Wood;
        GC.value_Expedition_Tech = value_Tech;
        GC.value_Expedition_Seeds = value_Seeds;
        GC.value_Expedition_Science = value_Science;
        DiplayUiStats();
    }
    private void SetGCResourceValues_Training(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_Training_Tasks = value_Tasks;
        GC.value_Training_Metal = value_Metal;
        GC.value_Training_Wood = value_Wood;
        GC.value_Training_Tech = value_Tech;
        GC.value_Training_Seeds = value_Seeds;
        GC.value_Training_Science = value_Science;
        DiplayUiStats();
    }
    private void SetGCResourceValues_Garden(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_Garden_Tasks = value_Tasks;
        GC.value_Garden_Metal = value_Metal;
        GC.value_Garden_Wood = value_Wood;
        GC.value_Garden_Tech = value_Tech;
        GC.value_Garden_Seeds = value_Seeds;
        GC.value_Garden_Science = value_Science;
        DiplayUiStats();
    }
    private void SetGCResourceValues_Radio(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_Radio_Tasks = value_Tasks;
        GC.value_Radio_Metal = value_Metal;
        GC.value_Radio_Wood = value_Wood;
        GC.value_Radio_Tech = value_Tech;
        GC.value_Radio_Seeds = value_Seeds;
        GC.value_Radio_Science = value_Science;
        DiplayUiStats();
    }
    private void SetGCResourceValues_Generator_1(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_Generator_1_Tasks = value_Tasks;
        GC.value_Generator_1_Metal = value_Metal;
        GC.value_Generator_1_Wood = value_Wood;
        GC.value_Generator_1_Tech = value_Tech;
        GC.value_Generator_1_Seeds = value_Seeds;
        GC.value_Generator_1_Science = value_Science;
        DiplayUiStats();
    }
    private void SetGCResourceValues_Generator_2(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_Generator_2_Tasks = value_Tasks;
        GC.value_Generator_2_Metal = value_Metal;
        GC.value_Generator_2_Wood = value_Wood;
        GC.value_Generator_2_Tech = value_Tech;
        GC.value_Generator_2_Seeds = value_Seeds;
        GC.value_Generator_2_Science = value_Science;
        DiplayUiStats();
    }
    private void SetGCResourceValues_Workshop_1(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_Workshop_1_Tasks = value_Tasks;
        GC.value_Workshop_1_Metal = value_Metal;
        GC.value_Workshop_1_Wood = value_Wood;
        GC.value_Workshop_1_Tech = value_Tech;
        GC.value_Workshop_1_Seeds = value_Seeds;
        GC.value_Workshop_1_Science = value_Science;
        DiplayUiStats();
    }
    private void SetGCResourceValues_Workshop_2(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_Workshop_2_Tasks = value_Tasks;
        GC.value_Workshop_2_Metal = value_Metal;
        GC.value_Workshop_2_Wood = value_Wood;
        GC.value_Workshop_2_Tech = value_Tech;
        GC.value_Workshop_2_Seeds = value_Seeds;
        GC.value_Workshop_2_Science = value_Science;
        DiplayUiStats();
    }
    private void SetGCResourceValues_LivingSpace_1(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_LivingSpace_1_Tasks = value_Tasks;
        GC.value_LivingSpace_1_Metal = value_Metal;
        GC.value_LivingSpace_1_Wood = value_Wood;
        GC.value_LivingSpace_1_Tech = value_Tech;
        GC.value_LivingSpace_1_Seeds = value_Seeds;
        GC.value_LivingSpace_1_Science = value_Science;
        DiplayUiStats();
    }
    private void SetGCResourceValues_LivingSpace_2(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_LivingSpace_2_Tasks = value_Tasks;
        GC.value_LivingSpace_2_Metal = value_Metal;
        GC.value_LivingSpace_2_Wood = value_Wood;
        GC.value_LivingSpace_2_Tech = value_Tech;
        GC.value_LivingSpace_2_Seeds = value_Seeds;
        GC.value_LivingSpace_2_Science = value_Science;
        DiplayUiStats();
    }
    private void SetGCResourceValues_Research_1(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_Research_1_Tasks = value_Tasks;
        GC.value_Research_1_Metal = value_Metal;
        GC.value_Research_1_Wood = value_Wood;
        GC.value_Research_1_Tech = value_Tech;
        GC.value_Research_1_Seeds = value_Seeds;
        GC.value_Research_1_Science = value_Science;
        DiplayUiStats();
    }
    private void SetGCResourceValues_Research_2(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_Research_2_Tasks = value_Tasks;
        GC.value_Research_2_Metal = value_Metal;
        GC.value_Research_2_Wood = value_Wood;
        GC.value_Research_2_Tech = value_Tech;
        GC.value_Research_2_Seeds = value_Seeds;
        GC.value_Research_2_Science = value_Science;
        DiplayUiStats();
    }
    private void SetGCResourceValues_Wall(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_Wall_Tasks = value_Tasks;
        GC.value_Wall_Metal = value_Metal;
        GC.value_Wall_Wood = value_Wood;
        GC.value_Wall_Tech = value_Tech;
        GC.value_Wall_Seeds = value_Seeds;
        GC.value_Wall_Science = value_Science;
        DiplayUiStats();
    }
    private void SetGCResourceValues_Stairs_2(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_Stairs_2_Tasks = value_Tasks;
        GC.value_Stairs_2_Metal = value_Metal;
        GC.value_Stairs_2_Wood = value_Wood;
        GC.value_Stairs_2_Tech = value_Tech;
        GC.value_Stairs_2_Seeds = value_Seeds;
        GC.value_Stairs_2_Science = value_Science;
        DiplayUiStats();
    }
    private void SetGCResourceValues_Stairs_3(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_Stairs_3_Tasks = value_Tasks;
        GC.value_Stairs_3_Metal = value_Metal;
        GC.value_Stairs_3_Wood = value_Wood;
        GC.value_Stairs_3_Tech = value_Tech;
        GC.value_Stairs_3_Seeds = value_Seeds;
        GC.value_Stairs_3_Science = value_Science;
        DiplayUiStats();
    }
    private void SetGCResourceValues_Bedroom_Lvl1_L(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_Bedroom_Lvl1_L_Tasks = value_Tasks;
        GC.value_Bedroom_Lvl1_L_Metal = value_Metal;
        GC.value_Bedroom_Lvl1_L_Wood = value_Wood;
        GC.value_Bedroom_Lvl1_L_Tech = value_Tech;
        GC.value_Bedroom_Lvl1_L_Seeds = value_Seeds;
        GC.value_Bedroom_Lvl1_L_Science = value_Science;
        DiplayUiStats();
    }
    private void SetGCResourceValues_Bedroom_Lvl1_R(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_Bedroom_Lvl1_R_Tasks = value_Tasks;
        GC.value_Bedroom_Lvl1_R_Metal = value_Metal;
        GC.value_Bedroom_Lvl1_R_Wood = value_Wood;
        GC.value_Bedroom_Lvl1_R_Tech = value_Tech;
        GC.value_Bedroom_Lvl1_R_Seeds = value_Seeds;
        GC.value_Bedroom_Lvl1_R_Science = value_Science;
        DiplayUiStats();
    }
    private void SetGCResourceValues_Bedroom_Lvl2_L(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_Bedroom_Lvl2_L_Tasks = value_Tasks;
        GC.value_Bedroom_Lvl2_L_Metal = value_Metal;
        GC.value_Bedroom_Lvl2_L_Wood = value_Wood;
        GC.value_Bedroom_Lvl2_L_Tech = value_Tech;
        GC.value_Bedroom_Lvl2_L_Seeds = value_Seeds;
        GC.value_Bedroom_Lvl2_L_Science = value_Science;
        DiplayUiStats();
    }
    private void SetGCResourceValues_Bedroom_Lvl2_R(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_Bedroom_Lvl2_R_Tasks = value_Tasks;
        GC.value_Bedroom_Lvl2_R_Metal = value_Metal;
        GC.value_Bedroom_Lvl2_R_Wood = value_Wood;
        GC.value_Bedroom_Lvl2_R_Tech = value_Tech;
        GC.value_Bedroom_Lvl2_R_Seeds = value_Seeds;
        GC.value_Bedroom_Lvl2_R_Science = value_Science;
        DiplayUiStats();
    }
    private void SetGCResourceValues_Bedroom_Lvl3_L(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_Bedroom_Lvl3_L_Tasks = value_Tasks;
        GC.value_Bedroom_Lvl3_L_Metal = value_Metal;
        GC.value_Bedroom_Lvl3_L_Wood = value_Wood;
        GC.value_Bedroom_Lvl3_L_Tech = value_Tech;
        GC.value_Bedroom_Lvl3_L_Seeds = value_Seeds;
        GC.value_Bedroom_Lvl3_L_Science = value_Science;
        DiplayUiStats();
    }
    private void SetGCResourceValues_Bedroom_Lvl3_R(int value_Tasks, int value_Metal, int value_Wood, int value_Tech, int value_Seeds, int value_Science)
    {
        GC.value_Bedroom_Lvl3_R_Tasks = value_Tasks;
        GC.value_Bedroom_Lvl3_R_Metal = value_Metal;
        GC.value_Bedroom_Lvl3_R_Wood = value_Wood;
        GC.value_Bedroom_Lvl3_R_Tech = value_Tech;
        GC.value_Bedroom_Lvl3_R_Seeds = value_Seeds;
        GC.value_Bedroom_Lvl3_R_Science = value_Science;
        DiplayUiStats();
    }
    #endregion

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
    #region Purchase Buildings & Upgrades
    // BEDROOM LVL1 LEFT UNLOCK
    #region Unlock Bedroom Lvl1 L & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Bedroom_Lvl1_L()
    {
        if (!GC.Bedroom_Lvl1_L)
        {
            if (GC.Player_Tasks >= 1) {  Unlock_Bedroom_Lvl1_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
            else { SFX_Deny(); NextTurnItems(); }
        }
        else
        {
            switch (GC.Bedroom_Upg_Lvl1_L)
            {
                case 1:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_2_Bedroom_Lvl1_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 2:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_3_Bedroom_Lvl1_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 3:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_4_Bedroom_Lvl1_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 4:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_5_Bedroom_Lvl1_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 5:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_6_Bedroom_Lvl1_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 6:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_7_Bedroom_Lvl1_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 7:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_8_Bedroom_Lvl1_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 8:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_9_Bedroom_Lvl1_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 9:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_10_Bedroom_Lvl1_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 10:
                    // Ui message Max Level
                    break;
            }
        }
    }
    private void Unlock_Bedroom_Lvl1_L()
    {
        if (GC.Player_SpareParts >= 50)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 50;
            GC.Player_Capacity += 1;
            GC.Bedroom_Lvl1_L = true;
            GC.Bedroom_Upg_Lvl1_L = 1;
            bedroom_Lvl1_L_Rock.SetActive(false);
            bedroom_Lvl1_L_Up_1.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl1_L(50, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_2_Bedroom_Lvl1_L()
    {
        if (GC.Player_SpareParts >= 25)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 25;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_L = 2;
            bedroom_Lvl1_L_Up_1.SetActive(false);
            bedroom_Lvl1_L_Up_2.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl1_L(25, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_3_Bedroom_Lvl1_L()
    {
        if (GC.Player_SpareParts >= 50)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 50;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_L = 3;
            bedroom_Lvl1_L_Up_2.SetActive(false);
            bedroom_Lvl1_L_Up_3.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl1_L(50, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_4_Bedroom_Lvl1_L()
    {
        if (GC.Player_SpareParts >= 75)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 75;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_L = 4;
            bedroom_Lvl1_L_Up_3.SetActive(false);
            bedroom_Lvl1_L_Up_4.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl1_L(75, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_5_Bedroom_Lvl1_L()
    {
        if (GC.Player_SpareParts >= 100)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 100;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_L = 5;
            bedroom_Lvl1_L_Up_4.SetActive(false);
            bedroom_Lvl1_L_Up_5.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl1_L(100, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_6_Bedroom_Lvl1_L()
    {
        if (GC.Player_SpareParts >= 125)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 125;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_L = 6;
            bedroom_Lvl1_L_Up_5.SetActive(false);
            bedroom_Lvl1_L_Up_6.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl1_L(125, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_7_Bedroom_Lvl1_L()
    {
        if (GC.Player_SpareParts >= 150)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 150;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_L = 7;
            bedroom_Lvl1_L_Up_6.SetActive(false);
            bedroom_Lvl1_L_Up_7.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl1_L(150, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_8_Bedroom_Lvl1_L()
    {
        if (GC.Player_SpareParts >= 175)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 175;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_L = 8;
            bedroom_Lvl1_L_Up_7.SetActive(false);
            bedroom_Lvl1_L_Up_8.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl1_L(175, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_9_Bedroom_Lvl1_L()
    {
        if (GC.Player_SpareParts >= 200)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 200;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_L = 9;
            bedroom_Lvl1_L_Up_8.SetActive(false);
            bedroom_Lvl1_L_Up_9.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl1_L(200, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_10_Bedroom_Lvl1_L()
    {
        if (GC.Player_SpareParts >= 225)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 225;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_L = 10;
            bedroom_Lvl1_L_Up_9.SetActive(false);
            bedroom_Lvl1_L_Up_10.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl1_L(225, 0, 0, 0, 0, 0);

            bedroom_lvl1_L_Button.interactable = false;
        }
        else
        {
            SFX_Deny();
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
        if (!GC.Bedroom_Lvl1_R)
        {
            if (GC.Player_Tasks >= 1) {  Unlock_Bedroom_Lvl1_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
            else { SFX_Deny(); NextTurnItems(); }
        }
        else
        {
            switch (GC.Bedroom_Upg_Lvl1_R)
            {
                case 1:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_2_Bedroom_Lvl1_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 2:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_3_Bedroom_Lvl1_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 3:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_4_Bedroom_Lvl1_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 4:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_5_Bedroom_Lvl1_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 5:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_6_Bedroom_Lvl1_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 6:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_7_Bedroom_Lvl1_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 7:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_8_Bedroom_Lvl1_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 8:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_9_Bedroom_Lvl1_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 9:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_10_Bedroom_Lvl1_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 10:
                    // message max level
                    break;
            }
        }
    }
    private void Unlock_Bedroom_Lvl1_R()
    {
        if (GC.Player_SpareParts >= 50)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 50;
            GC.Player_Capacity += 1;
            GC.Bedroom_Lvl1_R = true;
            GC.Bedroom_Upg_Lvl1_R = 1;
            bedroom_Lvl1_R_Rock.SetActive(false);
            bedroom_Lvl1_R_Up_1.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl1_R(50, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_2_Bedroom_Lvl1_R()
    {
        if (GC.Player_SpareParts >= 25)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 25;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_R = 2;
            bedroom_Lvl1_R_Up_1.SetActive(false);
            bedroom_Lvl1_R_Up_2.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl1_R(25, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_3_Bedroom_Lvl1_R()
    {
        if (GC.Player_SpareParts >= 50)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 50;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_R = 3;
            bedroom_Lvl1_R_Up_2.SetActive(false);
            bedroom_Lvl1_R_Up_3.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl1_R(50, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_4_Bedroom_Lvl1_R()
    {
        if (GC.Player_SpareParts >= 75)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 75;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_R = 4;
            bedroom_Lvl1_R_Up_3.SetActive(false);
            bedroom_Lvl1_R_Up_4.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl1_R(75, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_5_Bedroom_Lvl1_R()
    {
        if (GC.Player_SpareParts >= 100)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 100;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_R = 5;
            bedroom_Lvl1_R_Up_4.SetActive(false);
            bedroom_Lvl1_R_Up_5.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl1_R(100, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_6_Bedroom_Lvl1_R()
    {
        if (GC.Player_SpareParts >= 125)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 125;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_R = 6;
            bedroom_Lvl1_R_Up_5.SetActive(false);
            bedroom_Lvl1_R_Up_6.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl1_R(125, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_7_Bedroom_Lvl1_R()
    {
        if (GC.Player_SpareParts >= 150)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 150;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_R = 7;
            bedroom_Lvl1_R_Up_6.SetActive(false);
            bedroom_Lvl1_R_Up_7.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl1_R(150, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_8_Bedroom_Lvl1_R()
    {
        if (GC.Player_SpareParts >= 175)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 175;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_R = 8;
            bedroom_Lvl1_R_Up_7.SetActive(false);
            bedroom_Lvl1_R_Up_8.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl1_R(175, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_9_Bedroom_Lvl1_R()
    {
        if (GC.Player_SpareParts >= 200)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 200;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_R = 9;
            bedroom_Lvl1_R_Up_8.SetActive(false);
            bedroom_Lvl1_R_Up_9.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl1_R(200, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_10_Bedroom_Lvl1_R()
    {
        if (GC.Player_SpareParts >= 225)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 225;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl1_R = 10;
            bedroom_Lvl1_R_Up_9.SetActive(false);
            bedroom_Lvl1_R_Up_10.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl1_R(225, 0, 0, 0, 0, 0);

            bedroom_Lvl1_R_Button.interactable = false;
        }
        else
        {
            SFX_Deny();
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
        if (!GC.Bedroom_Lvl2_L)
        {
            if (GC.Player_Tasks >= 1) {  Unlock_Bedroom_Lvl2_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
            else { SFX_Deny(); NextTurnItems(); }
        }
        else
        {
            switch (GC.Bedroom_Upg_Lvl2_L)
            {
                case 1:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_2_Bedroom_Lvl2_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 2:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_3_Bedroom_Lvl2_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 3:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_4_Bedroom_Lvl2_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 4:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_5_Bedroom_Lvl2_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 5:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_6_Bedroom_Lvl2_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 6:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_7_Bedroom_Lvl2_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 7:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_8_Bedroom_Lvl2_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 8:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_9_Bedroom_Lvl2_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 9:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_10_Bedroom_Lvl2_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 10:
                    // Ui Message max level
                    break;
            }
        }
    }
    private void Unlock_Bedroom_Lvl2_L()
    {
        if (GC.Workshop_Lvl2_L2 && GC.Player_SpareParts >= 125)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 125;
            GC.Player_Capacity += 1;
            GC.Bedroom_Lvl2_L = true;
            GC.Bedroom_Upg_Lvl2_L = 1;
            bedroom_Lvl2_L_Rock.SetActive(false);
            bedroom_Lvl2_L_Up_1.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl2_L(125, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_2_Bedroom_Lvl2_L()
    {
        if (GC.Player_SpareParts >= 150)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 150;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_L = 2;
            bedroom_Lvl2_L_Up_1.SetActive(false);
            bedroom_Lvl2_L_Up_2.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl2_L(150, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_3_Bedroom_Lvl2_L()
    {
        if (GC.Player_SpareParts >= 175)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 175;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_L = 3;
            bedroom_Lvl2_L_Up_2.SetActive(false);
            bedroom_Lvl2_L_Up_3.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl2_L(175, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_4_Bedroom_Lvl2_L()
    {
        if (GC.Player_SpareParts >= 200)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 200;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_L = 4;
            bedroom_Lvl2_L_Up_3.SetActive(false);
            bedroom_Lvl2_L_Up_4.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl2_L(200, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_5_Bedroom_Lvl2_L()
    {
        if (GC.Player_SpareParts >= 225)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 225;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_L = 5;
            bedroom_Lvl2_L_Up_4.SetActive(false);
            bedroom_Lvl2_L_Up_5.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl2_L(225, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_6_Bedroom_Lvl2_L()
    {
        if (GC.Player_SpareParts >= 250)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 250;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_L = 6;
            bedroom_Lvl2_L_Up_5.SetActive(false);
            bedroom_Lvl2_L_Up_6.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl2_L(250, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_7_Bedroom_Lvl2_L()
    {
        if (GC.Player_SpareParts >= 275)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 275;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_L = 7;
            bedroom_Lvl2_L_Up_6.SetActive(false);
            bedroom_Lvl2_L_Up_7.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl2_L(275, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_8_Bedroom_Lvl2_L()
    {
        if (GC.Player_SpareParts >= 300)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 300;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_L = 8;
            bedroom_Lvl2_L_Up_7.SetActive(false);
            bedroom_Lvl2_L_Up_8.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl2_L(300, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_9_Bedroom_Lvl2_L()
    {
        if (GC.Player_SpareParts >= 325)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 325;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_L = 9;
            bedroom_Lvl2_L_Up_8.SetActive(false);
            bedroom_Lvl2_L_Up_9.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl2_L(325, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_10_Bedroom_Lvl2_L()
    {
        if (GC.Player_SpareParts >= 350)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 350;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_L = 10;
            bedroom_Lvl2_L_Up_9.SetActive(false);
            bedroom_Lvl2_L_Up_10.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl2_L(350, 0, 0, 0, 0, 0);

            bedroom_Lvl2_L_Button.interactable = false;
        }
        else
        {
            SFX_Deny();
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
        if (!GC.Bedroom_Lvl2_R)
        {
            GC.Player_Tasks -= 1;
            if (GC.Player_Tasks >= 1) {  Unlock_Bedroom_Lvl2_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
            else { SFX_Deny(); NextTurnItems(); }
        }
        else
        {
            switch (GC.Bedroom_Upg_Lvl2_R)
            {
                case 1:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_2_Bedroom_Lvl2_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 2:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_3_Bedroom_Lvl2_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 3:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_4_Bedroom_Lvl2_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 4:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_5_Bedroom_Lvl2_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 5:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_6_Bedroom_Lvl2_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 6:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_7_Bedroom_Lvl2_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 7:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_8_Bedroom_Lvl2_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 8:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_9_Bedroom_Lvl2_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 9:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_10_Bedroom_Lvl2_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    break;
                case 10:
                    // message max level
                    break;
            }
        }
    }
    private void Unlock_Bedroom_Lvl2_R()
    {
        if (GC.Generator_Lvl2_R2 && GC.Player_SpareParts >= 125)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 125;
            GC.Player_Capacity += 1;
            GC.Bedroom_Lvl2_R = true;
            GC.Bedroom_Upg_Lvl2_R = 1;
            bedroom_Lvl2_R_Rock.SetActive(false);
            bedroom_Lvl2_R_Up_1.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl2_R(125, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_2_Bedroom_Lvl2_R()
    {
        if (GC.Player_SpareParts >= 150)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 150;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_R = 2;
            bedroom_Lvl2_R_Up_1.SetActive(false);
            bedroom_Lvl2_R_Up_2.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl2_R(150, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_3_Bedroom_Lvl2_R()
    {
        if (GC.Player_SpareParts >= 175)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 175;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_R = 3;
            bedroom_Lvl2_R_Up_2.SetActive(false);
            bedroom_Lvl2_R_Up_3.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl2_R(175, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_4_Bedroom_Lvl2_R()
    {
        if (GC.Player_SpareParts >= 200)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 200;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_R = 4;
            bedroom_Lvl2_R_Up_3.SetActive(false);
            bedroom_Lvl2_R_Up_4.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl2_R(200, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_5_Bedroom_Lvl2_R()
    {
        if (GC.Player_SpareParts >= 225)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 225;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_R = 5;
            bedroom_Lvl2_R_Up_4.SetActive(false);
            bedroom_Lvl2_R_Up_5.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl2_R(225, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_6_Bedroom_Lvl2_R()
    {
        if (GC.Player_SpareParts >= 250)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 250;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_R = 6;
            bedroom_Lvl2_R_Up_5.SetActive(false);
            bedroom_Lvl2_R_Up_6.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl2_R(250, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_7_Bedroom_Lvl2_R()
    {
        if (GC.Player_SpareParts >= 275)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 275;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_R = 7;
            bedroom_Lvl2_R_Up_6.SetActive(false);
            bedroom_Lvl2_R_Up_7.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl2_R(275, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_8_Bedroom_Lvl2_R()
    {
        if (GC.Player_SpareParts >= 300)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 300;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_R = 8;
            bedroom_Lvl2_R_Up_7.SetActive(false);
            bedroom_Lvl2_R_Up_8.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl2_R(300, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_9_Bedroom_Lvl2_R()
    {
        if (GC.Player_SpareParts >= 325)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 325;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_R = 9;
            bedroom_Lvl2_R_Up_8.SetActive(false);
            bedroom_Lvl2_R_Up_9.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl2_R(325, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_10_Bedroom_Lvl2_R()
    {
        if (GC.Player_SpareParts >= 350)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 350;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl2_R = 10;
            bedroom_Lvl2_R_Up_9.SetActive(false);
            bedroom_Lvl2_R_Up_10.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl2_R(350, 0, 0, 0, 0, 0);

            bedroom_Lvl2_R_Button.interactable = false;
        }
        else
        {
            SFX_Deny();
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
        if (!GC.Bedroom_Lvl3_L)
        {
            if (GC.Player_Tasks >= 1) {  Unlock_Bedroom_Lvl3_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
            else { SFX_Deny(); NextTurnItems(); }
        }
        else
        {
            switch (GC.Bedroom_Upg_Lvl3_L)
            {
                case 1:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_2_Bedroom_Lvl3_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 2:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_3_Bedroom_Lvl3_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 3:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_4_Bedroom_Lvl3_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 4:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_5_Bedroom_Lvl3_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 5:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_6_Bedroom_Lvl3_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 6:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_7_Bedroom_Lvl3_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 7:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_8_Bedroom_Lvl3_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 8:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_9_Bedroom_Lvl3_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 9:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_10_Bedroom_Lvl3_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 10:
                    // message max level
                    break;
            }
        }
    }
    private void Unlock_Bedroom_Lvl3_L()
    {
        if (GC.Research_Lvl3_L2 && GC.Player_SpareParts >= 250)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 250;
            GC.Player_Capacity += 1;
            GC.Bedroom_Lvl3_L = true;
            GC.Bedroom_Upg_Lvl3_L = 1;
            bedroom_Lvl3_L_Rock.SetActive(false);
            bedroom_Lvl3_L_Up_1.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl3_L(250, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_2_Bedroom_Lvl3_L()
    {
        if (GC.Player_SpareParts >= 275)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 275;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_L = 2;
            bedroom_Lvl3_L_Up_1.SetActive(false);
            bedroom_Lvl3_L_Up_2.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl3_L(275, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_3_Bedroom_Lvl3_L()
    {
        if (GC.Player_SpareParts >= 300)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 300;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_L = 3;
            bedroom_Lvl3_L_Up_2.SetActive(false);
            bedroom_Lvl3_L_Up_3.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl3_L(300, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_4_Bedroom_Lvl3_L()
    {
        if (GC.Player_SpareParts >= 325)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 325;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_L = 4;
            bedroom_Lvl3_L_Up_3.SetActive(false);
            bedroom_Lvl3_L_Up_4.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl3_L(325, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_5_Bedroom_Lvl3_L()
    {
        if (GC.Player_SpareParts >= 350)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 350;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_L = 5;
            bedroom_Lvl3_L_Up_4.SetActive(false);
            bedroom_Lvl3_L_Up_5.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl3_L(350, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_6_Bedroom_Lvl3_L()
    {
        if (GC.Player_SpareParts >= 375)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 375;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_L = 6;
            bedroom_Lvl3_L_Up_5.SetActive(false);
            bedroom_Lvl3_L_Up_6.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl3_L(375, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_7_Bedroom_Lvl3_L()
    {
        if (GC.Player_SpareParts >= 400)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 400;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_L = 7;
            bedroom_Lvl3_L_Up_6.SetActive(false);
            bedroom_Lvl3_L_Up_7.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl3_L(400, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_8_Bedroom_Lvl3_L()
    {
        if (GC.Player_SpareParts >= 425)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 425;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_L = 8;
            bedroom_Lvl3_L_Up_7.SetActive(false);
            bedroom_Lvl3_L_Up_8.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl3_L(425, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_9_Bedroom_Lvl3_L()
    {
        if (GC.Player_SpareParts >= 450)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 450;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_L = 9;
            bedroom_Lvl3_L_Up_8.SetActive(false);
            bedroom_Lvl3_L_Up_9.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl3_L(450, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_10_Bedroom_Lvl3_L()
    {
        if (GC.Player_SpareParts >= 475)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 475;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_L = 10;
            bedroom_Lvl3_L_Up_9.SetActive(false);
            bedroom_Lvl3_L_Up_10.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl3_L(475, 0, 0, 0, 0, 0);

            bedroom_Lvl3_L_Button.interactable = false;
        }
        else
        {
            SFX_Deny();
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
        if (!GC.Bedroom_Lvl3_R)
        {
            if (GC.Player_Tasks >= 1) {  Unlock_Bedroom_Lvl3_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
            else { SFX_Deny(); NextTurnItems(); }
        }
        else
        {
            switch (GC.Bedroom_Upg_Lvl3_R)
            {
                case 1:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_2_Bedroom_Lvl3_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 2:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_3_Bedroom_Lvl3_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 3:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_4_Bedroom_Lvl3_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 4:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_5_Bedroom_Lvl3_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 5:
                    GC.Player_Tasks -= 1;
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_6_Bedroom_Lvl3_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 6:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_7_Bedroom_Lvl3_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 7:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_8_Bedroom_Lvl3_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 8:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_9_Bedroom_Lvl3_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 9:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_10_Bedroom_Lvl3_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 10:
                    // message max Level
                    break;
            }
        }
    }
    private void Unlock_Bedroom_Lvl3_R()
    {
        if (GC.LivingSpace_Lvl3_R2 && GC.Player_SpareParts >= 250)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 250;
            GC.Player_Capacity += 1;
            GC.Bedroom_Lvl3_R = true;
            GC.Bedroom_Upg_Lvl3_R = 1;
            bedroom_Lvl3_R_Rock.SetActive(false);
            bedroom_Lvl3_R_Up_1.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl3_R(250, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_2_Bedroom_Lvl3_R()
    {
        if (GC.Player_SpareParts >= 275)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 275;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_R = 2;
            bedroom_Lvl3_R_Up_1.SetActive(false);
            bedroom_Lvl3_R_Up_2.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl3_R(275, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_3_Bedroom_Lvl3_R()
    {
        if (GC.Player_SpareParts >= 300)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 300;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_R = 3;
            bedroom_Lvl3_R_Up_2.SetActive(false);
            bedroom_Lvl3_R_Up_3.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl3_R(300, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_4_Bedroom_Lvl3_R()
    {
        if (GC.Player_SpareParts >= 325)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 325;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_R = 4;
            bedroom_Lvl3_R_Up_3.SetActive(false);
            bedroom_Lvl3_R_Up_4.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl3_R(325, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_5_Bedroom_Lvl3_R()
    {
        if (GC.Player_SpareParts >= 350)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 350;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_R = 5;
            bedroom_Lvl3_R_Up_4.SetActive(false);
            bedroom_Lvl3_R_Up_5.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl3_R(350, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_6_Bedroom_Lvl3_R()
    {
        if (GC.Player_SpareParts >= 375)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 375;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_R = 6;
            bedroom_Lvl3_R_Up_5.SetActive(false);
            bedroom_Lvl3_R_Up_6.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl3_R(375, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_7_Bedroom_Lvl3_R()
    {
        if (GC.Player_SpareParts >= 400)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 400;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_R = 7;
            bedroom_Lvl3_R_Up_6.SetActive(false);
            bedroom_Lvl3_R_Up_7.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl3_R(400, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_8_Bedroom_Lvl3_R()
    {
        if (GC.Player_SpareParts >= 425)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 425;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_R = 8;
            bedroom_Lvl3_R_Up_7.SetActive(false);
            bedroom_Lvl3_R_Up_8.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl3_R(425, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_9_Bedroom_Lvl3_R()
    {
        if (GC.Player_SpareParts >= 450)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 450;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_R = 9;
            bedroom_Lvl3_R_Up_8.SetActive(false);
            bedroom_Lvl3_R_Up_9.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl3_R(450, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_10_Bedroom_Lvl3_R()
    {
        if (GC.Player_SpareParts >= 475)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 475;
            GC.Player_Capacity += 1;
            GC.Bedroom_Upg_Lvl3_R = 10;
            bedroom_Lvl3_R_Up_9.SetActive(false);
            bedroom_Lvl3_R_Up_10.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Bedroom_Lvl3_R(475, 0, 0, 0, 0, 0);

            bedroom_Lvl3_R_Button.interactable = false;
        }
        else
        {
            SFX_Deny();
        }
    }
    #endregion 
    // STAIRS 2 UNLOCK
    #region Stairs 2 Unlock
    public void Upgrade_Stairs_2()
    {
        if (GC.Player_Tasks >= 1) {  Unlock_Stairs_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
        else { SFX_Deny(); NextTurnItems(); }
    }
    private void Unlock_Stairs_2()
    {
        if (GC.Stairs_1 && GC.Stairs_2_Clicks_Unlock >= 25)
        {
            GC.Player_Tasks -= 1;
            GC.Stairs_2_Clicks_Unlock -=25;
            GC.Stairs_2 = true;
            stairs_2_Locked.SetActive(false); stairs_2_Unlocked.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Stairs_2(25, 0, 0, 0, 0, 0);

            stairs_2_Button.interactable = false;
        }
        else
        {
            SFX_Deny();
        }
    }
    #endregion
    // STAIRS 3 UNLOCK
    #region Stairs 3 Unlock
    public void Upgrade_Stairs_3()
    {
        if (GC.Player_Tasks >= 1) {  Unlock_Stairs_3(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
        else { SFX_Deny(); NextTurnItems(); }
    }
    private void Unlock_Stairs_3()
    {
        if (GC.Stairs_2 && GC.Stairs_2_Clicks_Unlock >= 125)
        {
            GC.Player_Tasks -= 1;
            GC.Stairs_3_Clicks_Unlock -=125;
            GC.Stairs_3 = true;
            stairs_3_Locked.SetActive(false); stairs_3_Unlocked.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Stairs_3(125, 0, 0, 0, 0, 0);

            stairs_3_Button.interactable = false;
        }
        else
        {
            SFX_Deny();
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
                if (GC.Player_Tasks >= 1) {  Buy_Up_To_2_Expedition(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                else { SFX_Deny(); NextTurnItems(); }
                
                break;
            case 2:
                if (GC.Player_Tasks >= 1) {  Buy_Up_To_3_Expedition(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                else { SFX_Deny(); NextTurnItems(); }
                
                break;
            case 3:
                if (GC.Player_Tasks >= 1) {  Buy_Up_To_4_Expedition(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                else { SFX_Deny(); NextTurnItems(); }
                
                break;
            case 4:
                if (GC.Player_Tasks >= 1) {  Buy_Up_To_5_Expedition(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                else { SFX_Deny(); NextTurnItems(); }
                
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
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= purchaseValue;
            GC.Player_Wood -= purchaseValue;
            GC.Player_Tech -= purchaseValue;
            GC.Expedition_Upg_Lvl1_R1 = 2;
            expedition_Lvl1_R1_Up_1.SetActive(false);
            expedition_Lvl1_R1_Up_2.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Expedition(0, purchaseValue, purchaseValue, purchaseValue, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_3_Expedition()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Expedition_Upg_Lvl1_R1 = 3;
            expedition_Lvl1_R1_Up_2.SetActive(false);
            expedition_Lvl1_R1_Up_3.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Expedition(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_4_Expedition()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Expedition_Upg_Lvl1_R1 = 4;
            expedition_Lvl1_R1_Up_3.SetActive(false);
            expedition_Lvl1_R1_Up_4.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Expedition(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_5_Expedition()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Expedition_Upg_Lvl1_R1 = 5;
            expedition_Lvl1_R1_Up_4.SetActive(false);
            expedition_Lvl1_R1_Up_5.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Expedition(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);

            expedition_Lvl1_R1_Button.interactable = false;
        }
        else
        {
            SFX_Deny();
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
                if (GC.Player_Tasks >= 1) {  Buy_Up_To_2_Training(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                else { SFX_Deny(); NextTurnItems(); }
                
                    break;
                case 2:
                if (GC.Player_Tasks >= 1) {  Buy_Up_To_3_Training(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                else { SFX_Deny(); NextTurnItems(); }
                
                    break;
                case 3:
                if (GC.Player_Tasks >= 1) {  Buy_Up_To_4_Training(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                else { SFX_Deny(); NextTurnItems(); }
                
                    break;
                case 4:
                if (GC.Player_Tasks >= 1) {  Buy_Up_To_5_Training(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                else { SFX_Deny(); NextTurnItems(); }
                
                    break;
                case 5:
                // ui message max level
                    break;
            }
    }
    private void Buy_Up_To_2_Training()
    {
        if (GC.Player_Metal >= purchaseValue && GC.Player_Wood >= purchaseValue && GC.Player_Tech >= purchaseValue)
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= purchaseValue;
            GC.Player_Wood -= purchaseValue;
            GC.Player_Tech -= purchaseValue;
            GC.Training_Upg_Lvl1_R2 = 2;
            training_Lvl1_R2_Up_1.SetActive(false);
            training_Lvl1_R2_Up_2.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Training(0, purchaseValue, purchaseValue, purchaseValue, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_3_Training()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Training_Upg_Lvl1_R2 = 3;
            training_Lvl1_R2_Up_2.SetActive(false);
            training_Lvl1_R2_Up_3.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Training(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_4_Training()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Training_Upg_Lvl1_R2 = 4;
            training_Lvl1_R2_Up_3.SetActive(false);
            training_Lvl1_R2_Up_4.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Training(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_5_Training()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Training_Upg_Lvl1_R2 = 5;
            training_Lvl1_R2_Up_4.SetActive(false);
            training_Lvl1_R2_Up_5.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Training(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);

            training_Lvl1_R2_Button.interactable = false;
        }
        else
        {
            SFX_Deny();
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
                if (GC.Player_Tasks >= 1) {  Buy_Up_To_2_UnderGarden(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                else { SFX_Deny(); NextTurnItems(); }
                
                    break;
                case 2:
                if (GC.Player_Tasks >= 1) {  Buy_Up_To_3_UnderGarden(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                else { SFX_Deny(); NextTurnItems(); }
                
                    break;
                case 3:
                if (GC.Player_Tasks >= 1) {  Buy_Up_To_4_UnderGarden(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                else { SFX_Deny(); NextTurnItems(); }
                
                    break;
                case 4:
                if (GC.Player_Tasks >= 1) {  Buy_Up_To_5_UnderGarden(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                else { SFX_Deny(); NextTurnItems(); }
                
                    break;
                case 5:
                // ui message max level
                    break;
            }
    }
    private void Buy_Up_To_2_UnderGarden()
    {
        if (GC.Player_Metal >= purchaseValue && GC.Player_Wood >= purchaseValue && GC.Player_Tech >= purchaseValue && GC.Player_Seeds>=10)
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= purchaseValue;
            GC.Player_Wood -= purchaseValue;
            GC.Player_Tech -= purchaseValue;
            GC.Player_Seeds = 10;
            GC.UnderGarden_Upg_Lvl1_L1 = 2;
            underGarden_Lvl1_L1_Up_1.SetActive(false);
            underGarden_Lvl1_L1_Up_2.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Garden(0, purchaseValue, purchaseValue, purchaseValue, 10, 0);
        }
        else
        {
            if (GC.Player_Seeds < 10) { shortResSeeds = true; shortResSeedsMaster.SetActive(true); }
            SFX_Deny();
        }
    }
    private void Buy_Up_To_3_UnderGarden()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2) && GC.Player_Seeds >= 10)
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Player_Seeds = 10;
            GC.UnderGarden_Upg_Lvl1_L1 = 3;
            underGarden_Lvl1_L1_Up_2.SetActive(false);
            underGarden_Lvl1_L1_Up_3.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Garden(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 10, 0);
        }
        else
        {
            if (GC.Player_Seeds < 10) { shortResSeeds = true; shortResSeedsMaster.SetActive(true); }
            SFX_Deny();
        }
    }
    private void Buy_Up_To_4_UnderGarden()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4) && GC.Player_Seeds >= 10)
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Player_Seeds = 10;
            GC.UnderGarden_Upg_Lvl1_L1 = 4;
            underGarden_Lvl1_L1_Up_3.SetActive(false);
            underGarden_Lvl1_L1_Up_4.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Garden(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 10, 0);
        }
        else
        {
            if (GC.Player_Seeds < 10) { shortResSeeds = true; shortResSeedsMaster.SetActive(true); }
            SFX_Deny();
        }
    }
    private void Buy_Up_To_5_UnderGarden()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8) && GC.Player_Seeds >= 10)
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Player_Seeds = 10;
            GC.UnderGarden_Upg_Lvl1_L1 = 5;
            underGarden_Lvl1_L1_Up_4.SetActive(false);
            underGarden_Lvl1_L1_Up_5.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Garden(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 10, 0);

            underGarden_Lvl1_L1_Button.interactable = false;
        }
        else
        {
            if (GC.Player_Seeds < 10) { shortResSeeds = true; shortResSeedsMaster.SetActive(true); }
            SFX_Deny();
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
                if (GC.Player_Tasks >= 1) {  Buy_Up_To_2_Radio(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                else { SFX_Deny(); NextTurnItems(); }

                break;
                case 2:
                if (GC.Player_Tasks >= 1) {  Buy_Up_To_3_Radio(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                else { SFX_Deny(); NextTurnItems(); }

                break;
                case 3:
                if (GC.Player_Tasks >= 1) {  Buy_Up_To_4_Radio(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                else { SFX_Deny(); NextTurnItems(); }

                break;
                case 4:
                if (GC.Player_Tasks >= 1) {  Buy_Up_To_5_Radio(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                else { SFX_Deny(); NextTurnItems(); }

                break;
                case 5:
                // ui message max level
                break;
            }
    }
    private void Buy_Up_To_2_Radio()
    {
        if (GC.Player_Metal >= purchaseValue && GC.Player_Wood >= purchaseValue && GC.Player_Tech >= purchaseValue && GC.Player_Science>=10)
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= purchaseValue;
            GC.Player_Wood -= purchaseValue;
            GC.Player_Tech -= purchaseValue;
            GC.Player_Science -= 10;
            GC.Radio_Upg_Lvl1_L2 = 2;
            radio_Lvl1_L2_Up_1.SetActive(false);
            radio_Lvl1_L2_Up_2.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Radio(0, purchaseValue, purchaseValue, purchaseValue, 0, 10);
        }
        else
        {
            if (GC.Player_Science < 10) { shortResScience = true; shortResScienceMaster.SetActive(true); }
            SFX_Deny();
        }
    }
    private void Buy_Up_To_3_Radio()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2) && GC.Player_Science >= 10)
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Player_Science -= 10;
            GC.Radio_Upg_Lvl1_L2 = 3;
            radio_Lvl1_L2_Up_2.SetActive(false);
            radio_Lvl1_L2_Up_3.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Radio(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 10);
        }
        else
        {
            if (GC.Player_Science < 10) { shortResScience = true; shortResScienceMaster.SetActive(true); }
            SFX_Deny();
        }
    }
    private void Buy_Up_To_4_Radio()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4) && GC.Player_Science >= 10)
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Player_Science -= 10;
            GC.Radio_Upg_Lvl1_L2 = 4;
            radio_Lvl1_L2_Up_3.SetActive(false);
            radio_Lvl1_L2_Up_4.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Radio(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 10);
        }
        else
        {
            if (GC.Player_Science < 10) { shortResScience = true; shortResScienceMaster.SetActive(true); }
            SFX_Deny();
        }
    }
    private void Buy_Up_To_5_Radio()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8) && GC.Player_Science >= 10)
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Player_Science -= 10;
            GC.Radio_Upg_Lvl1_L2 = 5;
            radio_Lvl1_L2_Up_4.SetActive(false);
            radio_Lvl1_L2_Up_5.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Radio(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 10);

            radio_Lvl1_L2_Button.interactable = false;
        }
        else
        {
            if (GC.Player_Science < 10) { shortResScience = true; shortResScienceMaster.SetActive(true); }
            SFX_Deny();
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
        if (!GC.Generator_Lvl2_R1)
        {
            if (GC.Player_Tasks >= 1) {  Unlock_Generator_1(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
            else { SFX_Deny(); NextTurnItems(); }
        }
        else
        {
            switch (GC.Generator_Upg_Lvl2_R1)
            {
                case 1:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_2_Generator_1(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 2:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_3_Generator_1(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 3:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_4_Generator_1(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 4:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_5_Generator_1(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
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
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 2);// purchaseValue is 250
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Generator_Lvl2_R1 = true;
            GC.Generator_Upg_Lvl2_R1 = 1;
            generator_Lvl2_R1_Def.SetActive(false);
            generator_Lvl2_R1_Up_1.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Generator_1(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_2_Generator_1()
    {
        if (GC.Player_Metal >= purchaseValue && GC.Player_Wood >= purchaseValue && GC.Player_Tech >= purchaseValue)
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= purchaseValue;
            GC.Player_Wood -= purchaseValue;
            GC.Player_Tech -= purchaseValue;
            GC.Generator_Upg_Lvl2_R1 = 2;
            generator_Lvl2_R1_Up_1.SetActive(false);
            generator_Lvl2_R1_Up_2.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Generator_1(0, purchaseValue, purchaseValue, purchaseValue, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_3_Generator_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Generator_Upg_Lvl2_R1 = 3;
            generator_Lvl2_R1_Up_2.SetActive(false);
            generator_Lvl2_R1_Up_3.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Generator_1(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_4_Generator_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Generator_Upg_Lvl2_R1 = 4;
            generator_Lvl2_R1_Up_3.SetActive(false);
            generator_Lvl2_R1_Up_4.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Generator_1(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_5_Generator_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Generator_Upg_Lvl2_R1 = 5;
            generator_Lvl2_R1_Up_4.SetActive(false);
            generator_Lvl2_R1_Up_5.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Generator_1(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);

            generator_Lvl2_R1_Button.interactable = false;
        }
        else
        {
            SFX_Deny();
        }
    }
    #endregion
    #region Unlock Generator 2 & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Generator_Building_2()
    {
        if (!GC.Generator_Lvl2_R2)
        {
            if (GC.Player_Tasks >= 1) {  Unlock_Generator_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
            else { SFX_Deny(); NextTurnItems(); }
           
        }
        else
        {
            switch (GC.Generator_Upg_Lvl2_R2)
            {
                case 1:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_2_Generator_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 2:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_3_Generator_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 3:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_4_Generator_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 4:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_5_Generator_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
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
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 4);// purchaseValue is 250
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Generator_Lvl2_R2 = true;
            GC.Generator_Upg_Lvl2_R2 = 1;
            generator_Lvl2_R2_Def.SetActive(false);
            generator_Lvl2_R2_Up_1.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Generator_2(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_2_Generator_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Generator_Upg_Lvl2_R2 = 2;
            generator_Lvl2_R2_Up_1.SetActive(false);
            generator_Lvl2_R2_Up_2.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Generator_2(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_3_Generator_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Generator_Upg_Lvl2_R2 = 3;
            generator_Lvl2_R2_Up_2.SetActive(false);
            generator_Lvl2_R2_Up_3.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Generator_2(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_4_Generator_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Generator_Upg_Lvl2_R2 = 4;
            generator_Lvl2_R2_Up_3.SetActive(false);
            generator_Lvl2_R2_Up_4.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Generator_2(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_5_Generator_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.Generator_Upg_Lvl2_R2 = 5;
            generator_Lvl2_R2_Up_4.SetActive(false);
            generator_Lvl2_R2_Up_5.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Generator_2(0, (purchaseValue * 16), (purchaseValue * 16), (purchaseValue * 16), 0, 0);

            generator_Lvl2_R2_Button.interactable = false;
        }
        else
        {
            SFX_Deny();
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
        if (!GC.Workshop_Lvl2_L1)
        {
            if (GC.Player_Tasks >= 1) {  Unlock_Workshop_1(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
            else { SFX_Deny(); NextTurnItems(); }
            
        }
        else
        {
            switch (GC.Workshop_Upg_Lvl2_L1)
            {
                case 1:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_2_Workshop_1(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 2:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_3_Workshop_1(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 3:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_4_Workshop_1(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 4:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_5_Workshop_1(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
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
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 2);// purchaseValue is 250
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Workshop_Lvl2_L1 = true;
            GC.Workshop_Upg_Lvl2_L1 = 1;
            workshop_Lvl2_L1_Def.SetActive(false);
            workshop_Lvl2_L1_Up_1.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Workshop_1(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_2_Workshop_1()
    {
        if (GC.Player_Metal >= purchaseValue && GC.Player_Wood >= purchaseValue && GC.Player_Tech >= purchaseValue)
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= purchaseValue;
            GC.Player_Wood -= purchaseValue;
            GC.Player_Tech -= purchaseValue;
            GC.Workshop_Upg_Lvl2_L1 = 2;
            workshop_Lvl2_L1_Up_1.SetActive(false);
            workshop_Lvl2_L1_Up_2.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Workshop_1(0, purchaseValue, purchaseValue, purchaseValue, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_3_Workshop_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Workshop_Upg_Lvl2_L1 = 3;
            workshop_Lvl2_L1_Up_2.SetActive(false);
            workshop_Lvl2_L1_Up_3.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Workshop_1(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_4_Workshop_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Workshop_Upg_Lvl2_L1 = 4;
            workshop_Lvl2_L1_Up_3.SetActive(false);
            workshop_Lvl2_L1_Up_4.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Workshop_1(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_5_Workshop_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Workshop_Upg_Lvl2_L1 = 5;
            workshop_Lvl2_L1_Up_4.SetActive(false);
            workshop_Lvl2_L1_Up_5.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Workshop_1(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);

            workshop_Lvl2_L1_Button.interactable = false;
        }
        else
        {
            SFX_Deny();
        }
    }
    #endregion
    #region Unlock Workshop 2 & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Workshop_Building_2()
    {
        if (!GC.Workshop_Lvl2_L2)
        {
            if (GC.Player_Tasks >= 1) {  Unlock_Workshop_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
            else { SFX_Deny(); NextTurnItems(); }
            
        }
        else
        {
            switch (GC.Workshop_Upg_Lvl2_L2)
            {
                case 1:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_2_Workshop_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 2:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_3_Workshop_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 3:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_4_Workshop_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 4:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_5_Workshop_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
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
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 4);// purchaseValue is 250
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Workshop_Lvl2_L2 = true;
            GC.Workshop_Upg_Lvl2_L2 = 1;
            workshop_Lvl2_L2_Def.SetActive(false);
            workshop_Lvl2_L2_Up_1.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Workshop_2(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_2_Workshop_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Workshop_Upg_Lvl2_L2 = 2;
            workshop_Lvl2_L2_Up_1.SetActive(false);
            workshop_Lvl2_L2_Up_2.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Workshop_2(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_3_Workshop_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Workshop_Upg_Lvl2_L2 = 3;
            workshop_Lvl2_L2_Up_2.SetActive(false);
            workshop_Lvl2_L2_Up_3.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Workshop_2(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_4_Workshop_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Workshop_Upg_Lvl2_L2 = 4;
            workshop_Lvl2_L2_Up_3.SetActive(false);
            workshop_Lvl2_L2_Up_4.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Workshop_2(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_5_Workshop_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.Workshop_Upg_Lvl2_L2 = 5;
            workshop_Lvl2_L2_Up_4.SetActive(false);
            workshop_Lvl2_L2_Up_5.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Workshop_2(0, (purchaseValue * 16), (purchaseValue * 16), (purchaseValue * 16), 0, 0);

            workshop_Lvl2_L2_Button.interactable = false;
        }
        else
        {
            SFX_Deny();
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
        if (!GC.LivingSpace_Lvl3_R1)
        {
            if (GC.Player_Tasks >= 1) {  Unlock_LivingSpace_1(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
            else { SFX_Deny(); NextTurnItems(); }
            
        }
        else
        {
            switch (GC.LivingSpace_Upg_Lvl3_R1)
            {
                case 1:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_2_LivingSpace_1(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 2:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_3_LivingSpace_1(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 3:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_4_LivingSpace_1(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 4:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_5_LivingSpace_1(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
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
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 2);// purchaseValue is 250
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.LivingSpace_Lvl3_R1 = true;
            GC.LivingSpace_Upg_Lvl3_R1 = 1;
            livingSpace_Lvl3_R1_Def.SetActive(false);
            livingSpace_Lvl3_R1_Up_1.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_LivingSpace_1(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_2_LivingSpace_1()
    {
        if (GC.Player_Metal >= purchaseValue && GC.Player_Wood >= purchaseValue && GC.Player_Tech >= purchaseValue)
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= purchaseValue;
            GC.Player_Wood -= purchaseValue;
            GC.Player_Tech -= purchaseValue;
            GC.LivingSpace_Upg_Lvl3_R1 = 2;
            livingSpace_Lvl3_R1_Up_1.SetActive(false);
            livingSpace_Lvl3_R1_Up_2.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_LivingSpace_1(0, purchaseValue, purchaseValue, purchaseValue, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_3_LivingSpace_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.LivingSpace_Upg_Lvl3_R1 = 3;
            livingSpace_Lvl3_R1_Up_2.SetActive(false);
            livingSpace_Lvl3_R1_Up_3.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_LivingSpace_1(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_4_LivingSpace_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.LivingSpace_Upg_Lvl3_R1 = 4;
            livingSpace_Lvl3_R1_Up_3.SetActive(false);
            livingSpace_Lvl3_R1_Up_4.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_LivingSpace_1(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_5_LivingSpace_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.LivingSpace_Upg_Lvl3_R1 = 5;
            livingSpace_Lvl3_R1_Up_4.SetActive(false);
            livingSpace_Lvl3_R1_Up_5.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_LivingSpace_1(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);

            livingSpace_Lvl3_R1_Button.interactable = false;
        }
        else
        {
            SFX_Deny();
        }
    }
    #endregion
    #region Unlock LivingSpace 2 & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_LivingSpace_Building_2()
    {
        if (!GC.LivingSpace_Lvl3_R2)
        {
            if (GC.Player_Tasks >= 1) {  Unlock_LivingSpace_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
            else { SFX_Deny(); NextTurnItems(); }
            
        }
        else
        {
            switch (GC.LivingSpace_Upg_Lvl3_R2)
            {
                case 1:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_2_LivingSpace_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 2:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_3_LivingSpace_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 3:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_4_LivingSpace_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 4:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_5_LivingSpace_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
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
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 4);// purchaseValue is 250
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.LivingSpace_Lvl3_R2 = true;
            GC.LivingSpace_Upg_Lvl3_R2 = 1;
            livingSpace_Lvl3_R2_Def.SetActive(false);
            livingSpace_Lvl3_R2_Up_1.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_LivingSpace_2(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_2_LivingSpace_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.LivingSpace_Upg_Lvl3_R2 = 2;
            livingSpace_Lvl3_R2_Up_1.SetActive(false);
            livingSpace_Lvl3_R2_Up_2.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_LivingSpace_2(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_3_LivingSpace_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.LivingSpace_Upg_Lvl3_R2 = 3;
            livingSpace_Lvl3_R2_Up_2.SetActive(false);
            livingSpace_Lvl3_R2_Up_3.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_LivingSpace_2(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_4_LivingSpace_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.LivingSpace_Upg_Lvl3_R2 = 4;
            livingSpace_Lvl3_R2_Up_3.SetActive(false);
            livingSpace_Lvl3_R2_Up_4.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_LivingSpace_2(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_5_LivingSpace_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.LivingSpace_Upg_Lvl3_R2 = 5;
            livingSpace_Lvl3_R2_Up_4.SetActive(false);
            livingSpace_Lvl3_R2_Up_5.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_LivingSpace_2(0, (purchaseValue * 16), (purchaseValue * 16), (purchaseValue * 16), 0, 0);

            livingSpace_Lvl3_R2_Button.interactable = false;
        }
        else
        {
            SFX_Deny();
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
        if (!GC.Research_Lvl3_L1)
        {
            if (GC.Player_Tasks >= 1) {  Unlock_Research_1(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
            else { SFX_Deny(); NextTurnItems(); }
            
        }
        else
        {
            switch (GC.Research_Upg_Lvl3_L1)
            {
                case 1:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_2_Research_1(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 2:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_3_Research_1(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 3:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_4_Research_1(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 4:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_5_Research_1(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
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
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 2);// purchaseValue is 250
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Research_Lvl3_L1 = true;
            GC.Research_Upg_Lvl3_L1 = 1;
            research_Lvl3_L1_Def.SetActive(false);
            research_Lvl3_L1_Up_1.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Research_1(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_2_Research_1()
    {
        if (GC.Player_Metal >= purchaseValue && GC.Player_Wood >= purchaseValue && GC.Player_Tech >= purchaseValue)
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= purchaseValue;
            GC.Player_Wood -= purchaseValue;
            GC.Player_Tech -= purchaseValue;
            GC.Research_Upg_Lvl3_L1 = 2;
            research_Lvl3_L1_Up_1.SetActive(false);
            research_Lvl3_L1_Up_2.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Research_1(0, purchaseValue, purchaseValue, purchaseValue, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_3_Research_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Research_Upg_Lvl3_L1 = 3;
            research_Lvl3_L1_Up_2.SetActive(false);
            research_Lvl3_L1_Up_3.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Research_1(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_4_Research_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Research_Upg_Lvl3_L1 = 4;
            research_Lvl3_L1_Up_3.SetActive(false);
            research_Lvl3_L1_Up_4.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Research_1(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_5_Research_1()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Research_Upg_Lvl3_L1 = 5;
            research_Lvl3_L1_Up_4.SetActive(false);
            research_Lvl3_L1_Up_5.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Research_1(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);

            research_Lvl3_L1_Button.interactable = false;
        }
        else
        {
            SFX_Deny();
        }
    }
    #endregion
    #region Unlock Research 2 & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Research_Building_2()
    {
        if (!GC.Research_Lvl3_L2)
        {
            if (GC.Player_Tasks >= 1) {  Unlock_Research_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
            else { SFX_Deny(); NextTurnItems(); }
            
        }
        else
        {
            switch (GC.Research_Upg_Lvl3_L2)
            {
                case 1:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_2_Research_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 2:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_to_3_Research_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 3:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_4_Research_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 4:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_5_Research_2(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
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
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 4);// purchaseValue is 250
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Research_Lvl3_L2 = true;
            GC.Research_Upg_Lvl3_L2 = 1;
            research_Lvl3_L2_Up_1.SetActive(true); research_Lvl3_L2_Def.SetActive(false); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Research_2(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_2_Research_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 2) && GC.Player_Wood >= (purchaseValue * 2) && GC.Player_Tech >= (purchaseValue * 2))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 2);
            GC.Player_Wood -= (purchaseValue * 2);
            GC.Player_Tech -= (purchaseValue * 2);
            GC.Research_Upg_Lvl3_L2 = 2;
            research_Lvl3_L2_Up_1.SetActive(false);
            research_Lvl3_L2_Up_2.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Research_2(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_to_3_Research_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 4) && GC.Player_Wood >= (purchaseValue * 4) && GC.Player_Tech >= (purchaseValue * 4))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 4);
            GC.Player_Wood -= (purchaseValue * 4);
            GC.Player_Tech -= (purchaseValue * 4);
            GC.Research_Upg_Lvl3_L2 = 3;
            research_Lvl3_L2_Up_2.SetActive(false);
            research_Lvl3_L2_Up_3.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Research_2(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_4_Research_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 8) && GC.Player_Wood >= (purchaseValue * 8) && GC.Player_Tech >= (purchaseValue * 8))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 8);
            GC.Player_Wood -= (purchaseValue * 8);
            GC.Player_Tech -= (purchaseValue * 8);
            GC.Research_Upg_Lvl3_L2 = 4;
            research_Lvl3_L2_Up_3.SetActive(false);
            research_Lvl3_L2_Up_4.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Research_2(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_5_Research_2()
    {
        if (GC.Player_Metal >= (purchaseValue * 16) && GC.Player_Wood >= (purchaseValue * 16) && GC.Player_Tech >= (purchaseValue * 16))
        {
            GC.Player_Tasks -= 1;
            GC.Player_Metal -= (purchaseValue * 16);
            GC.Player_Wood -= (purchaseValue * 16);
            GC.Player_Tech -= (purchaseValue * 16);
            GC.Research_Upg_Lvl3_L2 = 5;
            research_Lvl3_L2_Up_4.SetActive(false);
            research_Lvl3_L2_Up_5.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Research_2(0, (purchaseValue * 16), (purchaseValue * 16), (purchaseValue * 16), 0, 0);

            research_Lvl3_L2_Button.interactable = false;
        }
        else
        {
            SFX_Deny();
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
        if (!GC.Wall_L)
        {
            if (GC.Player_Tasks >= 1) {  Unlock_Wall_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
            else { SFX_Deny(); NextTurnItems(); }
            
        }
        else
        {
            switch (GC.Wall_L_Upg)
            {
                case 1:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_2_Wall_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 2:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_3_Wall_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 3:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_4_Wall_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 4:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_5_Wall_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 5:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_6_Wall_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 6:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_7_Wall_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 7:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_8_Wall_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 8:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_9_Wall_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 9:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_10_Wall_L(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 10:
                    //Buy_Up_10_Wall_R();
                    break;
            }
        }
    }
    private void Unlock_Wall_L()
    {
        if (GC.Player_SpareParts >= 50)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts = 0;
            GC.Wall_L = true;
            GC.Wall_L_Upg = 1;
            wall_Left_None.SetActive(false);
            wall_Left_Up_1.SetActive(true); DiplayUiStats();
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_2_Wall_L()
    {
        if (GC.Player_SpareParts >= 25)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 25;
            GC.Wall_L_Upg = 2;
            wall_Left_Up_1.SetActive(false);
            wall_Left_Up_2.SetActive(true); DiplayUiStats();
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_3_Wall_L()
    {
        if (GC.Player_SpareParts >= 50)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 50;
            GC.Wall_L_Upg = 3;
            wall_Left_Up_2.SetActive(false);
            wall_Left_Up_3.SetActive(true); DiplayUiStats();
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_4_Wall_L()
    {
        if (GC.Player_SpareParts >= 75)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 75;
            GC.Wall_L_Upg = 4;
            wall_Left_Up_3.SetActive(false);
            wall_Left_Up_4.SetActive(true); DiplayUiStats();
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_5_Wall_L()
    {
        if (GC.Player_SpareParts >= 100)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 100;
            GC.Wall_L_Upg = 5;
            wall_Left_Up_4.SetActive(false);
            wall_Left_Up_5.SetActive(true); DiplayUiStats();
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_6_Wall_L()
    {
        if (GC.Player_SpareParts >= 125)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 125;
            GC.Wall_L_Upg = 6;
            wall_Left_Up_5.SetActive(false);
            wall_Left_Up_6.SetActive(true); DiplayUiStats();
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_7_Wall_L()
    {
        if (GC.Player_SpareParts >= 150)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 150;
            GC.Wall_L_Upg = 7;
            wall_Left_Up_6.SetActive(false);
            wall_Left_Up_7.SetActive(true); DiplayUiStats();
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_8_Wall_L()
    {
        if (GC.Player_SpareParts >= 175)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 175;
            GC.Wall_L_Upg = 8;
            wall_Left_Up_7.SetActive(false);
            wall_Left_Up_8.SetActive(true); DiplayUiStats();
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_9_Wall_L()
    {
        if (GC.Player_SpareParts >= 200)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 200;
            GC.Wall_L_Upg = 9;
            wall_Left_Up_8.SetActive(false);
            wall_Left_Up_9.SetActive(true); DiplayUiStats();
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_10_Wall_L()
    {
        if (GC.Player_SpareParts >= 225)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 225;
            GC.Wall_L_Upg = 10;
            wall_Left_Up_9.SetActive(false);
            wall_Left_Up_10.SetActive(true); DiplayUiStats();
            
            wall_Left_Button.interactable = false;
        }
        else
        {
            SFX_Deny();
        }
    }
    #endregion
    // WALL RIGHT UNLOCK
    #region Unlock Wall R & Upgrades
    /// <summary>
    /// 
    /// </summary>
    public void Upgrade_Wall_R()
    {
        if (!GC.Wall_R)
        {
            if (GC.Player_Tasks >= 1) {  Unlock_Up_1_Wall_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
            else { SFX_Deny(); NextTurnItems(); }
            
        }
        else
        {
            switch (GC.Wall_R_Upg)
            {
                case 1:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_2_Wall_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 2:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_3_Wall_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 3:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_4_Wall_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 4:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_5_Wall_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 5:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_6_Wall_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 6:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_7_Wall_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 7:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_8_Wall_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 8:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_9_Wall_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 9:
                    if (GC.Player_Tasks >= 1) {  Buy_Up_To_10_Wall_R(); if (GC.Player_Tasks == 0) { SFX_Deny(); NextTurnItems(); } }
                    else { SFX_Deny(); NextTurnItems(); }
                    
                    break;
                case 10:
                    //Buy_Up_10_Wall_R();
                    break;
            }
        }
    }
    private void Unlock_Up_1_Wall_R()
    {
        if (GC.Player_SpareParts >= 50)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -= 50;
            GC.Wall_R = true;
            GC.Wall_R_Upg = 1;
            wall_Right_None.SetActive(false);
            wall_Right_Up_1.SetActive(true);
            wall_Left_None.SetActive(false);
            wall_Left_Up_1.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Wall(50, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_2_Wall_R()
    {
        if (GC.Player_SpareParts >= 25)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -=25;
            GC.Wall_R_Upg = 2;
            wall_Right_Up_1.SetActive(false);
            wall_Right_Up_2.SetActive(true);
            wall_Left_Up_1.SetActive(false);
            wall_Left_Up_2.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Wall(25, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_3_Wall_R()
    {
        if (GC.Player_SpareParts >= 50)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -=50;
            GC.Wall_R_Upg = 3;
            wall_Right_Up_2.SetActive(false);
            wall_Right_Up_3.SetActive(true);
            wall_Left_Up_2.SetActive(false);
            wall_Left_Up_3.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Wall(50, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_4_Wall_R()
    {
        if (GC.Player_SpareParts >= 75)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -=75;
            GC.Wall_R_Upg = 4;
            wall_Right_Up_3.SetActive(false);
            wall_Right_Up_4.SetActive(true);
            wall_Left_Up_3.SetActive(false);
            wall_Left_Up_4.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Wall(75, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_5_Wall_R()
    {
        if (GC.Player_SpareParts >= 100)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -=100;
            GC.Wall_R_Upg = 5;
            wall_Right_Up_4.SetActive(false);
            wall_Right_Up_5.SetActive(true);
            wall_Left_Up_4.SetActive(false);
            wall_Left_Up_5.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Wall(100, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_6_Wall_R()
    {
        if (GC.Player_SpareParts >= 125)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -=125;
            GC.Wall_R_Upg = 6;
            wall_Right_Up_5.SetActive(false);
            wall_Right_Up_6.SetActive(true);
            wall_Left_Up_5.SetActive(false);
            wall_Left_Up_6.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Wall(125, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_7_Wall_R()
    {
        if (GC.Player_SpareParts >= 150)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -=150;
            GC.Wall_R_Upg = 7;
            wall_Right_Up_6.SetActive(false);
            wall_Right_Up_7.SetActive(true);
            wall_Left_Up_6.SetActive(false);
            wall_Left_Up_7.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Wall(150, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_8_Wall_R()
    {
        if (GC.Player_SpareParts >= 175)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -=175;
            GC.Wall_R_Upg = 8;
            wall_Right_Up_7.SetActive(false);
            wall_Right_Up_8.SetActive(true);
            wall_Left_Up_7.SetActive(false);
            wall_Left_Up_8.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Wall(175, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_9_Wall_R()
    {
        if (GC.Player_SpareParts >= 200)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -=200;
            GC.Wall_R_Upg = 9;
            wall_Right_Up_8.SetActive(false);
            wall_Right_Up_9.SetActive(true);
            wall_Left_Up_8.SetActive(false);
            wall_Left_Up_9.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Wall(200, 0, 0, 0, 0, 0);
        }
        else
        {
            SFX_Deny();
        }
    }
    private void Buy_Up_To_10_Wall_R()
    {
        if (GC.Player_SpareParts >= 225)
        {
            GC.Player_Tasks -= 1;
            GC.Player_SpareParts -=225;
            GC.Wall_R_Upg = 10;
            wall_Right_Up_9.SetActive(false);
            wall_Right_Up_10.SetActive(true);

            wall_Right_Button.interactable = false;
            wall_Left_Up_9.SetActive(false);
            wall_Left_Up_10.SetActive(true); DiplayUiStats();
            SFX_Building(); SetGCResourceValues_Wall(225, 0, 0, 0, 0, 0);

            wall_Left_Button.interactable = false;
        }
        else
        {
            SFX_Deny();
        }
    }
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
        if (GC.Bedroom_Lvl1_L) { // 25
            switch (GC.Bedroom_Upg_Lvl1_L)
            {
                case 1:
                    Check_1_Bedroom_Lvl1_L(); SetGCResourceValues_Bedroom_Lvl1_L(25, 0, 0, 0, 0, 0);
                    break;
                case 2:
                    Check_2_Bedroom_Lvl1_L(); SetGCResourceValues_Bedroom_Lvl1_L(50, 0, 0, 0, 0, 0);
                    break;
                case 3:
                    Check_3_Bedroom_Lvl1_L(); SetGCResourceValues_Bedroom_Lvl1_L(75, 0, 0, 0, 0, 0);
                    break;
                case 4:
                    Check_4_Bedroom_Lvl1_L(); SetGCResourceValues_Bedroom_Lvl1_L(100, 0, 0, 0, 0, 0);
                    break;
                case 5:
                    Check_5_Bedroom_Lvl1_L(); SetGCResourceValues_Bedroom_Lvl1_L(125, 0, 0, 0, 0, 0);
                    break;
                case 6:
                    Check_6_Bedroom_Lvl1_L(); SetGCResourceValues_Bedroom_Lvl1_L(150, 0, 0, 0, 0, 0);
                    break;
                case 7:
                    Check_7_Bedroom_Lvl1_L(); SetGCResourceValues_Bedroom_Lvl1_L(175, 0, 0, 0, 0, 0);
                    break;
                case 8:
                    Check_8_Bedroom_Lvl1_L(); SetGCResourceValues_Bedroom_Lvl1_L(200, 0, 0, 0, 0, 0);
                    break;
                case 9:
                    Check_9_Bedroom_Lvl1_L(); SetGCResourceValues_Bedroom_Lvl1_L(225, 0, 0, 0, 0, 0);
                    break;
                case 10:
                    Check_10_Bedroom_Lvl1_L();
                    break;
            }
        }
        else { Check_Locked_Bedroom_Lvl1_L(); SetGCResourceValues_Bedroom_Lvl1_L(50, 0, 0, 0, 0, 0); }
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
        
        bedroom_lvl1_L_Button.interactable = false;
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
                    Check_1_Bedroom_Lvl1_R(); SetGCResourceValues_Bedroom_Lvl1_R(25, 0, 0, 0, 0, 0);
                    break;
                case 2:
                    Check_2_Bedroom_Lvl1_R(); SetGCResourceValues_Bedroom_Lvl1_R(50, 0, 0, 0, 0, 0);
                    break;
                case 3:
                    Check_3_Bedroom_Lvl1_R(); SetGCResourceValues_Bedroom_Lvl1_R(75, 0, 0, 0, 0, 0);
                    break;
                case 4:
                    Check_4_Bedroom_Lvl1_R(); SetGCResourceValues_Bedroom_Lvl1_R(100, 0, 0, 0, 0, 0);
                    break;
                case 5:
                    Check_5_Bedroom_Lvl1_R(); SetGCResourceValues_Bedroom_Lvl1_R(125, 0, 0, 0, 0, 0);
                    break;
                case 6:
                    Check_6_Bedroom_Lvl1_R(); SetGCResourceValues_Bedroom_Lvl1_R(150, 0, 0, 0, 0, 0);
                    break;
                case 7:
                    Check_7_Bedroom_Lvl1_R(); SetGCResourceValues_Bedroom_Lvl1_R(175, 0, 0, 0, 0, 0);
                    break;
                case 8:
                    Check_8_Bedroom_Lvl1_R(); SetGCResourceValues_Bedroom_Lvl1_R(200, 0, 0, 0, 0, 0);
                    break;
                case 9:
                    Check_9_Bedroom_Lvl1_R(); SetGCResourceValues_Bedroom_Lvl1_R(225, 0, 0, 0, 0, 0);
                    break;
                case 10:
                    Check_10_Bedroom_Lvl1_R();
                    break;
            }
        }
        else { Check_Locked_Bedroom_Lvl1_R(); SetGCResourceValues_Bedroom_Lvl1_R(50, 0, 0, 0, 0, 0); }
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
        
        bedroom_Lvl1_R_Button.interactable = false;
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
                    Check_1_Bedroom_Lvl2_L(); SetGCResourceValues_Bedroom_Lvl2_L(150, 0, 0, 0, 0, 0);
                    break;
                case 2:
                    Check_2_Bedroom_Lvl2_L(); SetGCResourceValues_Bedroom_Lvl2_L(175, 0, 0, 0, 0, 0);
                    break;
                case 3:
                    Check_3_Bedroom_Lvl2_L(); SetGCResourceValues_Bedroom_Lvl2_L(200, 0, 0, 0, 0, 0);
                    break;
                case 4:
                    Check_4_Bedroom_Lvl2_L(); SetGCResourceValues_Bedroom_Lvl2_L(225, 0, 0, 0, 0, 0);
                    break;
                case 5:
                    Check_5_Bedroom_Lvl2_L(); SetGCResourceValues_Bedroom_Lvl2_L(250, 0, 0, 0, 0, 0);
                    break;
                case 6:
                    Check_6_Bedroom_Lvl2_L(); SetGCResourceValues_Bedroom_Lvl2_L(275, 0, 0, 0, 0, 0);
                    break;
                case 7:
                    Check_7_Bedroom_Lvl2_L(); SetGCResourceValues_Bedroom_Lvl2_L(300, 0, 0, 0, 0, 0);
                    break;
                case 8:
                    Check_8_Bedroom_Lvl2_L(); SetGCResourceValues_Bedroom_Lvl2_L(325, 0, 0, 0, 0, 0);
                    break;
                case 9:
                    Check_9_Bedroom_Lvl2_L(); SetGCResourceValues_Bedroom_Lvl2_L(350, 0, 0, 0, 0, 0);
                    break;
                case 10:
                    Check_10_Bedroom_Lvl2_L();
                    break;
            }
        }
        else { Check_Locked_Bedroom_Lvl2_L(); SetGCResourceValues_Bedroom_Lvl2_L(125, 0, 0, 0, 0, 0); }
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
        
        bedroom_Lvl2_L_Button.interactable = false;
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
                    Check_1_Bedroom_Lvl2_R(); SetGCResourceValues_Bedroom_Lvl2_R(150, 0, 0, 0, 0, 0);
                    break;
                case 2:
                    Check_2_Bedroom_Lvl2_R(); SetGCResourceValues_Bedroom_Lvl2_R(175, 0, 0, 0, 0, 0);
                    break;
                case 3:
                    Check_3_Bedroom_Lvl2_R(); SetGCResourceValues_Bedroom_Lvl2_R(200, 0, 0, 0, 0, 0);
                    break;
                case 4:
                    Check_4_Bedroom_Lvl2_R(); SetGCResourceValues_Bedroom_Lvl2_R(225, 0, 0, 0, 0, 0);
                    break;
                case 5:
                    Check_5_Bedroom_Lvl2_R(); SetGCResourceValues_Bedroom_Lvl2_R(250, 0, 0, 0, 0, 0);
                    break;
                case 6:
                    Check_6_Bedroom_Lvl2_R(); SetGCResourceValues_Bedroom_Lvl2_R(275, 0, 0, 0, 0, 0);
                    break;
                case 7:
                    Check_7_Bedroom_Lvl2_R(); SetGCResourceValues_Bedroom_Lvl2_R(300, 0, 0, 0, 0, 0);
                    break;
                case 8:
                    Check_8_Bedroom_Lvl2_R(); SetGCResourceValues_Bedroom_Lvl2_R(325, 0, 0, 0, 0, 0);
                    break;
                case 9:
                    Check_9_Bedroom_Lvl2_R(); SetGCResourceValues_Bedroom_Lvl2_R(350, 0, 0, 0, 0, 0);
                    break;
                case 10:
                    Check_10_Bedroom_Lvl2_R();
                    break;
            }
        }
        else { Check_Locked_Bedroom_Lvl2_R(); SetGCResourceValues_Bedroom_Lvl2_R(125, 0, 0, 0, 0, 0); }
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
        
        bedroom_Lvl2_R_Button.interactable = false;
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
                    Check_1_Bedroom_Lvl3_L(); SetGCResourceValues_Bedroom_Lvl3_L(275, 0, 0, 0, 0, 0);
                    break;
                case 2:
                    Check_2_Bedroom_Lvl3_L(); SetGCResourceValues_Bedroom_Lvl3_L(300, 0, 0, 0, 0, 0);
                    break;
                case 3:
                    Check_3_Bedroom_Lvl3_L(); SetGCResourceValues_Bedroom_Lvl3_L(325, 0, 0, 0, 0, 0);
                    break;
                case 4:
                    Check_4_Bedroom_Lvl3_L(); SetGCResourceValues_Bedroom_Lvl3_L(350, 0, 0, 0, 0, 0);
                    break;
                case 5:
                    Check_5_Bedroom_Lvl3_L(); SetGCResourceValues_Bedroom_Lvl3_L(375, 0, 0, 0, 0, 0);
                    break;
                case 6:
                    Check_6_Bedroom_Lvl3_L(); SetGCResourceValues_Bedroom_Lvl3_L(400, 0, 0, 0, 0, 0);
                    break;
                case 7:
                    Check_7_Bedroom_Lvl3_L(); SetGCResourceValues_Bedroom_Lvl3_L(425, 0, 0, 0, 0, 0);
                    break;
                case 8:
                    Check_8_Bedroom_Lvl3_L(); SetGCResourceValues_Bedroom_Lvl3_L(450, 0, 0, 0, 0, 0);
                    break;
                case 9:
                    Check_9_Bedroom_Lvl3_L(); SetGCResourceValues_Bedroom_Lvl3_L(475, 0, 0, 0, 0, 0);
                    break;
                case 10:
                    Check_10_Bedroom_Lvl3_L();
                    break;
            }
        }
        else { Check_Locked_Bedroom_Lvl3_L(); SetGCResourceValues_Bedroom_Lvl3_L(250, 0, 0, 0, 0, 0); }
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
        
        bedroom_Lvl3_L_Button.interactable = false;
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
                    Check_1_Bedroom_Lvl3_R(); SetGCResourceValues_Bedroom_Lvl3_R(275, 0, 0, 0, 0, 0);
                    break;
                case 2:
                    Check_2_Bedroom_Lvl3_R(); SetGCResourceValues_Bedroom_Lvl3_R(300, 0, 0, 0, 0, 0);
                    break;
                case 3:
                    Check_3_Bedroom_Lvl3_R(); SetGCResourceValues_Bedroom_Lvl3_R(325, 0, 0, 0, 0, 0);
                    break;
                case 4:
                    Check_4_Bedroom_Lvl3_R(); SetGCResourceValues_Bedroom_Lvl3_R(350, 0, 0, 0, 0, 0);
                    break;
                case 5:
                    Check_5_Bedroom_Lvl3_R(); SetGCResourceValues_Bedroom_Lvl3_R(375, 0, 0, 0, 0, 0);
                    break;
                case 6:
                    Check_6_Bedroom_Lvl3_R(); SetGCResourceValues_Bedroom_Lvl3_R(400, 0, 0, 0, 0, 0);
                    break;
                case 7:
                    Check_7_Bedroom_Lvl3_R(); SetGCResourceValues_Bedroom_Lvl3_R(425, 0, 0, 0, 0, 0);
                    break;
                case 8:
                    Check_8_Bedroom_Lvl3_R(); SetGCResourceValues_Bedroom_Lvl3_R(450, 0, 0, 0, 0, 0);
                    break;
                case 9:
                    Check_9_Bedroom_Lvl3_R(); SetGCResourceValues_Bedroom_Lvl3_R(475, 0, 0, 0, 0, 0);
                    break;
                case 10:
                    Check_10_Bedroom_Lvl3_R();
                    break;
            }
        }
        else { Check_Locked_Bedroom_Lvl3_R(); SetGCResourceValues_Bedroom_Lvl3_R(250, 0, 0, 0, 0, 0); }
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
        
        bedroom_Lvl3_R_Button.interactable = false;
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
            
            stairs_2_Button.interactable = false;
        }
        else
        {
            stairs_2_Locked.SetActive(true);
            stairs_2_Unlocked.SetActive(false); DiplayUiStats();
            SetGCResourceValues_Stairs_2(25, 0, 0, 0, 0, 0);
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

            stairs_3_Button.interactable = false;
        }
        else
        {
            stairs_3_Locked.SetActive(true);
            stairs_3_Unlocked.SetActive(false); DiplayUiStats();
            SetGCResourceValues_Stairs_3(125, 0, 0, 0, 0, 0);
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
                SetGCResourceValues_Expedition(0, purchaseValue, purchaseValue, purchaseValue, 0, 0);
                break;
            case 2:
                Check_2_Expedition();
                SetGCResourceValues_Expedition(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
                break;
            case 3:
                Check_3_Expedition();
                SetGCResourceValues_Expedition(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
                break;
            case 4:
                Check_4_Expedition();
                SetGCResourceValues_Expedition(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);
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
        
        expedition_Lvl1_R1_Button.interactable = false;
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
                SetGCResourceValues_Training(0, purchaseValue, purchaseValue, purchaseValue, 0, 0);
                break;
            case 2:
                Check_2_Training();
                SetGCResourceValues_Training(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
                break;
            case 3:
                Check_3_Training();
                SetGCResourceValues_Training(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
                break;
            case 4:
                Check_4_Training();
                SetGCResourceValues_Training(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);
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
        
        training_Lvl1_R2_Button.interactable = false;
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
                SetGCResourceValues_Garden(0, purchaseValue, purchaseValue, purchaseValue, 0, 0);
                break;
            case 2:
                Check_2_UnderGarden();
                SetGCResourceValues_Garden(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
                break;
            case 3:
                Check_3_UnderGarden();
                SetGCResourceValues_Garden(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
                break;
            case 4:
                Check_4_UnderGarden();
                SetGCResourceValues_Garden(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);
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

        underGarden_Lvl1_L1_Button.interactable = false;
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
                SetGCResourceValues_Radio(0, purchaseValue, purchaseValue, purchaseValue, 0, 0);
                break;
            case 2:
                Check_2_Radio();
                SetGCResourceValues_Radio(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
                break;
            case 3:
                Check_3_Radio();
                SetGCResourceValues_Radio(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
                break;
            case 4:
                Check_4_Radio();
                SetGCResourceValues_Radio(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);
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
        
        radio_Lvl1_L2_Button.interactable = false;
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
                    SetGCResourceValues_Generator_1(0, purchaseValue, purchaseValue, purchaseValue, 0, 0);
                    break;
                case 2:
                    Check_2_Generator_1();
                    SetGCResourceValues_Generator_1(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
                    break;
                case 3:
                    Check_3_Generator_1();
                    SetGCResourceValues_Generator_1(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
                    break;
                case 4:
                    Check_4_Generator_1();
                    SetGCResourceValues_Generator_1(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);
                    break;
                case 5:
                    Check_5_Generator_1();
                    break;
            }
        }
        else { Check_Locked_Generator_1();
            SetGCResourceValues_Generator_1(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
        }
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
        
        generator_Lvl2_R1_Button.interactable = false;
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
                    SetGCResourceValues_Generator_2(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
                    break;
                case 2:
                    Check_2_Generator_2();
                    SetGCResourceValues_Generator_2(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
                    break;
                case 3:
                    Check_3_Generator_2();
                    SetGCResourceValues_Generator_2(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);
                    break;
                case 4:
                    Check_4_Generator_2();
                    SetGCResourceValues_Generator_2(0, (purchaseValue * 16), (purchaseValue * 16), (purchaseValue * 16), 0, 0);
                    break;
                case 5:
                    Check_5_Generator_2();
                    break;
            }
        }
        else { Check_Locked_Generator_2();
            SetGCResourceValues_Generator_2(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
        }
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
        
        generator_Lvl2_R2_Button.interactable = false;
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
                    SetGCResourceValues_Workshop_1(0, purchaseValue, purchaseValue, purchaseValue, 0, 0);
                    break;
                case 2:
                    Check_2_Workshop_1();
                    SetGCResourceValues_Workshop_1(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
                    break;
                case 3:
                    Check_3_Workshop_1();
                    SetGCResourceValues_Workshop_1(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
                    break;
                case 4:
                    Check_4_Workshop_1();
                    SetGCResourceValues_Workshop_1(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);
                    break;
                case 5:
                    Check_5_Workshop_1();
                    break;
            }
        }
        else { Check_Locked_Workshop_1();
            SetGCResourceValues_Workshop_1(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
        }
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
        
        workshop_Lvl2_L1_Button.interactable = false;
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
                    SetGCResourceValues_Workshop_2(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
                    break;
                case 2:
                    Check_2_Workshop_2();
                    SetGCResourceValues_Workshop_2(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
                    break;
                case 3:
                    Check_3_Workshop_2();
                    SetGCResourceValues_Workshop_2(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);
                    break;
                case 4:
                    Check_4_Workshop_2();
                    SetGCResourceValues_Workshop_2(0, (purchaseValue * 16), (purchaseValue * 16), (purchaseValue * 16), 0, 0);
                    break;
                case 5:
                    Check_5_Workshop_2();
                    break;
            }
        }
        else { Check_Locked_Workshop_2();
            SetGCResourceValues_Workshop_2(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
        }
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
        
        workshop_Lvl2_L2_Button.interactable = false;
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
                    SetGCResourceValues_LivingSpace_1(0, purchaseValue, purchaseValue, purchaseValue, 0, 0);
                    break;
                case 2:
                    Check_2_LivingSpace_1();
                    SetGCResourceValues_LivingSpace_1(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
                    break;
                case 3:
                    Check_3_LivingSpace_1();
                    SetGCResourceValues_LivingSpace_1(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
                    break;
                case 4:
                    Check_4_LivingSpace_1();
                    SetGCResourceValues_LivingSpace_1(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);
                    break;
                case 5:
                    Check_5_LivingSpace_1();
                    break;
            }
        }
        else { Check_Locked_LivingSpace_1();
            SetGCResourceValues_LivingSpace_1(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
        }
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
        
        livingSpace_Lvl3_R1_Button.interactable = false;
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
                    SetGCResourceValues_LivingSpace_2(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
                    break;
                case 2:
                    Check_2_LivingSpace_2();
                    SetGCResourceValues_LivingSpace_2(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
                    break;
                case 3:
                    Check_3_LivingSpace_2();
                    SetGCResourceValues_LivingSpace_2(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);
                    break;
                case 4:
                    Check_4_LivingSpace_2();
                    SetGCResourceValues_LivingSpace_2(0, (purchaseValue * 16), (purchaseValue * 16), (purchaseValue * 16), 0, 0);
                    break;
                case 5:
                    Check_5_LivingSpace_2();
                    break;
            }
        }
        else { Check_Locked_LivingSpace_2();
            SetGCResourceValues_LivingSpace_2(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
        }
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
        
        livingSpace_Lvl3_R2_Button.interactable = false;
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
                    SetGCResourceValues_Research_1(0, purchaseValue, purchaseValue, purchaseValue, 0, 0);
                    break;
                case 2:
                    Check_2_Research_1();
                    SetGCResourceValues_Research_1(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
                    break;
                case 3:
                    Check_3_Research_1();
                    SetGCResourceValues_Research_1(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
                    break;
                case 4:
                    Check_4_Research_1();
                    SetGCResourceValues_Research_1(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);
                    break;
                case 5:
                    Check_5_Research_1();
                    break;
            }
        }
        else { Check_Locked_Research_1();
            SetGCResourceValues_Research_1(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
        }
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
        
        research_Lvl3_L1_Button.interactable = false;
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
                    SetGCResourceValues_Research_2(0, (purchaseValue * 2), (purchaseValue * 2), (purchaseValue * 2), 0, 0);
                    break;
                case 2:
                    Check_2_Research_2();
                    SetGCResourceValues_Research_2(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
                    break;
                case 3:
                    Check_3_Research_2();
                    SetGCResourceValues_Research_2(0, (purchaseValue * 8), (purchaseValue * 8), (purchaseValue * 8), 0, 0);
                    break;
                case 4:
                    Check_4_Research_2();
                    SetGCResourceValues_Research_2(0, (purchaseValue * 16), (purchaseValue * 16), (purchaseValue * 16), 0, 0);
                    break;
                case 5:
                    Check_5_Research_2();
                    break;
            }
        }
        else { Check_Locked_Research_2();
            SetGCResourceValues_Research_2(0, (purchaseValue * 4), (purchaseValue * 4), (purchaseValue * 4), 0, 0);
        }
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
        
        research_Lvl3_L2_Button.interactable = false;
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

        wall_Left_Button.interactable = false;
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
                    Check_Save_1_Wall_R(); SetGCResourceValues_Wall(25, 0, 0, 0, 0, 0);
                    break;
                case 2:
                    Check_Save_2_Wall_R(); SetGCResourceValues_Wall(50, 0, 0, 0, 0, 0);
                    break;
                case 3:
                    Check_Save_3_Wall_R(); SetGCResourceValues_Wall(75, 0, 0, 0, 0, 0);
                    break;
                case 4:
                    Check_Save_4_Wall_R(); SetGCResourceValues_Wall(100, 0, 0, 0, 0, 0);
                    break;
                case 5:
                    Check_Save_5_Wall_R(); SetGCResourceValues_Wall(125, 0, 0, 0, 0, 0);
                    break;
                case 6:
                    Check_Save_6_Wall_R(); SetGCResourceValues_Wall(150, 0, 0, 0, 0, 0);
                    break;
                case 7:
                    Check_Save_7_Wall_R(); SetGCResourceValues_Wall(175, 0, 0, 0, 0, 0);
                    break;
                case 8:
                    Check_Save_8_Wall_R(); SetGCResourceValues_Wall(200, 0, 0, 0, 0, 0);
                    break;
                case 9:
                    Check_Save_9_Wall_R(); SetGCResourceValues_Wall(225, 0, 0, 0, 0, 0);
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
        wall_Right_None.SetActive(true); wall_Left_None.SetActive(true); DiplayUiStats();
    }
    private void Check_Save_1_Wall_R()
    {
        wall_Right_None.SetActive(false);
        wall_Right_Up_1.SetActive(true);
        wall_Left_None.SetActive(false);
        wall_Left_Up_1.SetActive(true); DiplayUiStats();
    }
    private void Check_Save_2_Wall_R()
    {
        wall_Right_Up_1.SetActive(false);
        wall_Right_Up_2.SetActive(true);
        wall_Left_Up_1.SetActive(false);
        wall_Left_Up_2.SetActive(true); DiplayUiStats();
    }
    private void Check_Save_3_Wall_R()
    {
        wall_Right_Up_2.SetActive(false);
        wall_Right_Up_3.SetActive(true);
        wall_Left_Up_2.SetActive(false);
        wall_Left_Up_3.SetActive(true); DiplayUiStats();
    }
    private void Check_Save_4_Wall_R()
    {
        wall_Right_Up_3.SetActive(false);
        wall_Right_Up_4.SetActive(true);
        wall_Left_Up_3.SetActive(false);
        wall_Left_Up_4.SetActive(true); DiplayUiStats();
    }
    private void Check_Save_5_Wall_R()
    {
        wall_Right_Up_4.SetActive(false);
        wall_Right_Up_5.SetActive(true);
        wall_Left_Up_4.SetActive(false);
        wall_Left_Up_5.SetActive(true); DiplayUiStats();
    }
    private void Check_Save_6_Wall_R()
    {
        wall_Right_Up_5.SetActive(false);
        wall_Right_Up_6.SetActive(true);
        wall_Left_Up_5.SetActive(false);
        wall_Left_Up_6.SetActive(true); DiplayUiStats();
    }
    private void Check_Save_7_Wall_R()
    {
        wall_Right_Up_6.SetActive(false);
        wall_Right_Up_7.SetActive(true);
        wall_Left_Up_6.SetActive(false);
        wall_Left_Up_7.SetActive(true); DiplayUiStats();
    }
    private void Check_Save_8_Wall_R()
    {
        wall_Right_Up_7.SetActive(false);
        wall_Right_Up_8.SetActive(true);
        wall_Left_Up_7.SetActive(false);
        wall_Left_Up_8.SetActive(true); DiplayUiStats();
    }
    private void Check_Save_9_Wall_R()
    {
        wall_Right_Up_8.SetActive(false);
        wall_Right_Up_9.SetActive(true);
        wall_Left_Up_8.SetActive(false);
        wall_Left_Up_9.SetActive(true); DiplayUiStats();
    }
    private void Check_Save_10_Wall_R()
    {
        wall_Right_Up_9.SetActive(false);
        wall_Right_Up_10.SetActive(true);

        wall_Right_Button.interactable = false;

        wall_Left_Up_9.SetActive(false);
        wall_Left_Up_10.SetActive(true); DiplayUiStats();

        wall_Left_Button.interactable = false;
    }
    #endregion
    #endregion
    #endregion
    public void SFX_Button()
    {
        SM.OneSound_MenuButton();
    }
    public void SFX_Gather()
    {
        SM.OneSound_Collect();
    }
    public void SFX_Building()
    {
        SM.OneSound_Building();
    }
    public void SFX_Deny()
    {
        SM.OneSound_Deny();
    }
    public void SFX_EndTurn()
    {
        SM.OneSound_EndTurn();
    }
}
