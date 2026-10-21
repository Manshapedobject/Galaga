using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
public float speed = 6;
public int points = 100;
void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime);
        if(transform.position.x > 7)
        {
            Destroy(gameObject);
        }
    }
}
