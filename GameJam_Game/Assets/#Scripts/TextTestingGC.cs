using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextTestingGC : MonoBehaviour
{
    [SerializeField] internal GameObject displayText;
    private string example1 = "Press again bob", example2 = "Press again ted", example3 = "Press again Hardiment", example4 = "Press again Dave", example5 = "Press again Borat";
    private int randomNumber, randomNumberPrevious=100;
    private bool nameSaid1, nameSaid2, nameSaid3, nameSaid4, nameSaid5;

    private GameController GC;
    private void Start()
    {
        LoggingALogAndLogError();
    }
    public void ButtonPress()
    {
        ChangeText();
    }
    private void ChangeText()
    {
        string txt = GetRandomText();
        GameController.gameC.WriteOut(txt, displayText);
    }
    private void LoggingALogAndLogError()
    {
        // this way means you can type it out using prediction which is error free
        GameController.gameC.DebugLog("This log by a mistake Free Method");
        GameController.gameC.DebugError("This log Error by a mistake Free Method");
        // similar to above but shorter, can also be written like this if a pre reference is done in the scipts variable list
        GameObject i = GameController.gameC.LocateGameObjectByName("GameController");
        GC = i.GetComponent<GameController>();
        GC.DebugLog("This log by a mistake Free Method shortened");
        GC.DebugError("This log Error by a mistake Free Method shortened");
        // or just write it out directly but has hardly no prediction
        Debug.Log("This log");
        Debug.LogError("This log Error");
    }
    private string GetRandomText()
    {
        string text = "error";
        randomNumber = Random.Range(1, 6);
        if (randomNumber == randomNumberPrevious) { GetRandomText(); }
        randomNumberPrevious = randomNumber;
        switch (randomNumber)
        {
            case 1:
                text = example1;
                nameSaid1 = true;
                break;
            case 2:
                text = example2;
                nameSaid2 = true;
                break;
            case 3:
                text = example3;
                nameSaid3 = true;
                break;
            case 4:
                text = example4;
                nameSaid4 = true;
                break;
            case 5:
                text = example5;
                nameSaid5 = true;
                break;
        }
        if (nameSaid1 == true && nameSaid2 == true && nameSaid3 == true && nameSaid4 == true && nameSaid5 == true )
        { SaveGame.gameSave.LoadLevel("Finish"); }
        return text;
    }
}
