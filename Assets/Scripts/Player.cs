using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float speed = 5f;
    private Rigidbody2D rb;
    public float OyuncuCan = 200f;
    public Slider slider;
    public GameObject panel;
    public AudioSource audio;
    


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        slider.maxValue = OyuncuCan;
        Invoke("hasarArttir", 35f);
    }

    void Update()
    {
        FireBullet();
        MovePlayer();
    }

    void FireBullet()
    {
        if (Input.GetButtonDown("Fire1")&&Time.timeScale==1)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            audio.Play();
        }
    }

    void MovePlayer()
    {
        float moveY = Input.GetAxis("Vertical");

        Vector2 moveDir = new Vector2(0, moveY);
        rb.velocity = moveDir * speed;
    }
    public void CanAzalt(float damage)
    {
        OyuncuCan -= damage;
        slider.gameObject.SetActive(true);
        slider.value = OyuncuCan;
        if (OyuncuCan <= 0)
        {
            panel.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
    void hasarArttir()
    {
        Bullet bullet = bulletPrefab.GetComponent<Bullet>();
        bullet.damage = 20f;
    }
}
