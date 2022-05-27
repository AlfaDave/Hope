using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AsyncManager : MonoBehaviour
{
    public Text quoteText, quoteByName;
    private AsyncLoader async;
    private string q1, q2, q3, q4, q5, q6, q7, q8, q9, q10;

    private string q1_Aut, q2_Aut, q3_Aut, q4_Aut, q5_Aut, q6_Aut, q7_Aut, q8_Aut, q9_Aut, q10_Aut;
    private float timer1 = 3f, timer2 = 3f;
    private bool timerGo = true, timerStop = false;
    public enum Quote { Quote_1, Quote_2, Quote_3, Quote_4, Quote_5, Quote_6, Quote_7, Quote_8, Quote_9, Quote_10 };
    public Quote quote;
    void Start()
    {
        Quotes();
        RandomQuote();
        async = GameObject.Find("AsyncLoader").GetComponent<AsyncLoader>();
        async.LoadAsync("Game");
    }
    private void Update()
    {
        if (timerGo) { timer1 -= Time.deltaTime; if (timer1 <= 0) { timer1 = 3; RandomQuote(); timerStop = true; timerGo = false; } }
        if (timerStop) { timer2 -= Time.deltaTime; if (timer2 <= 0) { timer2 = 3; RandomQuote(); timerGo = true; timerStop = false; } }
    }
    private void Quotes()
    {
        q1 = "“We cannot solve problems with the kind of thinking we employed when we came up with them.”";
        q1_Aut = "Albert Einstein";
        q2 = "“Learn as if you will live forever, live like you will die tomorrow.”";
        q2_Aut = "Mahatma Gandhi";
        q3 = "“Nature has given us all the pieces required to achieve exceptional wellness and health, but has left it to us to put these pieces together.”";
        q3_Aut = "Diane McLaren";
        q4 = "“Success is not final; failure is not fatal: It is the courage to continue that counts.”";
        q4_Aut = "Winston S. Churchill";
        q5 = "“Success usually comes to those who are too busy looking for it.”";
        q5_Aut = "David Thoreau";
        q6 = "“When we strive to become better than we are, everything around us becomes better too.”";
        q6_Aut = "Paulo Coelho";
        q7 = "“Opportunities don't happen, you create them.”";
        q7_Aut = "Chris Grosser";
        q8 = "“You cannot plow a field by turning it over in your mind. To begin, begin.”";
        q8_Aut = "Gordon B. Hinckley";
        q9 = "“When you arise in the morning think of what a privilege it is to be alive, to think, to enjoy, to love…”";
        q9_Aut = "Marcus Aurelius";
        q10 = "“Someone's sitting in the shade today because someone planted a tree a long time ago.”";
        q10_Aut = "Warren Buffet";
    }
    private void RandomQuote()
    {
        int i = Random.Range(1, 11);
        switch (i)
        {
            case 1:
                quoteText.text = q1;
                quoteByName.text = q1_Aut;
                return;
            case 2:
                quoteText.text = q2;
                quoteByName.text = q2_Aut;
                return;
            case 3:
                quoteText.text = q3;
                quoteByName.text = q3_Aut;
                return;
            case 4:
                quoteText.text = q4;
                quoteByName.text = q4_Aut;
                return;
            case 5:
                quoteText.text = q5;
                quoteByName.text = q5_Aut;
                return;
            case 6:
                quoteText.text = q6;
                quoteByName.text = q6_Aut;
                return;
            case 7:
                quoteText.text = q7;
                quoteByName.text = q7_Aut;
                return;
            case 8:
                quoteText.text = q8;
                quoteByName.text = q8_Aut;
                return;
            case 9:
                quoteText.text = q9;
                quoteByName.text = q9_Aut;
                return;
            case 10:
                quoteText.text = q10;
                quoteByName.text = q10_Aut;
                return;
        }
    }
}
