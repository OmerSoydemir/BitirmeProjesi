using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage = 10f;
    public float speed = 5f;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = Vector2.right * speed;
        Destroy(gameObject, 0.7f);
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dusman")
        {
            DusmanHasar dusman = collision.gameObject.GetComponent<DusmanHasar>();
            if (dusman != null)
            {
                dusman.CanAzalt(damage);
            }

            if (dusman != null && dusman.Can <= 0)
            {
                Destroy(collision.gameObject);
            }

            Destroy(gameObject);
        }
    }

   

   
}
