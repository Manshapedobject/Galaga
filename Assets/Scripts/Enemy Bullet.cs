using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 6;
    void Start()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);
        if (transform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        transform.Translate(-transform.up * speed * Time.deltaTime);
    }
}
