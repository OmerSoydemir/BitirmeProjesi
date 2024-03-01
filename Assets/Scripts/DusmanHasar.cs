using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DusmanHasar : MonoBehaviour
{
    public float hiz = 2f;
    public float Can = 50f;
    public Rigidbody2D rb;
    public GameObject dusmanBulletPrefab;
    public Transform atesNoktasi;
    public Slider slider;
    

    void Start()
    {
        slider.maxValue = Can;
        slider.value = Can;
        rb.velocity = new Vector2(-hiz, rb.velocity.y);
        InvokeRepeating("AteþEt", 1f, 1f); 
    }
   

    void AteþEt()
    {
        GameObject bullet = Instantiate(dusmanBulletPrefab, atesNoktasi.position, Quaternion.identity);
        
        Destroy(bullet, 5f); 
    }

    public void CanAzalt(float damage)
    {
        Can -= damage;
        slider.gameObject.SetActive(true);
        slider.value = Can;
        if (Can <= 0)
        {
            Destroy(gameObject);
            
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Dost")
        {
            Player dost = collision.gameObject.GetComponent<Player>();
            DostBase dostBase = collision.gameObject.GetComponent<DostBase>();
            
            if (dost != null)
            {
                dost.CanAzalt(10f);
                
            }
            if(dostBase != null)
            {
                dostBase.CanAzaltBase(20f);
            }

            Destroy(gameObject);
        }
        
    }
}
