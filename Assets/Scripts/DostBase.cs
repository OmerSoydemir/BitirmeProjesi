using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DostBase : MonoBehaviour
{
    public float BaseCan = 500;
    public Slider slider;
    public GameObject panel;
    void Start()
    {
        
    }
    public void CanAzaltBase(float damage)
    {
        BaseCan -= damage;
        slider.gameObject.SetActive(true);
        slider.value = BaseCan;
        if (BaseCan <= 0)
        {
            panel.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }


    void Update()
    {
        
    }
}
