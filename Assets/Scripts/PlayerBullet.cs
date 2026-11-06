using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
public float speed = 6;
public int points = 100;
void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime);
        if(transform.position.y > 6)
        {
            Destroy(gameObject);
        }
    }
}
