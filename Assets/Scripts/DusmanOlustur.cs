using System.Collections;
using UnityEngine;

public class Dusman : MonoBehaviour
{
    public GameObject[] dusmanKarakterleri;
    public GameObject[] dusmanKarakterleri2;
    public Transform[] spawnPozisyonlari;

    private bool dusmanKarakterleriDegisti = false;

    void Start()
    {
        InvokeRepeating("DusmanOlustur", 2f, 2f);
        Invoke("DusmanKarakterleriDegistir", 20f);
    }

    void DusmanOlustur()
    {
        GameObject[] kullanilacakDusmanlar = dusmanKarakterleri;
        if (dusmanKarakterleriDegisti)
        {
            kullanilacakDusmanlar = dusmanKarakterleri2;
        }

        int rastgeleDusman = Random.Range(0, kullanilacakDusmanlar.Length);
        int rastgelePozisyon = Random.Range(0, spawnPozisyonlari.Length);

        Instantiate(kullanilacakDusmanlar[rastgeleDusman], spawnPozisyonlari[rastgelePozisyon].position, kullanilacakDusmanlar[rastgeleDusman].transform.rotation);
    }

    void DusmanKarakterleriDegistir()
    {
        dusmanKarakterleriDegisti = true;
        CancelInvoke("DusmanOlustur");
        InvokeRepeating("DusmanOlustur", 1.5f, 1.5f); 
    }
}
