using UnityEngine;

public class DusmanBullet: MonoBehaviour
{
    public float damage = 10f;
    public float speed = 3f;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = Vector2.left * speed;
        Destroy(gameObject, 0.5f);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dost")
        {
            Player dost = collision.gameObject.GetComponent<Player>();
            if (dost != null)
            {
                dost.CanAzalt(damage);
            }

            if (dost != null && dost.OyuncuCan <= 0)
            {
                Destroy(collision.gameObject);
            }

            Destroy(gameObject);
        }
    }
}
