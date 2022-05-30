using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroTutorial : MonoBehaviour
{
    private GameController GC;
    [SerializeField] internal GameObject mainCanvas, intro_1,intro_2,intro_3,intro_4, intro_5, tutorial;
    private int scene = 1;
    private bool active=true;
    private float timer = 0.5f;
    void Start()
    {
        GC = GameObject.Find("GameController").GetComponent<GameController>();
        Intro_1();
    }
    private void Update()
    {
        if (!active) { timer -= Time.deltaTime; if (timer <= 0) { active = true; timer = 0.5f; } }
    }
    public void SkipTut()
    {
        GC.PlayerSkipTutorial = true;
        mainCanvas.SetActive(false);
    }
    public void Next()
    {
        if (active)
        {
            active = false;
            switch (scene)
            {
                case 1:
                    Intro_2();
                    break;
                case 2:
                    Intro_3();
                    break;
                case 3:
                    Intro_4();
                    break;
                case 4:
                    Intro_5();
                    break;
                case 5:
                    Tutorial();
                    break;
                case 6:
                    Exit();
                    break;
            }
        }
    }
    private void Intro_1()
    {
        scene = 1;
        intro_1.SetActive(true);
        intro_2.SetActive(false);
        intro_3.SetActive(false);
        intro_4.SetActive(false);
        intro_5.SetActive(false);
        tutorial.SetActive(false);
    }
    private void Intro_2()
    {
        scene = 2;
        intro_1.SetActive(false);
        intro_2.SetActive(true);
        intro_3.SetActive(false);
        intro_4.SetActive(false);
        intro_5.SetActive(false);
        tutorial.SetActive(false);
    }
    private void Intro_3()
    {
        scene = 3;
        intro_1.SetActive(false);
        intro_2.SetActive(false);
        intro_3.SetActive(true);
        intro_4.SetActive(false);
        intro_5.SetActive(false);
        tutorial.SetActive(false);
    }
    private void Intro_4()
    {
        scene = 4;
        intro_1.SetActive(false);
        intro_2.SetActive(false);
        intro_3.SetActive(false);
        intro_4.SetActive(true);
        intro_5.SetActive(false);
        tutorial.SetActive(false);
    }
    private void Intro_5()
    {

        scene = 5;
        intro_1.SetActive(false);
        intro_2.SetActive(false);
        intro_3.SetActive(false);
        intro_4.SetActive(false);
        intro_5.SetActive(true);
        tutorial.SetActive(false);
    }
    private void Tutorial()
    {
        scene = 6;
        intro_1.SetActive(false);
        intro_2.SetActive(false);
        intro_3.SetActive(false);
        intro_4.SetActive(false);
        intro_5.SetActive(false);
        tutorial.SetActive(true);
    }
    private void Exit()
    {
        mainCanvas.SetActive(false);
    }
}