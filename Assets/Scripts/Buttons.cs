using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Buttons : MonoBehaviour
{
    public GameObject buttons;
    
    
    void Start()
    {
        Time.timeScale = 1.0f;
    }


    void Update()
    {
       
    }
   public void howtoPlay(GameObject panel)
    {
        panel.SetActive(true);
       
    }
    public void howtoStop(GameObject panel) 
    {
        panel.SetActive(false);
    }

    public void CikisButonu()
    {
        
        Application.Quit();
        
    }
    public void GirisButonu()
    {
        
        SceneManager.LoadScene(1);
        
    }
   

}
