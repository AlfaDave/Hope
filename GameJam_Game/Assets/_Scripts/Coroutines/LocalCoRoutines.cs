using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LocalCoRoutines : MonoBehaviour
{
    //private CoRoutines_BonusMiniGame_WhackADino coRoutines_BonusMiniGame_WhackADino;
    //private CoRoutines_Game coRoutines_Game;
    //private CoRoutines_Game_ChildMode coRoutines_Game_ChildMode;
    //private CoRoutines_Game_HardCore coRoutines_Game_HardCore;
    //private CoRoutines_ResultsVsBattleWinDisplay_Local coRoutines_ResultsVsBattleWinDisplay_Local;
    //private CoRoutines_VSGameBattle coRoutines_VSGameBattle;
    //private CoRoutines_VSGameBattle4Local coRoutines_VSGameBattle4Local;
    //private CoRoutines_VSGameBattleRoyaleOnline_MatchResults coRoutines_VSGameBattleRoyaleOnline_MatchResults;
    private int target = 120;
    #region Scene Enum
    public enum Scene
    {
        /// <summary>
        /// Scenes in game
        /// </summary>
        Intro,
        SignIn,
        Tutorial,
        Start,
        Game,
        Game_ChildMode,
        Game_HardCore,
        VsBattleIntro,
        VsBattleIntroAi,
        VsBattleIntroAiPlus,
        VsBattleControlPicker,
        VsBattleBossUnlock,
        VsGame,
        VsGameBattle,
        VsGameBattle4Local,
        VsGameBattleRoyaleOnline,
        VsGameBattleRoyaleOnline_MatchWaiting,
        VsGameBattleRoyaleOnline_MatchResults,
        ResultsVsBattleWinDisplay,
        ResultsVsBattleWinDisplay_Local,
        ResultsVsBattle,
        BonusMiniGame_WhackADino,
        BonusMiniGame_WhackADino_BonusLevel,
        BonusMiniGame_WhackADino_DifLevel,
        BonusMiniGame_WhackADino_Results,
        Unlock_Music_Mp,
        Weldone,
        Results,
        ResultsAfterP1VsMode,
        ResultsVsMode,
        Unlocks_Theme_Music
    }
    #endregion
    public Scene scene;
    #region LocalSpecificCoRoutines
    #endregion
    private void Start()
    {
        StartCoroutine(CheckGameSpeedChanges());
    }
    public void OnSuspend()
    {
        OnSuspendCoroutines();
    }
    public void OnResume()
    {
        OnResumeCoroutines();
    }

    private void OnSuspendCoroutines()
    {
        CoRoutinesRunningOnAllScenes(false);
        switch (scene)
        {
            case Scene.BonusMiniGame_WhackADino:
                Scene_BonusMiniGame_WhackADino(false);
                break;
            case Scene.BonusMiniGame_WhackADino_BonusLevel:
                Scene_BonusMiniGame_WhackADino_BonusLevel(false);
                break;
            case Scene.BonusMiniGame_WhackADino_DifLevel:
                Scene_BonusMiniGame_WhackADino_DifLevel(false);
                break;
            case Scene.BonusMiniGame_WhackADino_Results:
                Scene_BonusMiniGame_WhackADino_Results(false);
                break;
            case Scene.Game:
                Scene_Game(false);
                break;
            case Scene.Game_ChildMode:
                Scene_Game_ChildMode(false);
                break;
            case Scene.Game_HardCore:
                Scene_Game_HardCore(false);
                break;
            case Scene.Intro:
                Scene_Intro(false);
                break;
            case Scene.Results:
                Scene_Results(false);
                break;
            case Scene.ResultsAfterP1VsMode:
                Scene_ResultsAfterP1VsMode(false);
                break;
            case Scene.ResultsVsBattle:
                Scene_ResultsVsBattle(false);
                break;
            case Scene.ResultsVsBattleWinDisplay:
                Scene_ResultsVsBattleWinDisplay(false);
                break;
            case Scene.ResultsVsBattleWinDisplay_Local:
                Scene_ResultsVsBattleWinDisplay_Local(false);
                break;
            case Scene.ResultsVsMode:
                Scene_ResultsVsMode(false);
                break;
            case Scene.SignIn:
                Scene_SignIn(false);
                break;
            case Scene.Start:
                Scene_Start(false);
                break;
            case Scene.Tutorial:
                Scene_Tutorial(false);
                break;
            case Scene.Unlocks_Theme_Music:
                Scene_Unlocks_Theme_Music(false);
                break;
            case Scene.Unlock_Music_Mp:
                Scene_Unlock_Music_Mp(false);
                break;
            case Scene.VsBattleBossUnlock:
                Scene_VsBattleBossUnlock(false);
                break;
            case Scene.VsBattleControlPicker:
                Scene_VsBattleControlPicker(false);
                break;
            case Scene.VsBattleIntro:
                Scene_VsBattleIntro(false);
                break;
            case Scene.VsBattleIntroAi:
                Scene_VsBattleIntroAi(false);
                break;
            case Scene.VsBattleIntroAiPlus:
                Scene_VsBattleIntroAiPlus(false);
                break;
            case Scene.VsGame:
                Scene_VSGame(false);
                break;
            case Scene.VsGameBattle:
                Scene_VSGameBattle(false);
                break;
            case Scene.VsGameBattle4Local:
                Scene_VSGameBattle4Local(false);
                break;
            case Scene.VsGameBattleRoyaleOnline:
                Scene_VSGameBattleRoyaleOnline(false);
                break;
            case Scene.VsGameBattleRoyaleOnline_MatchResults:
                Scene_VSGameBattleRoyaleOnline_MatchResults(false);
                break;
            case Scene.VsGameBattleRoyaleOnline_MatchWaiting:
                Scene_VSGameBattleRoyaleOnline_MatchWaiting(false);
                break;
            case Scene.Weldone:
                Scene_Weldone(false);
                break;
        }
    }
    private void OnResumeCoroutines()
    {
        CoRoutinesRunningOnAllScenes(true);
        switch (scene)
        {
            case Scene.BonusMiniGame_WhackADino:
                Scene_BonusMiniGame_WhackADino(true);
                break;
            case Scene.BonusMiniGame_WhackADino_BonusLevel:
                Scene_BonusMiniGame_WhackADino_BonusLevel(true);
                break;
            case Scene.BonusMiniGame_WhackADino_DifLevel:
                Scene_BonusMiniGame_WhackADino_DifLevel(true);
                break;
            case Scene.BonusMiniGame_WhackADino_Results:
                Scene_BonusMiniGame_WhackADino_Results(true);
                break;
            case Scene.Game:
                Scene_Game(true);
                break;
            case Scene.Game_ChildMode:
                Scene_Game_ChildMode(true);
                break;
            case Scene.Game_HardCore:
                Scene_Game_HardCore(true);
                break;
            case Scene.Intro:
                Scene_Intro(true);
                break;
            case Scene.Results:
                Scene_Results(true);
                break;
            case Scene.ResultsAfterP1VsMode:
                Scene_ResultsAfterP1VsMode(true);
                break;
            case Scene.ResultsVsBattle:
                Scene_ResultsVsBattle(true);
                break;
            case Scene.ResultsVsBattleWinDisplay:
                Scene_ResultsVsBattleWinDisplay(true);
                break;
            case Scene.ResultsVsBattleWinDisplay_Local:
                Scene_ResultsVsBattleWinDisplay_Local(true);
                break;
            case Scene.ResultsVsMode:
                Scene_ResultsVsMode(true);
                break;
            case Scene.SignIn:
                Scene_SignIn(true);
                break;
            case Scene.Start:
                Scene_Start(true);
                break;
            case Scene.Tutorial:
                Scene_Tutorial(true);
                break;
            case Scene.Unlocks_Theme_Music:
                Scene_Unlocks_Theme_Music(true);
                break;
            case Scene.Unlock_Music_Mp:
                Scene_Unlock_Music_Mp(true);
                break;
            case Scene.VsBattleBossUnlock:
                Scene_VsBattleBossUnlock(true);
                break;
            case Scene.VsBattleControlPicker:
                Scene_VsBattleControlPicker(true);
                break;
            case Scene.VsBattleIntro:
                Scene_VsBattleIntro(true);
                break;
            case Scene.VsBattleIntroAi:
                Scene_VsBattleIntroAi(true);
                break;
            case Scene.VsBattleIntroAiPlus:
                Scene_VsBattleIntroAiPlus(true);
                break;
            case Scene.VsGame:
                Scene_VSGame(true);
                break;
            case Scene.VsGameBattle:
                Scene_VSGameBattle(true);
                break;
            case Scene.VsGameBattle4Local:
                Scene_VSGameBattle4Local(true);
                break;
            case Scene.VsGameBattleRoyaleOnline:
                Scene_VSGameBattleRoyaleOnline(true);
                break;
            case Scene.VsGameBattleRoyaleOnline_MatchResults:
                Scene_VSGameBattleRoyaleOnline_MatchResults(true);
                break;
            case Scene.VsGameBattleRoyaleOnline_MatchWaiting:
                Scene_VSGameBattleRoyaleOnline_MatchWaiting(true);
                break;
            case Scene.Weldone:
                Scene_Weldone(true);
                break;
        }
    }
    //
    #region Does not have CoRoutines (yet)
    private void Scene_Intro(bool state)
    {

    }
    private void Scene_Tutorial(bool state)
    {

    }
    #endregion
    //
    #region Has CoRoutines
    private void Scene_BonusMiniGame_WhackADino(bool state)
    {
        //if (coRoutines_BonusMiniGame_WhackADino == null) { coRoutines_BonusMiniGame_WhackADino = GameObject.Find("SceneItems").GetComponent<CoRoutines_BonusMiniGame_WhackADino>(); }
        if (state)
        {
            // resume
            //coRoutines_BonusMiniGame_WhackADino.StartCoroutines();
        }
        else
        {
            // suspend
            //coRoutines_BonusMiniGame_WhackADino.StopCoroutines();
        }
    }
    private void Scene_Game(bool state)
    {
        //if (coRoutines_Game == null) { coRoutines_Game = GameObject.Find("SceneItems").GetComponent<CoRoutines_Game>(); }
        if (state)
        {
            // resume
            //coRoutines_Game.StartCoroutines();
        }
        else
        {
            // suspend
            //coRoutines_Game.StopCoroutines();
        }
    }
    private void Scene_Game_ChildMode(bool state)
    {
        //if (coRoutines_Game_ChildMode == null) { coRoutines_Game_ChildMode = GameObject.Find("SceneItems").GetComponent<CoRoutines_Game_ChildMode>(); }
        if (state)
        {
            // resume
            //coRoutines_Game_ChildMode.StartCoroutines();
        }
        else
        {
            // suspend
            //coRoutines_Game_ChildMode.StopCoroutines();
        }
    }
    private void Scene_Game_HardCore(bool state)
    {
        //if (coRoutines_Game_HardCore == null) { coRoutines_Game_HardCore = GameObject.Find("SceneItems").GetComponent<CoRoutines_Game_HardCore>(); }
        if (state)
        {
            // resume
            //coRoutines_Game_HardCore.StartCoroutines();
        }
        else
        {
            // suspend
            //coRoutines_Game_HardCore.StopCoroutines();
        }
    }
    private void Scene_ResultsVsBattleWinDisplay_Local(bool state)
    {
        //if (coRoutines_ResultsVsBattleWinDisplay_Local == null) { coRoutines_ResultsVsBattleWinDisplay_Local = GameObject.Find("SceneItems").GetComponent<CoRoutines_ResultsVsBattleWinDisplay_Local>(); }
        if (state)
        {
            // resume
            //coRoutines_ResultsVsBattleWinDisplay_Local.StartCoroutines();
        }
        else
        {
            // suspend
            //coRoutines_ResultsVsBattleWinDisplay_Local.StopCoroutines();
        }
    }
    private void Scene_VSGameBattle(bool state)
    {
        //if (coRoutines_VSGameBattle == null) { coRoutines_VSGameBattle = GameObject.Find("SceneItems").GetComponent<CoRoutines_VSGameBattle>(); }
        if (state)
        {
            // resume
            //coRoutines_VSGameBattle.StartCoroutines();
        }
        else
        {
            // suspend
            //coRoutines_VSGameBattle.StopCoroutines();
        }
    }
    private void Scene_VSGameBattle4Local(bool state)
    {
        //if (coRoutines_VSGameBattle4Local == null) { coRoutines_VSGameBattle4Local = GameObject.Find("SceneItems").GetComponent<CoRoutines_VSGameBattle4Local>(); }
        if (state)
        {
            // resume
            //coRoutines_VSGameBattle4Local.StartCoroutines();
        }
        else
        {
            // suspend
            //coRoutines_VSGameBattle4Local.StopCoroutines();
        }
    }

    private void Scene_VSGameBattleRoyaleOnline_MatchResults(bool state)
    {
        //if (coRoutines_VSGameBattleRoyaleOnline_MatchResults == null) { coRoutines_VSGameBattleRoyaleOnline_MatchResults = GameObject.Find("SceneItems").GetComponent<CoRoutines_VSGameBattleRoyaleOnline_MatchResults>(); }
        if (state)
        {
            // resume
            //coRoutines_VSGameBattleRoyaleOnline_MatchResults.StartCoroutines();
        }
        else
        {
            // suspend
            //coRoutines_VSGameBattleRoyaleOnline_MatchResults.StopCoroutines();
        }
    }
    #endregion
    private void Scene_BonusMiniGame_WhackADino_BonusLevel(bool state)
    {

    }
    private void Scene_BonusMiniGame_WhackADino_DifLevel(bool state)
    {

    }
    private void Scene_BonusMiniGame_WhackADino_Results(bool state)
    {

    }
    private void Scene_Results(bool state)
    {

    }
    private void Scene_ResultsAfterP1VsMode(bool state)
    {

    }
    private void Scene_ResultsVsBattle(bool state)
    {

    }
    private void Scene_ResultsVsBattleWinDisplay(bool state)
    {

    }
    private void Scene_ResultsVsMode(bool state)
    {

    }
    private void Scene_SignIn(bool state)
    {

    }
    private void Scene_Start(bool state)
    {

    }
    private void Scene_Unlocks_Theme_Music(bool state)
    {

    }
    private void Scene_Unlock_Music_Mp(bool state)
    {

    }
    private void Scene_VsBattleBossUnlock(bool state)
    {

    }
    private void Scene_VsBattleControlPicker(bool state)
    {

    }
    private void Scene_VsBattleIntro(bool state)
    {

    }
    private void Scene_VsBattleIntroAi(bool state)
    {

    }
    private void Scene_VsBattleIntroAiPlus(bool state)
    {

    }
    private void Scene_VSGame(bool state)
    {

    }
    private void Scene_VSGameBattleRoyaleOnline(bool state)
    {

    }
    private void Scene_VSGameBattleRoyaleOnline_MatchWaiting(bool state)
    {

    }
    private void Scene_Weldone(bool state)
    {

    }
    private void CoRoutinesRunningOnAllScenes(bool State)
    {
        switch (State)
        {
            case true:
                StartCoroutine(CheckGameSpeedChanges());
                break;
            case false:
                StopCoroutine(CheckGameSpeedChanges());
                break;
        }
    }
    IEnumerator CheckGameSpeedChanges()
    {
        while (true)
        {
            if (QualitySettings.vSyncCount == 1) { QualitySettings.vSyncCount = 0; }
            if (Application.targetFrameRate != target) { Application.targetFrameRate = target; }
            yield return new WaitForSeconds(10);
        }
    }
}
