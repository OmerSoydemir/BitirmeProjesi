using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sayac : MonoBehaviour
{
    public Text countdownText;
    public GameObject panel;

    private float totalTime = 90f; 
    private float timeLeft;

    void Start()
    {
        timeLeft = totalTime;
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft > 0)
        {
            UpdateCountdownText();
        }
        else
        {
            timeLeft = 0;
            CountdownFinished();
        }
    }

    void UpdateCountdownText()
    {
        int minutes = Mathf.FloorToInt(timeLeft / 60);
        int seconds = Mathf.FloorToInt(timeLeft % 60);
        countdownText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void CountdownFinished()
    {
        panel.SetActive(true);
        Time.timeScale = 0f;
        
    }
}
