using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    public int health = 10; 
    private SpriteRenderer spriteRenderer;
	public GameObject explosion;
	void Start()
    {
		spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.flipX = true;
	}

    // Update is called once per frame
    void Update()
    {
        float distanceX = -moveSpeed * Time.deltaTime;
        transform.Translate(distanceX, 0, 0);
	}
	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Bullet")
		{
			if(health > 0)
			{
				Destroy(collision.gameObject);

				health--;
				if (health <= 0)
				{
					Instantiate(explosion, transform.position, Quaternion.identity);
					Destroy(gameObject);
				}
			}
		}
	}
}
