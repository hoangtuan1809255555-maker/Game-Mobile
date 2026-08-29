using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;

    public GameObject explosionPrefab;

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Đạn bắn trúng Enemy
        if (other.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);

            // Tạo vụ nổ tại vị trí Enemy
            if (explosionPrefab != null)
            {
                Instantiate(
                    explosionPrefab,
                    transform.position,
                    Quaternion.identity
                );
            }

            // Cộng điểm
            if (ScoreManager.instance != null)
            {
                ScoreManager.instance.AddScore(10);
            }

            // Enemy chết
            Destroy(gameObject);
        }

        // Player đâm Enemy
        if (other.CompareTag("Player"))
        {
            PlayerHealth playerHealth =
                other.GetComponent<PlayerHealth>();

            if (playerHealth != null)
            {
                playerHealth.TakeDamage(1);
            }

            Destroy(gameObject);
        }
    }
}