using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float moveSpeed = 2f;
	public GameObject explosion;  //폭발 이펙트 가져오기 위한 변수
	void Start()
    {

	}

    // Update is called once per frame
    void Update()
    {
        //Y 축 이동
        transform.Translate(0, moveSpeed * Time.deltaTime, 0);
	}
	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		//불렛과 적 충돌시
		if (collision.tag == "Enemy")
		{
			GameManager.instance.Add(10);
			SoundManager.instance.SoundDie();
			//폭발 이펙트 생성
			Instantiate(explosion, transform.position, Quaternion.identity);
			//적 지우기
			Destroy(collision.gameObject);
			//총알 지우기 자기자신
			Destroy(gameObject);
		}
	}
}
